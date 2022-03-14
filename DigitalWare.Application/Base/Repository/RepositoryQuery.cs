using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Application.Base.Repository
{
    public class RepositoryQuery : IRepositoryQuery
    {
 
        private readonly DigitalContext _context;
        public RepositoryQuery(DigitalContext context)
        {
            _context = context;
        }
        public List<Productos> GetConsulta2()
        {
            return _context.Productos.FromSqlRaw("[dbo].[spCOnsulta2]").AsEnumerable().ToList();

        }

        public List<Consulta3> GetConsulta3()
        {
            return _context.Consulta3.FromSqlRaw("[dbo].[spCOnsulta3]").AsEnumerable().ToList();

        }

        public List<Consulta4> GetConsulta4()
        {
            return _context.Consulta4.FromSqlRaw("[dbo].[spCOnsulta4]").AsEnumerable().ToList();

        }

        public List<Consulta5> GetConsulta5()
        {
            return _context.Consulta5.FromSqlRaw("[dbo].[spCOnsulta5]").AsEnumerable().ToList();
        }

        public Ventas InsertVenta(Ventas Ven)
        {
            using (SqlConnection sql = new SqlConnection("Server=DIEGOALEJANF3D6;Database=Prueba;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("spInsert", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idClientes", Ven.idClientes.Id));
                    cmd.Parameters.Add(new SqlParameter("@idProductos", Ven.idProductos.Id));
                    cmd.Parameters.Add(new SqlParameter("@cantidad", Ven.CantidadVenta));
                    var a = Ven.idProductos.CantidadInventario - Ven.CantidadVenta;
                    cmd.Parameters.Add(new SqlParameter("@cantidadInventario", a));
                    cmd.Parameters.Add(new SqlParameter("@fecha", Ven.Fecha));
                     sql.Open();
                     cmd.ExecuteReader();
                    return Ven;
                }
            }
        }
    }
}
