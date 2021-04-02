using DesafioApi.Model;
using DesafioApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Repository.Implementation
{
    public class AlunoRepositoryImplementation : IAlunoRepository
    {
        private MySQLContext _context;
        public AlunoRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Aluno Create(Aluno aluno)
        {
            try
            {
                _context.Add(aluno);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return aluno;
        }

        public Aluno Update(Aluno aluno)
        {

            if (!Exists(aluno.Id)) return new Aluno();

            var result = _context.Alunos.SingleOrDefault(b => b.Id == aluno.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(aluno);
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
            return _context.Alunos.Any(b => b.Id.Equals(id));
        }

        public List<Aluno> FindAll()
        {
            return _context.Alunos.ToList();
        }

        public Aluno FindById(long id)
        {
            return _context.Alunos.SingleOrDefault(p => p.Id.Equals(id));
        }

        
        public void Delete(long id)
        {
            var result = _context.Alunos.SingleOrDefault(i => i.Id.Equals(id));
            try
            {
                if (result != null) _context.Alunos.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
