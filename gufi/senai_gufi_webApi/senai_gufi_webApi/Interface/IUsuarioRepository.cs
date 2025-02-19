﻿using senai_gufi_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_gufi_webApi.Interface
{
    /// <summary>
    /// interface responsável pelo repositório UsuarioRepository
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// valida o usuário
        /// </summary>
        /// <param name="email"> e-mail do usuário</param>
        /// <param name="senha"> senha do usuário</param>
        /// <returns></returns>
        Usuario Login(string email, string senha);
    }
}
