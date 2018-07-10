using ProjetoDeTeste.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste.Infra.Data.EntityConfig
{
    public class FornecedoresConfiguration : EntityTypeConfiguration<Fornecedores>
    {
        public FornecedoresConfiguration()
        {
            HasKey(m => m.FornecedorId);
            Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
