using HospitalVitorWolmerAPI.Dominio;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;

namespace HospitalVitorWolmerAPI.Contexto
{
    public class DBContexto :  DbContext
    {
        public DbSet<Medico> Medicos { get; set; }

        public DBContexto(DbContextOptions<DBContexto> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.ApplyConfiguration(new MedicoMapping());
        }


    }
}
