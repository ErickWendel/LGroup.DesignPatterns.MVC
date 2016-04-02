using System;
using System.Collections.Generic;


//subimos para a memoria, o framework de geracao de regisrtos
using FizzWare.NBuilder;
using LGroup.MVC.DataTransferObject;

//Um projeto BESTA puxou 5 padroes e 3 ferramentas
//MVC, DTO, LAYER SUPER TYPE, DAO, IOC
//NBUILDER, FASTMAPPER, NINJECT
//VIEWMODEL
namespace LGroup.MVC.DataAccessLayer
{
    public sealed class AmigoDAO : Base.IBaseDAO<AmigoDTO>
    {
        //Para gerar uma lista de registros
        //vamos utilizar o  framework NBUILDER (Geracao de Massa de Dados)
        public void Cadastrar(AmigoDTO registro_)
        {
            //finge que cadastrou
        }

        public IEnumerable<AmigoDTO> Listar()
        {

            var amigosTabela = Builder<AmigoDTO>.CreateListOfSize(100).Build();
            return amigosTabela;
        }
    }
}
