using clase4_ejercicio5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace integrador2020
{
    public class ParaisoFIscal
    {
        #region ATRIBUTOS
        private EParaisosFiscales _lugar;
        private List<CuentaOffShore> _listadoCuentas; 
        static int cantidadDeCuentas;
        static DateTime fechaInicioActividades;
        #endregion

        /// <summary>
        /// Recibe un eParaisosFiscales y retorna un objeto de tipo ParaisoFiscal.
        /// </summary>
        /// <param name="epf"></param>
        public static implicit operator ParaisoFIscal(EParaisosFiscales epf)
        {
            ParaisoFIscal pf = new ParaisoFIscal(epf);
            return pf;
        }
        #region CONSTRUCTORES
        static ParaisoFIscal()//constructor estatico
        {
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;

        }

       private ParaisoFIscal()//constructor de instancia
        {
            _listadoCuentas = new List<CuentaOffShore>();
           // _lugar = EParaisosFiscales.Anguila;
           // cantidadDeCuentas++;
        }
        private ParaisoFIscal(EParaisosFiscales epf) : this()
        {
            
        }
        #endregion

        #region METODOS

       
        public void MostrarParaiso()
        {
            //StringBuilder sbParaisoFiscal = new StringBuilder();


            Console.WriteLine("");
            Console.WriteLine($"Fecha de inicio: {fechaInicioActividades.ToString()}");
            Console.WriteLine($"Lugar radicacion{this._lugar}");
            Console.WriteLine($"Sus cuentas: {cantidadDeCuentas}");
            Console.WriteLine("");
            Console.WriteLine("*********** LISTADO DE CUENTAS OFFSHORES ***********");
            Console.WriteLine("");
            foreach (var cuentas in _listadoCuentas)
            {               
                Console.WriteLine(cuentas._Dueño.RetornarDatos());//obtengo nombre, tipo de cliente y alias
                Console.WriteLine($"Numero de cuenta:{(int)cuentas}");//parametro estatico recibe cuenta offShore y devuelve numero de cuenta
                Console.WriteLine($"Saldo:{cuentas.Saldo}");
                Console.WriteLine("");
            }         
           
        }
        #endregion

        #region SOBRECARGAS

        /// <summary>
        /// en paraiso fisaal, recorro su lista de tipo CuentaOffShore y verfico que la cuenta CuentaOffShore pasado por parametro este contenida.
        /// </summary>
        /// <param name="pf"></param>
        /// <param name="cos"></param>
        /// <returns> verdadero, se contiene y false no se contiene </returns>
        public static bool operator ==(ParaisoFIscal pf, CuentaOffShore cos)
        {
            bool result = false;
            foreach (var cuentas in pf._listadoCuentas)
            {
                result = cuentas == cos;//reutilizo codigo
               //result =  cuentas.Equals(cos);
                if (result == true)
                {
                    break;
                }
            }
            return result ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pf"></param>
        /// <param name="cos"></param>
        /// <returns></returns>
        public static bool operator !=(ParaisoFIscal pf, CuentaOffShore cos)
        {
          return  !(pf == cos);
        }
        /*
        /// <summary>
        ///CuentaOffShore a la lista de cuentas de la clase si la misma se encuentra  en el ParaisoFiscal.
        ///Decrementar en uno el atributo cantidadDeCuentas si se pudo quitar la cuenta.Reutilizar
        /// código.Informar de lo acontecido.
        /// </summary>
        /// <param name="pf"></param>
        /// <param name="cos"></param>
        /// <returns> retorna true si fue sacado con exito y false si no se pudo sacar </returns>
        public static bool operator -(ParaisoFIscal pf, CuentaOffShore cos)
        {
            bool retorno = false;

            if (pf == cos)//verfico si la cuenta esta contenida en paraiso
            {
              retorno =  pf._listadoCuentas.Remove(cos);//saco cuenta de paraiso
                if (retorno == true)
                {
                    cantidadDeCuentas--;//decremento cantidad de cuentas 
                }
            }
            return retorno;
        }

       
       
        /// <summary>
        /// agrega una CuentaOffShore al paraiso fiscal 
        /// </summary>
        /// <param name="pf"></param>
        /// <param name="cos"></param>
        /// <returns> retorna true si la agrego y false si no lo hizo </returns>
        public static bool operator +(ParaisoFIscal pf, CuentaOffShore cos)
        {
            int i;
            bool retorno = false;
            if (pf == cos)//pregunto si la cuenta esta contenida en pf
            {               
              i =  pf._listadoCuentas.IndexOf(cos);//obtengo indice de la list donde se encuentra la cuenta
                pf._listadoCuentas[i].Saldo = pf._listadoCuentas[i].Saldo + cos.Saldo;//sumo saldos             
                return retorno;
            }
            else
            {
               pf._listadoCuentas.Add(cos);
               cantidadDeCuentas++;
                retorno = true;
            }
            return retorno ;
        }
         */

        public static ParaisoFIscal operator -(ParaisoFIscal pf, CuentaOffShore cos)
        {
            ParaisoFIscal paraisoFIscal;
            bool retorno;

            if (pf == cos)//verfico si la cuenta esta contenida en paraiso
            {
                retorno = pf._listadoCuentas.Remove(cos);//saco cuenta de paraiso
                if (retorno == true)
                {
                    Console.WriteLine("la cuenta fue eliminada");
                    cantidadDeCuentas--;//decremento cantidad de cuentas 
                }
            }
            return pf;
        }
        /*
        public static ParaisoFIscal operator +(ParaisoFIscal pf, CuentaOffShore cos)
        {
            int i;
           // bool retorno = false;
            if (pf == cos)//pregunto si la cuenta esta contenida en pf
            {
                   
                i = pf._listadoCuentas.IndexOf(cos);//obtengo indice de la list donde se encuentra la cuenta
                pf._listadoCuentas[i].Saldo = pf._listadoCuentas[i].Saldo + cos.Saldo;//sumo saldos             
                Console.WriteLine($"El cliente ya existe es:{cos._Dueño}, su nuevo saldo es: {pf._listadoCuentas[pf._listadoCuentas.IndexOf(cos)].Saldo}");
            }
            else
            {
                pf._listadoCuentas.Add(cos);
                cantidadDeCuentas++;
                Console.WriteLine($"La cuenta de: {cos._Dueño} fue agregada con exito");
                //  retorno = true;
            }
            return pf;
        }
        */
        public static ParaisoFIscal operator +(ParaisoFIscal pf, CuentaOffShore cos)
        {
            int i;
            // bool retorno = false;
            if (pf == cos)//pregunto si la cuenta esta contenida en pf
            {
                foreach (var item in pf._listadoCuentas)
                {
                    if (item == cos)
                    {
                        item.Saldo = item.Saldo + cos.Saldo;
                        Console.WriteLine($"El cliente ya existe es:{cos._Dueño}, su nuevo saldo es: {item.Saldo}");
                        break;
                    }
                }

                
                        
            }
            else
            {
                pf._listadoCuentas.Add(cos);
                cantidadDeCuentas++;
                Console.WriteLine($"La cuenta de: {cos._Dueño} fue agregada con exito");
                //  retorno = true;
            }
            return pf;
        }
        #endregion



    }
}
