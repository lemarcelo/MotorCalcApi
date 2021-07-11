using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using MotorCalcApi.Models;

namespace MotorCalcApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)//Connection string ficaria aqui
            :base(options)
        {   
        }
        public DbSet<Medidas> Products { get; set; }
    }
}