﻿using CursoRESTComNetCore.Model;
using CursoRESTComNetCore.Model.Context;
using CursoRESTComNetCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CursoRESTComNetCore.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonBusiness _repository;

        public PersonBusinessImplementation(IPersonBusiness repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()       
        {
            return _repository.FindAll();
        }


        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }


        public Person Create(Person person)
        {          
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }            

    }
}
