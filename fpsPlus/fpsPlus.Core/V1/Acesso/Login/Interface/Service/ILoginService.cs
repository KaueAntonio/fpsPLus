using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fpsPlus.fpsPlus.Core.V1.Acesso.Login.Interface.Service
{
    public interface ILoginService
    {
        Task Login(string usuario, string senha);
    }
}
