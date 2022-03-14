using DigitalWare.Core.Entities;
using DigitalWare.Core.Interfaces;
using DigitalWare.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWare.Application.Base.Repository
{
    public class Repository : IRepository
    {
        private readonly DigitalContext _context;
        public Repository(DigitalContext context)
        {
            _context = context;
        }

        public Clientes AddCliente(Clientes Cli)
        {
            _context.Clientes.Add(Cli);
            _context.SaveChanges();
            return Cli;
        }

        public Productos AddProducto(Productos produ)
        {
            _context.Productos.Add(produ);
            _context.SaveChanges();
            return produ;
        }

        public int DeleteCliente(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(h => h.Id == id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return cliente.Id;
        }

        public int DeleteProducto(int id)
        {
            var producto = _context.Productos.FirstOrDefault(h => h.Id == id);
            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return producto.Id;
        }

        public Clientes GetCliente(int id)
        {
            return _context.Clientes.FirstOrDefault(a => a.Id == id);
        }

        public List<Clientes> GetClientes()
        {
            return _context.Clientes.ToList();
        }

        public Productos GetProducto(int id)
        {
            return _context.Productos.FirstOrDefault(a => a.Id == id);
        }

        public List<Productos> GetProductos()
        {
            return _context.Productos.ToList();
        }

        public Productos UpdateProducto(Productos produ)
        {
            _context.Entry(produ).State = EntityState.Modified;
            _context.SaveChanges();
            return produ;
        }
    }
}
