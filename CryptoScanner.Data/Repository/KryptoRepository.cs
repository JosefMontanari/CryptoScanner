using CryptoScanner.Data.Database;
using CryptoScanner.Data.Models.DbModels;

namespace CryptoScanner.Data.Repository
{
    public class KryptoRepository
    {
        private readonly AppDbContext _context;
        public KryptoRepository(AppDbContext context)
        {
            _context = context;
        }



        public async Task AddKrypto(KryptoDbModel krypto)
        {
            await _context.AddAsync(krypto);
            await _context.SaveChangesAsync();
        }


    }
}
