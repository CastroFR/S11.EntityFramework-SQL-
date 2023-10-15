using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<ESTUDIANTE> Estudiante { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-GGOC9T3P;Database=PROGRAM2; Trusted_Connection = SSPI; MultipleActiveResultSets = true ");
    }

}

//Encrypt = False