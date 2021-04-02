﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Repository
{
    public interface ITurmaRepository
    {

        Turma Create(Turma turma);
        Turma FindById(long id);
        List<Turma> FindAll();
        Turma Update(Turma turma);
        void Delete(long id);

        bool Exists(long id);

        public string MediaDosAlunosPorTurma();

        public string ListaDosAlunosPorTurma();

        public bool ExistsAlunosComTurmas(long id);
    }
}
