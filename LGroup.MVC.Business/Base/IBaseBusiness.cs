using System.Collections.Generic;

namespace LGroup.MVC.Business.Base
{
    public interface IBaseBusiness<T>
    {
        void Cadastrar(T registro_);
        IEnumerable<T> Listar();
    }
}
