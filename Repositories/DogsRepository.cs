using System;
using System.Collections.Generic;
using dogRoundUp.Models;
using dogRoundUp.db;

namespace dogRoundUp.Services
{
    public class DogsRepository
    {
        internal List<Dog> GetDogs()
        {
            return Db.Dogs;
        }
    }
}