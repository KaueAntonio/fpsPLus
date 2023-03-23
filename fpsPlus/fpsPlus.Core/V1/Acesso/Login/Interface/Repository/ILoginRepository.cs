using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fpsPlus.fpsPlus.Core.V1.Acesso.Login.Interface.Repository
{
    public interface ILoginRepository
    {
        Task Login(string usuario, string senha);
    }
}
