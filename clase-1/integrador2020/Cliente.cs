using clase4_ejercicio5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrador2020
{
    public class Cliente
    {
        
        #region ATRIBUTOS
        private string _aliasParaIncognito;
        private string _nombre;
        private ETipoCliente _TipoCliente;
        #endregion

        #region CONSTRUCTOR
        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._TipoCliente = ETipoCliente.SinTipo;
        }
        #endregion

        #region METODOS
        public Cliente(ETipoCliente tipoCliente) : this()
        { 
            this._TipoCliente = tipoCliente;
        }
        public Cliente(ETipoCliente tipoCliente,string nombre) : this( tipoCliente)
        {
            this._nombre = nombre;
        }

        public void CrearAlias()
        {
            Random random = new Random();
            this._aliasParaIncognito = $"{random.Next(1000, 9999).ToString()}{this._TipoCliente}";
        }

        public string GetAlias()
        {
            
            if (_aliasParaIncognito == "Sin alias")
            {
                CrearAlias();
            }

            return this._aliasParaIncognito;
        }

        public string RetornarDatos()
        {
            StringBuilder sbCliente = new StringBuilder();

            sbCliente.AppendLine($"Nombre: {this._nombre}");
            sbCliente.AppendLine($"Tipo de cliente: {this._TipoCliente.ToString()}");
            sbCliente.AppendLine($"Alias {GetAlias()}");
            return sbCliente.ToString();
        }
        #endregion
    }
}
