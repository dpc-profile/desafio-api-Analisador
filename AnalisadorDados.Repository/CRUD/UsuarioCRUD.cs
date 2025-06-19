using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.CRUD;

public class UsuarioCRUD : IUsuarioCRUD
{
    private readonly MainDbContext _context;

    public UsuarioCRUD(MainDbContext context)
    {
        _context = context;
    }


    public async Task<int> GravarUsuario(USER user)
    {
        _context.Add(user);
        await _context.SaveChangesAsync();
        
        return 1;
    }
}