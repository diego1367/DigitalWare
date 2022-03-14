using DigitalWare.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Core.Interfaces
{
    public interface IRepository
    {
        List<Productos> GetProductos();
        List<Clientes> GetClientes();
        Productos GetProducto(int id);
        Clientes GetCliente(int id);
        Productos AddProducto(Productos produ);
        Clientes AddCliente(Clientes Cli);
        int DeleteProducto(int id);
        int DeleteCliente(int id);
        Productos UpdateProducto(Productos produ);

    }
}
