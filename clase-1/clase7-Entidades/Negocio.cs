using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace clase7_Entidades
{
    public class Negocio
    {
       
        private  PuestoDeAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Clientes
        {
            set { Clientes = value; }
            get
            {
                Cliente buffer = null;
                if (clientes.Count > 0)
                {
                   buffer = clientes.Peek();////// c = clientes.Peek();
                }
                return buffer;
            }//retorno proximo cliente
        }


        private Negocio()
        {
           this.clientes = new Queue<Cliente>();
            this.caja =  new PuestoDeAtencion(EPuesto.Caja1);          
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;//retorno tamano de lqueque clientes
            }
        }
        public static bool operator ==(Negocio n, Cliente c)//verifico sie el cliente ya esta en la fila
        {
            bool retorno = false;

            foreach (Cliente item in n.clientes)//recorro lista en busca del cliente
            {
                if (Equals(item, c))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n != c)//verifico que el cliente no este en la fila
            {
                n.clientes.Enqueue(c);//agrego cliente a la lista
                retorno = true;
            }
          
            return retorno;

        }
        public static bool operator ~(Negocio n)
        {

            bool retorno = false;
            Cliente buffer = n.Clientes;

            if (n.ClientesPendientes >= 0)
            {
                retorno = n.caja.Atender(n.Clientes);//obtengo proximo cliente en cola
            }
            if (retorno)
            {             
                n.clientes.Dequeue();
            }

            return retorno;
        }
    }
}
