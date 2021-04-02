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

        public string ListaDosAlunosPorTurma()
        {
            throw new NotImplementedException();
        }

        public string MediaDosAlunosPorTurma()
        {
            //var query = from t in _context.Turmas
            //            join a in _context.Alunos
            //                on 
            //                group t by t.Id into grupoTurma
            //            select  grupoTurma ;

            //var teste = query.Average(x => x.Key)

        
            return "query";
        }

  
    }
}
