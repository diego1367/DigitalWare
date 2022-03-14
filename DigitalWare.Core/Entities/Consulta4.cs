using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWare.Core.Entities
{
    public class Consulta4
    {
        #region Campos
        /// <summary>
        /// Identificador
        /// </summary>
        private int _IdProducto;
        /// <summary>
        /// Campo Nombre Producto
        /// </summary>
        private String _NombreProducto;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private decimal _Total;
        /// <summary>
        /// TotalVendido
        /// </summary>
        private int _TotalVendido;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private DateTime _Mes;

        #endregion

        #region Propiedades
        /// <summary>
        /// Identificador
        /// </summary>
        [Key]
        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }
        /// <summary>
        /// Nombre Producto
        /// </summary>
        public String NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        /// <summary>
        /// TotalVendido
        /// </summary>
        public int TotalVendido
        {
            get { return _TotalVendido; }
            set { _TotalVendido = value; }
        }
        /// <summary>
        /// Fecha Nacimiento
        /// </summary>
        public DateTime Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }
        #endregion
    }
}
