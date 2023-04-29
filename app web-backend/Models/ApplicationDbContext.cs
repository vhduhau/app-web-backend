using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace app_web_backend.Models
{
    public class ApplicationDbContext : DbContext
    {

        // Construtor 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)// Injeção de dependencias // Essas configurações (option vem da startup)
        {

        }
    }
}
