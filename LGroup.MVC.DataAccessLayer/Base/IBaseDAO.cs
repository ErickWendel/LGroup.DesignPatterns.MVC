using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVC.DataAccessLayer.Base
{
   public interface IBaseDAO<TDTO>
    {
        IEnumerable<TDTO> Listar();
        void Cadastrar(TDTO registro_);
    }
}
