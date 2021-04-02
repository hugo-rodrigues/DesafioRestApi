﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioApi.Model;

namespace DesafioApi.Repository
{
    public interface IAlunoRepository
    {

        Aluno Create(Aluno aluno);
        Aluno FindById(long id);
        List<Aluno> FindAll();
        Aluno Update(Aluno aluno);
        void Delete(long id);

        bool Exists(long id);

    }
}
