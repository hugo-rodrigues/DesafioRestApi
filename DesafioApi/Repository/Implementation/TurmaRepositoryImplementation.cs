using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Repository.Implementation
{
    public class TurmaRepositoryImplementation : ITurmaRepository
    {
        private MySQLContext _context;
        public TurmaRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Turma Create(Turma turma)
        {
            try
            {
                _context.Add(turma);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return turma;
        }

        public Turma Update(Turma turma)
        {

            if (!Exists(turma.Id)) return new Turma();

            var result = _context.Turmas.SingleOrDefault(b => b.Id == turma.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(turma);
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
            return _context.Turmas.Any(b => b.Id.Equals(id));
        }

        public bool ExistsAlunosComTurmas(long id)
        {
            return _context.Alunos.Any(b => b.TurmaId.Equals(id));
        }

        public List<Turma> FindAll()
        {
            return _context.Turmas.ToList();
        }

        public Turma FindById(long id)
        {
            return _context.Turmas.SingleOrDefault(p => p.Id.Equals(id));
        }


        public void Delete(long id)
        {
            var result = _context.Turmas.SingleOrDefault(i => i.Id.Equals(id));
            try
            {
                if (result != null) _context.Turmas.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ListaDosAlunosPorTurma(long id)
        {
            var query = from turmas in _context.Turmas
                        join alunos in _context.Alunos on turmas.Id equals alunos.TurmaId
                        where id == turmas.Id
                        orderby turmas.Id
                        select new  {turmas.Id , turmas.Nome, nomeAluno = alunos.Nome, alunos.Nota };



            return "query";
        }

        public string MediaDosAlunosPorTurma(long id)
        {
            var query = from turmas in _context.Turmas
                        join alunos in _context.Alunos on turmas.Id equals alunos.TurmaId
                        where id == turmas.Id
                        group new {turmas, alunos } by new {turmas.Id } into g
                        select new {
                        
                        g.Key.Id,
                        nomeTurma = g.Select(x => x.turmas.Nome),
                        mediaAlunos = g.Select(y => y.alunos.Nota).Average()
                        
                        };
            return "query";
        }

  
    }
}
