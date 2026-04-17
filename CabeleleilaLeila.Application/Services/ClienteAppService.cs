using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeila.Application.Services
{
    public class ClienteAppService
    {

        #region fields 
            private readonly CabeleleilaLeila.Data.Repositories.ClienteRepository _clienteRepository;
        #endregion

        #region constructor
        public ClienteAppService()
        {
            _clienteRepository = new Data.Repositories.ClienteRepository();
        }
        #endregion

        #region methods
        public System.Data.DataTable LoadFromDataBase(Microsoft.Extensions.Configuration.IConfiguration config)
        {
            return _clienteRepository.LoadFromDataBase(config);
        }
        #endregion

    }
}
