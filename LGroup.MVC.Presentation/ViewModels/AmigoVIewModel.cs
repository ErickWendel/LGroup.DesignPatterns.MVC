using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LGroup.MVC.Presentation.ViewModels
{
    //Model no ASPNET MVC 'e meio generico
    //O nome mais correto seria VIEWMODELS
    //Sao dados exclusivos para TElas
    public sealed class AmigoViewModel
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
    }
}