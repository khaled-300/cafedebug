﻿using log4net;
using System;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Services;

namespace Cafedebug.Service
{
    /// <summary>
    /// Serviço do Usuário
    /// </summary>
    public class UsuarioService : BaseService, IUsuarioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioService));

        public UsuarioService(INotificador notificador) : base(notificador)
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
