﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.Models
{
    public class RegistrarUsuarioViewModelInput
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
