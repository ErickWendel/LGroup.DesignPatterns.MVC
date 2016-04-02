using LGroup.MVC.DataTransferObject;
using System;
using System.Collections.Generic;


using LGroup.MVC.DataAccessLayer;
using LGroup.MVC.DataAccessLayer.Base;
//Sempre que criamos uma classe para poder utilizar
//tem que dar NEW (Se nao der vai dar erro de NULL REFERENCE)

//MAS 'E MA PRATICA
//Quando uma classe da NEW em outra
//Nos criamos uma FORTE DEPENDENCIA (FORTE ACOPLAMENTO)
//Entre as 2 CLASSES (1 classe virou refem da outra classe)
//O padrao que fala que isso 'e ma pratica 'e o IOC
//Inversao de Controle
//A partir de hoje nunca mais daremos new nas classes

//Nao levar ao extremo
//So pode dar new em classes BESTINHAS, armazenamento de dados
//DTO, MODEL, VIEWMODEL, DOMAINENTITY, VO

namespace LGroup.MVC.Business
{
    public sealed class AmigoBusiness : Base.IBaseBusiness<AmigoDTO>
    {
        private readonly AmigoDAO _dados;
        public AmigoBusiness(AmigoDAO dados_)
        {
            _dados = dados_;
        }
        public void Cadastrar(AmigoDTO registro_)
        {
            _dados.Cadastrar(registro_);
        }

        public IEnumerable<AmigoDTO> Listar()
        {
            return _dados.Listar();
        }
    }
}
