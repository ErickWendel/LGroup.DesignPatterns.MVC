using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVC.Business.Base
{
    public interface IBaseBusiness<TDTO>
    {
        void Cadastrar(TDTO registro_);
        IEnumerable<TDTO> Listar();
    }
}
