using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using tareatotal.services;

namespace tareatotal.Clases
{
    public class Nombres
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        int resp;


        //-------------------------------------------------------
        //Productos



        public void Menu()
        {
            productos Final = new productos();
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine(" Bienvenido a la tienda en linea mixup");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("usted necesita registrase; ¿cual es su nombre?");
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Ahora necesito su numero de teléfono; ingreselo");
            Telefono = int.Parse(Console.ReadLine());  
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("por ultimo necesario su correo electrónico");
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");

            Console.Clear();





        }
        
        public double acceder()
        {
            double resultado = 0;
            do
            {
                Producto productoss = new Producto(); 
                Console.WriteLine(" tenemos estos productos:");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" (1) playstation 5= 15000 pesos");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" (2)Xiaomi redmi note 11= 6000");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" (3) xbox one= 6000");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" (4) smartwatch= 4000");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" (5) lenovo = 12000");
                Console.WriteLine("----------------------------");
                int resp;
                string productos = Console.ReadLine();
                switch (productos)
                {
                    case "1":
                        resultado = resultado + cantidad(productoss.playstation_5);
                        Console.WriteLine("espere..........");
                        Console.WriteLine("¡se a agregado a su carrito exitosamente!");
                        Console.ReadKey();
                        break;

                    case "2":
                        resultado = resultado + cantidad(productoss.Xiaomi_redmi_note_11);
                        Console.WriteLine("espere..........");
                        Console.WriteLine("¡se a agregado a su carrito exitosamente!");
                        Console.ReadKey();

                        break;
                    case "3":
                        resultado = resultado + cantidad(productoss.xboxo_one);
                        Console.WriteLine("espere..........");
                        Console.WriteLine("¡se a agregado a su carrito exitosamente!");

                        Console.ReadKey();

                        break;
                    case "4":
                        resultado = resultado + cantidad(productoss.smartwatch);
                        Console.WriteLine("espere..........");
                        Console.WriteLine("¡se a agregado a su carrito exitosamente!");

                        Console.ReadKey();

                        break;
                    case "5":
                        resultado = resultado + cantidad(productoss.lenovo);
                        Console.WriteLine("espere..........");
                        Console.WriteLine("¡se a agregado a su carrito exitosamente!");
                        Console.ReadKey();

                        break;

                    default:

                        Console.WriteLine("no seleccionas el correcto");
                        break;



                }
                Console.WriteLine("quieres terminar de comprar presiona (1)no (2)si ");
                resp = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (resp == 1);
            resultado  = Descuento(resultado);
            return resultado;


        }

        public double cantidad(double factura)

        {
            Console.WriteLine("¿cuantos productos?");
            int a = int.Parse(Console.ReadLine());
            double compras = a + factura;
            return compras;
        }
        public double mes(double factura)
        {
            if (factura > 8000 && factura < 10000)
            {
                double meses = factura / 3;
                Console.WriteLine("ahora usted puede comprar 3 meses sin intereses a  " + meses + " por mes");
            }
            if (factura > 10000)
            {
                double meses1 = factura / 12;
                Console.WriteLine("ahora usted puede comprar 3 meses sin intereses a " + meses1+ " por mes");
            }
            return factura;
        }
        public double Descuento(double factura)
        {
            if (factura > 5000)
            {
                Console.WriteLine("Se aplicado un descuento del 10% por la compra mayor a 5,000");
                factura = factura - (factura * 0.1);
                mes(factura);
                return factura;
            }
            else
            {

                return factura;
            }
        }


    }

}
