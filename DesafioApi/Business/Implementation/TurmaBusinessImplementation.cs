using DesafioApi.Model;
using DesafioApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Business.Implementation
{
    public class TurmaBusinessImplementation : ITurmaBusiness
    {
        private readonly ITurmaRepository _repository;
        public TurmaBusinessImplementation(ITurmaRepository repository)
        {
            _repository = repository;
        }

        public Turma Create(Turma turma)
        {
            return _repository.Create(turma);
        }

        public void Delete(long id)
        {
            try
            {
                if (!ExistsAlunosComTurmas(id))
                {
                    _repository.Delete(id);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        public List<Turma> FindAll()
        {
            return _repository.FindAll();
        }



        public Turma FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Turma Update(Turma turma)
        {
            return _repository.Update(turma);
        }

        public IQueryable<string> ListaDosAlunosPorTurma(long id)
        {
            return _repository.ListaDosAlunosPorTurma(id);
        }

        public string MediaDosAlunosPorTurma(long id)
        {
            return _repository.MediaDosAlunosPorTurma(id);
        }

        public bool ExistsAlunosComTurmas(long id)
        {
            return _repository.ExistsAlunosComTurmas(id);
        }
    }
}
