using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Cliente
    {
        public string Nombre { get; set; }
        public int CUIT { get; set; }
        public int Saldo { get; set; }
        public static Cliente operator -(Cliente cliente1,Cliente cliente2)
        {
            if(cliente1.CUIT==cliente2.CUIT)
            {
                Cliente nuevo = new Cliente();
                nuevo.Saldo = cliente1.Saldo - cliente2.Saldo;
                return nuevo;
            }
            else
            {
                Cliente otroCliente = new Cliente();
                if (cliente1.Saldo<cliente2.Saldo)
                {
                    otroCliente.Saldo = cliente1.Saldo;
                    return otroCliente;
                }
                else
                {
                    otroCliente.Saldo = cliente2.Saldo;
                    return otroCliente;
                }
            }
        }
    }

}