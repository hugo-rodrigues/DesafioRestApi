using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DesafioApi.Repository.Implementation
{
    public class EscolaRepositoryImplementation : IEscolaRepository
    {
        private MySQLContext _context;
        public EscolaRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }



        public Escola Create(Escola escola)
        {
            try
            {
                _context.Add(escola);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return escola;
        }

        public Escola Update(Escola escola)
        {

            if (!Exists(escola.Id)) return new Escola();

            var result = _context.Escolas.SingleOrDefault(b => b.Id == escola.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(escola);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;
        }

        public bool Exists(long id)
        {
            return _context.Escolas.Any(b => b.Id.Equals(id));
        }

        public bool ExistsTurmasComEscola(long id)
        {
            return _context.Turmas.Any(b => b.EscolaId.Equals(id));
        }

        public List<Escola> FindAll()
        {
            return _context.Escolas.ToList();
        }

        public Escola FindById(long id)
        {
            return _context.Escolas.SingleOrDefault(p => p.Id.Equals(id));
        }


        public void Delete(long id)
        {
            var result = _context.Escolas.SingleOrDefault(i => i.Id.Equals(id));
            try
            {
                if (result != null) _context.Escolas.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<string> ListaDosAlunosPorTurma(long id)
        {
            var query = from turmas in _context.Turmas
                        join alunos in _context.Alunos on turmas.Id equals alunos.TurmaId
                        join escolas in _context.Escolas on turmas.EscolaId equals escolas.Id
                        orderby turmas.Id
                        where id == escolas.Id
                        select new { turmas.Id, turmas.Nome, nomeAluno = alunos.Nome, alunos.Nota }.ToString(); ;



            
            return query;
        }

        public string MediaDosAlunosPorTurma(long id)
        {
          
            var query = from turmas in _context.Turmas
                        where id == turmas.EscolaId
                        select new
                        {
                            turmas.Id,
                            turmas.Nome,
                            mediaAlunos = _context.Alunos.Where(a => a.TurmaId == turmas.Id).Average(a => a.Nota)

                        };
            string jsonString = JsonSerializer.Serialize(query);
            return jsonString;
        }
    }
}
