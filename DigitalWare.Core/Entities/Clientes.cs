using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWare.Core.Entities
{
    public class Clientes
    {
        #region Campos
        /// <summary>
        /// Identificador
        /// </summary>
        private int _Id;
        /// <summary>
        /// Campo Nombre Cliente
        /// </summary>
        private String _NombreCliente;
        /// <summary>
        /// Campo Apellido Cliente
        /// </summary>
        private String _ApellidoCliente;
        /// <summary>
        /// Tipo Documento
        /// </summary>
        private int _TipoDocumento;
        /// <summary>
        /// Campo Cedula
        /// </summary>
        private int _Cedula;
        /// <summary>
        /// Numero Celular
        /// </summary>
        private int _NumeroCelular;
        /// <summary>
        /// Campo Fecha Nacimiento
        /// </summary>
        private DateTime? _FechaNacimiento;
        #endregion

        #region Propiedades
        /// <summary>
        /// Identificador
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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
        /// Apellido Cliente
        /// </summary>
        public String ApellidoCliente
        {
            get { return _ApellidoCliente; }
            set { _ApellidoCliente = value; }
        }
        /// <summary>
        /// Cedula
        /// </summary>
        public int TipoDocumento
        {
            get { return _TipoDocumento; }
            set { _TipoDocumento = value; }
        }
        /// <summary>
        /// Cedula
        /// </summary>
        public int Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }
        /// <summary>
        /// Fecha Nacimiento
        /// </summary>
        public DateTime? FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        /// <summary>
        /// Celular
        /// </summary>
        public int NumeroCelular
        {
            get { return _NumeroCelular; }
            set { _NumeroCelular = value; }
        }
        #endregion
    }
}
