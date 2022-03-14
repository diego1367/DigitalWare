using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWare.Core.Entities
{
    public class Ventas
    {
        #region Campos
        /// <summary>
        /// Identificador
        /// </summary>
        private int _IdVentas;
        /// <summary>
        /// Campo Nombre Cliente
        /// </summary>
        private Clientes _idClientes;
        /// <summary>
        /// Campo Apellido Cliente
        /// </summary>
        private Productos _idProductos;
        /// <summary>
        /// Campo Apellido Cliente
        /// </summary>
        private int _CantidadVenta;
        /// <summary>
        /// Fecha
        /// </summary>
        private DateTime _Fecha;

        #endregion

        #region Propiedades
        /// <summary>
        /// Identificador
        /// </summary>
        [Key]
        public int IdVentas
        {
            get { return _IdVentas; }
            set { _IdVentas = value; }
        }
        /// <summary>
        /// Nombre Cliente
        /// </summary>
        public Clientes idClientes
        {
            get { return _idClientes; }
            set { _idClientes = value; }
        }
        /// <summary>
        /// Apellido Cliente
        /// </summary>
        public Productos idProductos
        {
            get { return _idProductos; }
            set { _idProductos = value; }
        }
        /// <summary>
        /// Apellido Cliente
        /// </summary>
        public int CantidadVenta
        {
            get { return _CantidadVenta; }
            set { _CantidadVenta = value; }
        }
        /// <summary>
        /// Apellido Cliente
        /// </summary>
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        #endregion
    }
}
