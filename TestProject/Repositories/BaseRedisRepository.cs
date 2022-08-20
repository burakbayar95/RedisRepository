﻿using Nhea.Data.Repository.RedisRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Repositories
{
    public abstract class BaseRedisRepository<T> : Nhea.Data.Repository.RedisRepository.BaseRedisRepository<T>
         where T : RedisDocument, new()
    {
        public override string ConnectionString => "localhost:6379,abortConnect=false,connectTimeout=10000,connectRetry=10";
    }
}
