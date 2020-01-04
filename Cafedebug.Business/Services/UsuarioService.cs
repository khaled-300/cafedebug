﻿using System.Collections.Generic;
using log4net;
using Unity;
using System;
using Cafedebug.Business;
using System.Runtime.CompilerServices;

namespace Cafedebug.Service
{
    /// <summary>
    /// Serviço do Usuário
    /// </summary>
    public class UsuarioService : IUsuarioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioService));

        /// <summary>
        /// Repositório do Usuário
        /// </summary>
        [Unity.Dependency]
        public Lazy<IUsuarioRepository> UsuarioRepository { get; set; }

        /// <summary>
        /// Insere um novo usuário
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Save(Usuario obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Atualiza um usuario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui um usuário
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de usuários
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// REcupera um usuário por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
