using DigitalWare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Infrastructure.Data
{
    public class DigitalContext : DbContext
    {
        public DigitalContext(DbContextOptions<DigitalContext> options) : base(options)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Productos> Productos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Clientes> Clientes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Ventas> Ventas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Consulta3> Consulta3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Consulta4> Consulta4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Consulta5> Consulta5 { get; set; }

    }
}
