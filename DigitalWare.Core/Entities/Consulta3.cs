using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWare.Core.Entities
{
    public class Consulta3
    {
        #region Campos
        /// <summary>
        /// Identificador
        /// </summary>
        private int _Id;
        /// <summary>
        /// Campo Nombre Producto
        /// </summary>
        private String _NombreCliente;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private String _ApellidoCliente;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private int _TipoDocumento;
        /// <summary>
        /// Cedula
        /// </summary>
        private int _Cedula;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private int _NumeroCelular;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private DateTime _FechaNacimiento;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private int _IdVentas;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private int _IdProducto;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private int _CantidadVenta;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private DateTime _FechaVenta;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private int _EdadCliente;
        #endregion

        #region Propiedades
        /// <summary>
        /// Identificador
        /// </summary>
        [Key]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        /// <summary>
        /// Nombre Producto
        /// </summary>
        public String NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }
        /// <summary>
        /// Costo Producto
        /// </summary>
        public String ApellidoCliente
        {
            get { return _ApellidoCliente; }
            set { _ApellidoCliente = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TipoDocumento
        {
            get { return _TipoDocumento; }
            set { _TipoDocumento = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }
        /// <summary>
        /// Numero Celular
        /// </summary>
        public int NumeroCelular
        {
            get { return _NumeroCelular; }
            set { _NumeroCelular = value; }
        }
        /// <summary>
        /// Fecha Nacimiento
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        /// <summary>
        ///  IdVentas
        /// </summary>
        public int IdVentas
        {
            get { return _IdVentas; }
            set { _IdVentas = value; }
        }
        /// <summary>
        /// IdProducto
        /// </summary>
        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CantidadVenta
        {
            get { return _CantidadVenta; }
            set { _CantidadVenta = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaVenta
        {
            get { return _FechaVenta; }
            set { _FechaVenta = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EdadCliente
        {
            get { return _EdadCliente; }
            set { _EdadCliente = value; }
        }
        #endregion
    }
}
        
    
