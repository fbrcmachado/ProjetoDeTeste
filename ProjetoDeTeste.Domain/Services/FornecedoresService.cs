using ProjetoDeTeste.Domain.Entities;
using ProjetoDeTeste.Domain.Interfaces.Services;
using ProjetoDeTeste.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste.Domain.Services
{
    public class FornecedoresService : ServiceBase<Fornecedores>, IFornecedoresService
    {
        private readonly IFornecedoresRepository _repository;
        public FornecedoresService(IFornecedoresRepository repository) : base(repository)
        {
            _repository = repository;

        }
    }
}
