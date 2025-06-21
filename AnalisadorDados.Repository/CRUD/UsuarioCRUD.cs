using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.CRUD;

public class UsuarioCRUD : IUsuarioCRUD
{
    private readonly MainDbContext _context;

    public UsuarioCRUD(MainDbContext context)
    {
        _context = context;
    }

    public async Task<int> GravarUsuario(UserEntity userEntity)
    {
        _context.Add(userEntity);
        await _context.SaveChangesAsync();
        
        return 1;
    }
    
    public IEnumerable<UserEntity> RetornaSuperUser()
    {
        var superUsers = (
            from user in _context.User()
            where user.Score >= 900 && user.Active
            select user
            ).ToList();
        
        return superUsers;
    }
    
    public IEnumerable<UserEntity> RetornarUsuarios()
    {
        return _context.User();
    }
    public IEnumerable<TeamEntity> RetornarTimes()
    {
        return _context.Team();
    }

}