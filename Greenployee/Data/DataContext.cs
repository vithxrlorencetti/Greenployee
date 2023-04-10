using Greenployee.Model;
using Microsoft.EntityFrameworkCore;

namespace Greenployee.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<OrdemServico> OrdensServicos { get; set; }

    }
}
