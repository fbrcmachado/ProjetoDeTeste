using ProjetoDeTeste.AppService.Interfaces;
using ProjetoDeTeste.Domain.Entities;
using ProjetoDeTeste.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste.AppService
{
    public class FornecedoresAppService : AppServiceBase<Fornecedores>, IFornecedoresAppService
    {
        private readonly IFornecedoresService _service;

        public FornecedoresAppService(IFornecedoresService service) : base(service)
        {
            _service = service;
        }
    }
}
