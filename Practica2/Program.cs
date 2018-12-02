using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiploDe3();
            AntiguedadDelOperario();
            TiposDeNumeros();
        }

        /// <summary>
        /// este metodo se encarga de mostrar un programa que lea los datos de las cuentas corrientes e informe
        /// </summary>
        public static void CuentasDeBanco()
        {
            Console.Write("Ingrese la cantidad de cuentas corrientes a almacenar: ");
            int cant = Convert.ToInt32(Console.ReadLine()), num=0, cantAcr = 0;
            long[] cuentasList = new long[cant];
            long[] saldosList = new long[cant];
            
            while (num <= cant)
            {
                Console.Write("Ingrese cuenta: ");
                cuentasList[num] = Convert.ToInt64(Console.ReadLine());

                Console.Write("Ingrese saldo: ");
                saldosList[num] = Convert.ToInt64(Console.ReadLine());

                num++;
            }

            num = 0;

            while (num <= cant)
            {
                if (saldosList[num] > 0) { Console.WriteLine("La cuenta '{0}' tiene un saldo de '{1}' por ende es un 'Acreedor'.", cuentasList[num], saldosList[num]); cantAcr++; }
                if (saldosList[num] < 0) Console.WriteLine("La cuenta '{0}' tiene un saldo de '{1}' por ende es un 'Deudor'.", cuentasList[num], saldosList[num]);
                if (saldosList[num] == 0) Console.WriteLine("La cuenta '{0}' tiene un saldo de '{1}' por ende es un 'Nulo'.", cuentasList[num], saldosList[num]);
                num++;
            }

            Console.WriteLine("Cantidad total de Acreedores de " + cantAcr);
        }

        /// <summary>
        /// este metodo se encarga de mostrar los tipos de numeros
        /// </summary>
        public static void TiposDeNumeros()
        {
            Console.WriteLine("===> TIPOS DE NUMEROS <===");
            Console.Write("Ingrese la cantidad de numeros que desea verificar: ");
            
            int cantidad = Convert.ToInt32(Console.ReadLine()), num = 1, cantPos = 0, cantNeg = 0, cantPar = 0, cantImp = 0;

            while (num <= cantidad)
            {
                if (num > 0) cantPos++;
                if (num < 0) cantNeg++;
                if (num % 2 == 0) cantPar++;
                if (num % 2 > 0) cantImp++;
                num++;
            }

            Console.WriteLine("Numeros Positivos : [" + cantPos + "]");
            Console.WriteLine("Numeros Negativos : [" + cantNeg + "]");
            Console.WriteLine("Numeros Pares : [" + cantPar + "]");
            Console.WriteLine("Numeros Impares : [" + cantImp + "]");
            Console.ReadKey();
        }

        /// <summary>
        /// este metodo se encarga de mostrar la antiguedad de un operario
        /// </summary>
        public static void AntiguedadDelOperario()
        {
            Console.WriteLine("===> ANTIGUEDAD DE OPERARIO <===");
            Console.Write("Ingrese su sueldo: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese los años de antiguedad: ");
            int antiguedad = Convert.ToInt32(Console.ReadLine());
            if(sueldo < 500 && antiguedad >= 10)
            {
                sueldo *= 1.20;
                Console.WriteLine("Su sueldo es de {0}", sueldo);
            }
            else if (sueldo < 500 && antiguedad < 10)
            {
                sueldo *= 1.05;
                Console.WriteLine("Su sueldo es de {0}", sueldo);
            }
            else
            {
                Console.WriteLine("Su sueldo es de {0}", sueldo);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// este metodo se encarga de mostrar los numeros multiplos de 3 hasta el 200
        /// </summary>
        public static void MultiploDe3()
        {
            Console.WriteLine("===> MULTIPLO DE 3 <===");

            int numero = 3;

            while (numero <= 200)
            {
                if (numero % 3 == 0)
                    Console.WriteLine(numero);
                numero++;
            }

            Console.ReadKey();
        }
    }
}
