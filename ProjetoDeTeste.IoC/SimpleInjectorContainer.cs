using ProjetoDeTeste.Domain.Repositories;
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
            
            //container.Register<IClientService, ClientService>();
            container.Register<IFornecedoresRepository, FornecedoresRepository>();
            container.Verify();
            return container;
        }

    }
}
