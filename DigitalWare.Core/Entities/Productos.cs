using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWare.Core.Entities
{
    public class Productos
    {
        #region Campos
        /// <summary>
        /// Identificador
        /// </summary>
        private int _Id;
        /// <summary>
        /// Campo Nombre Producto
        /// </summary>
        private String _NombreProducto;
        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private Decimal _PrecioProducto;

        /// <summary>
        /// Campo Costo Producto
        /// </summary>
        private int _CantidadInventario;
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
        public String NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }
        /// <summary>
        /// Costo Producto
        /// </summary>
        public Decimal PrecioProducto
        {
            get { return _PrecioProducto; }
            set { _PrecioProducto = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CantidadInventario
        {
            get { return _CantidadInventario; }
            set { _CantidadInventario = value; }
        }
        #endregion
    }
}
