using CrudMVC.Models;

namespace CrudMVC.Repositories
{
    public interface ICaminhaoRepositorio
    {
        CaminhaoModel ListarPorId(int id);
        List<CaminhaoModel> BuscarTodos();
        CaminhaoModel Adicionar(CaminhaoModel caminhao);
        CaminhaoModel Atualizar(CaminhaoModel caminhao);
        bool Apagar(int id);

    }
}
