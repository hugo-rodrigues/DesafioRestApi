﻿using DesafioApi.Model;
using DesafioApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi.Business.Implementation
{
    public class EscolaBusinessImplementation : IEscolaBusiness
    {

        private readonly IEscolaRepository _repository;
        public EscolaBusinessImplementation(IEscolaRepository repository)
        {
            _repository = repository;
        }

        public Escola Create(Escola escola)
        {
            return _repository.Create(escola);
        }

        public void Delete(long id)
        {
           
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        public List<Escola> FindAll()
        {
            return _repository.FindAll();
        }



        public Escola FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Escola Update(Escola escola)
        {
            return _repository.Update(escola);
        }

        public string ListaDosAlunosPorTurma()
        {
            return _repository.ListaDosAlunosPorTurma();
        }

        public string MediaDosAlunosPorTurma()
        {
            return _repository.MediaDosAlunosPorTurma();
        }

        public bool ExistsTurmasComEscola(long id)
        {
            return _repository.ExistsTurmasComEscola(id);
        }
    }
}
