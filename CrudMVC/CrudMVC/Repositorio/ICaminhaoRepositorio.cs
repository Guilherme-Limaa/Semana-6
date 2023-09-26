using CrudMVC.Models;

namespace CrudMVC.Repositorio
{
    public interface ICaminhaoRepositorio
    {
        CaminhaoModel Adicionar(CaminhaoModel caminhao);
    }
}
