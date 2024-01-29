using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUnidad3.Modelo;

namespace AppUnidad3.Services
{
    public class ClienteService
    {
        public static List<Cliente> listaCliente = new List<Cliente>();
        
        public static List<Cliente> GetListaCliente() { return listaCliente; }
        
        public static Cliente GetCliente(int? id)
        { 
            Cliente cliente = null;

            foreach (var cli in GetListaCliente()) 
            {
                if (cli.ID == id)
                {
                    cliente = cli;
                }
            }

            return cliente;
        }
    }
}
