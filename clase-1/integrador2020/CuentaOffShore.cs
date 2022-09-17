using clase4_ejercicio5;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace integrador2020
{
    public class CuentaOffShore
    {
        #region ATRIBUTOS

        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        #endregion

        #region PROPIEDADES
        public Cliente _Dueño
        {
            get { return this._dueño; }
            //  set { this._dueño = value; }
            //get => _dueño; set => _dueño = value;
        }
        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }
        #endregion

        #region METODOS

        #region CONSTRUCTOR
        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this.Saldo = saldoInicial;
        }

        /// <summary>
        /// constructor con los parametros que recibe crea un nuevo cliente(dueno y tipo)
        /// </summary>
        /// <param name="dueño"></param>
        /// <param name="tipo"></param>
        /// <param name="numero"></param>
        /// <param name="saldoInicial"></param>
        public CuentaOffShore(string dueño, ETipoCliente tipo, int numero, double saldoInicial)
            : this(new Cliente(tipo, dueño), numero, saldoInicial)
        {

        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// recibe una cuenta off shore y devuelve el numero de cuenta int
        /// </summary>
        /// <param name="cos"></param>
        public static explicit operator int(CuentaOffShore cos)
        {
            int i;
            i = cos._numeroCuenta;
            return i;
        }

        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno = false;
          // evaluo si el numero de cuenta es identico
          //evaluo alias: del cos1 > dueno > obtener alias
            if (Equals(cos1._numeroCuenta, cos2._numeroCuenta) && Equals(cos1._Dueño.GetAlias(), cos2._Dueño.GetAlias()))
            {
                retorno = true;
            }
                 
            return retorno;
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2) ;
        }
        #endregion

        #endregion
    }
}
