﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoDeTeste.MVC.ViewModels
{
    public class FornecedoresViewModel
    {

        [Key]
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}