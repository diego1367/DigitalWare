using DigitalWare.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Core.Interfaces
{
    public interface IRepositoryQuery
    {
        Ventas InsertVenta(Ventas Ven);
        List<Productos> GetConsulta2();

        List<Consulta3> GetConsulta3();

        List<Consulta4> GetConsulta4();

        List<Consulta5> GetConsulta5();

    }
}
