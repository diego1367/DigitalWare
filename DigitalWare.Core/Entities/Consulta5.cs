using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWare.Core.Entities
{
    public class Consulta5
    {
        #region Campos
        /// <summary>
        /// Identificador
        /// </summary>
        private int _IdCliente;
        /// <summary>
        /// Campo Nombre Producto
        /// </summary>
        private String _NombreCliente;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private DateTime _PrimeraFecha;
        /// <summary>
        /// TotalVendido
        /// </summary>
        private DateTime _UltimaFecha;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private DateTime _FechaPromedio;

        #endregion

        #region Propiedades
        /// <summary>
        /// Identificador
        /// </summary>
        [Key]
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        /// <summary>
        /// Nombre Cliente
        /// </summary>
        public String NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }
        /// <summary>
        /// Total
        /// </summary>
        public DateTime PrimeraFecha
        {
            get { return _PrimeraFecha; }
            set { _PrimeraFecha = value; }
        }
        /// <summary>
        /// TotalVendido
        /// </summary>
        public DateTime UltimaFecha
        {
            get { return _UltimaFecha; }
            set { _UltimaFecha = value; }
        }
        /// <summary>
        /// Fecha Nacimiento
        /// </summary>
        public DateTime FechaPromedio
        {
            get { return _FechaPromedio; }
            set { _FechaPromedio = value; }
        }
        #endregion
    }
}
