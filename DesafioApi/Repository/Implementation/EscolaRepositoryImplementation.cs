using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string ListaDosAlunosPorTurma()
        {
            throw new NotImplementedException();
        }

        public string MediaDosAlunosPorTurma()
        {
            throw new NotImplementedException();
        }
    }
}
