using ProjetoDeTeste.AppService;
using ProjetoDeTeste.AppService.Interfaces;
using ProjetoDeTeste.Domain.Interfaces.Services;
using ProjetoDeTeste.Domain.Repositories;
using ProjetoDeTeste.Domain.Services;
using ProjetoDeTeste.Infra.Data.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste.IoC
{
    public static class SimpleInjectorContainer

    {

        public static Container RegisterServices()

        {
            var container = new Container();

            //Registrando as Implementações
            
            container.Register<IFornecedoresService, FornecedoresService>();
            container.Register<IFornecedoresRepository, FornecedoresRepository>();
            container.Register<IFornecedoresAppService, FornecedoresAppService>();
            container.Verify();
            return container;
        }

    }
}
