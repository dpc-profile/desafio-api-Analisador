using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.CRUD;

public interface IUsuarioCRUD
{
    public Task<int> GravarUsuario(UserEntity userEntity);
    public IEnumerable<UserEntity> RetornaSuperUser();
    public IEnumerable<UserEntity> RetornarUsuarios();
    public IEnumerable<TeamEntity> RetornarTimes();
}