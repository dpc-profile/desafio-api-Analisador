using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.CRUD;

public interface IUsuarioCRUD
{
    public Task<int> GravarUsuario(USER user);
}