using Microsoft.EntityFrameworkCore;
using MostWasted.Models;

namespace MostWasted.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public virtual DbSet<ProcuradoModel> Procurado { get; set; }

        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DataBaseContext()
        {

        }

    }
}
