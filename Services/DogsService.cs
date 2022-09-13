using System;
using System.Collections.Generic;
using dogRoundUp.Models;

namespace dogRoundUp.Services
{
    public class DogsService
    {
        private readonly DogsRepository _dogRepo;
        public DogsService(DogsRepository dogRepo)
        {
            _dogRepo = dogRepo;
        }
        internal List<Dog> GetDogs()
        {
            List<Dog> dogs = _dogRepo.GetDogs();
            return dogs;
        }
    }
}