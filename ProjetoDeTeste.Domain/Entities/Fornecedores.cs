
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDeTeste.Domain.Entities
{
    public class Fornecedores
    {
        [Key]
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
