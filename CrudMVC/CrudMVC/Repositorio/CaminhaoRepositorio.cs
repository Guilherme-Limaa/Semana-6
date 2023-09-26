using CrudMVC.Data;
using CrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMVC.Repositorio
{
    public class CaminhaoRepositorio : ICaminhaoRepositorio
    {

        private readonly BancoContext _bancoContext;
        public CaminhaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public CaminhaoModel Adicionar(CaminhaoModel caminhao)
        {
            _bancoContext.Caminhoes.Add(caminhao);
            _bancoContext.SaveChanges();
            return caminhao;
        }
    }
}
