﻿using Contexto.Data.Interface;
using System;
using System.Threading.Tasks;
using Contexto.Models;

namespace Contexto.Data.Interface
{
    public interface IUsuarioRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SavechangesAsync();
        Task<Usuario[]> GetTodosUsuarios();
    }
}
