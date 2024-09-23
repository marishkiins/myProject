﻿using DataAccess.Models;
using DataAccess.Interfaces;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(SmirnovaPlanGoDbContext repositoryContext) 
            : base(repositoryContext) 
        {
        }
    }
}
