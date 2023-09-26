using CrudMVC.Controllers;
using CrudMVC.Data;
using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Repositories
{
    public class CaminhaoRepositorio : ICaminhaoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CaminhaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public CaminhaoModel ListarPorId(int id)
        {
            return _bancoContext.Caminhoes.FirstOrDefault(x => x.Id == id);
        }
        public List<CaminhaoModel> BuscarTodos()
        {
            return _bancoContext.Caminhoes.ToList();
        }
        public CaminhaoModel Adicionar(CaminhaoModel caminhao)
        {
            _bancoContext.Caminhoes.Add(caminhao);
            _bancoContext.SaveChanges();
            return caminhao;
        }

        public CaminhaoModel Atualizar(CaminhaoModel caminhao)
        {
            CaminhaoModel caminhaoDb = ListarPorId(caminhao.Id);

            if (caminhaoDb == null) throw new System.Exception("Houve um erro na ataulização do caminhão");


            caminhaoDb.Nome = caminhao.Nome;
            caminhaoDb.Descricao = caminhao.Descricao;
            caminhaoDb.DataDeCriacao = caminhao.DataDeCriacao;

            _bancoContext.Caminhoes.Update(caminhaoDb);
            _bancoContext.SaveChanges();

            return caminhaoDb;

        }

        public bool Apagar(int id)
        {
            CaminhaoModel caminhaoDb = ListarPorId(id);

            if (caminhaoDb == null) throw new System.Exception("Houve um erro na deleção do caminhao");

            _bancoContext.Caminhoes.Remove(caminhaoDb);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
