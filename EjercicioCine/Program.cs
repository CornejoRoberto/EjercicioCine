using System;
using System.Collections.Generic;

namespace EjercicioCine
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int num1=0; int num2 = 15;
            Peliculas peli = new Peliculas();
            peli.Nombre = "John Wick 3";
            peli.Anio = 2;
            peli.Duracion = 131;
            Peliculas peli2 = new Peliculas();
            peli2.Nombre = "Spiderman 3";
            peli2.Anio = 1;
            peli2.Duracion = 167;
            Peliculas peli3 = new Peliculas();
            peli3.Nombre = "Pikachu";
            peli3.Anio = 3;
            peli3.Duracion=120;
            Peliculas peli4 = new Peliculas();
            peli4.Nombre = "Avengers";
            peli4.Anio = 4;
            peli4.Duracion = 143;
            Peliculas peli5 = new Peliculas();
            peli5.Nombre = "Aladin";
            peli5.Anio = 5;
            peli5.Duracion = 90;
            List<Peliculas> Listacartelera = new List<Peliculas>();
            Listacartelera.Add(peli);
            Listacartelera.Add(peli2);
            Listacartelera.Add(peli3);
            Listacartelera.Add(peli4);
            Listacartelera.Add(peli5);

            Console.WriteLine("La lista de peliculas disponibles es:");
            foreach (Peliculas item in Listacartelera)
            {
                Console.WriteLine(item.Nombre + "\n" + "Disponible en la sala #"+item.Anio+"\n"+"Con una duracion de: "+item.Duracion+" minutos");
            }
            //CREAMOS UN IF PARA ESCOJER LA SALA Y LA PELICULA SELECCIONADA
            Console.WriteLine("Seleccione el número de la sala en la que desea ver su pelicula:");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("SU SALA ESCOGIDA FUE LA SALA 1:");
                Console.WriteLine("CON LA PELICULA DE JHON WICK 3");
                Console.WriteLine("ESCOJA SU ASIENTO");
                while (num2 >= 2)
                {
                    num2--;
                Console.WriteLine("Asiento Disponible #"+num2);     
                }
                //LLAMAMOS AL METODO ASIENTOS PARA ESCOJER NUESTRO NÚMERO DE ASIENTO
                Asientos sala = new Asientos();
                sala.NumAsiento = 3;
                Console.WriteLine("Su asiento escogido fue el asiento:"+sala.NumAsiento+"\n"+ "En la sala #1");
            }

            else if (num1 == 2)
            {
                Console.WriteLine("SU SALA ESCOGIDA FUE LA SALA 2:");
                Console.WriteLine("Con la pelicula de Spiderman 3");
                Console.WriteLine("ESCOJA SU ASIENTO");
                while (num2 >= 2)
                {
                    num2--;
                    Console.WriteLine("Asiento Disponible #" + num2);
                    
                }
                //lLAMAMOS AL METODO ASIENTOS PARA ESCOJER NUESTRO NÚMERO DE ASIENTO
                Asientos sala = new Asientos();
                sala.NumAsiento = 2;
                Console.WriteLine("Su asiento escogido fue el asiento:" + sala.NumAsiento + "\n" + "En la sala #2");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("SU SALA ESCOGIDA FUE LA SALA 3:");
                Console.WriteLine("Con la pelicula de Pikachu");
                Console.WriteLine("ESCOJA SU ASIENTO");
                while (num2 >= 2)
                {
                    num2--;
                    Console.WriteLine("Asiento Disponible #" + num2);

                }
                //lLAMAMOS AL METODO ASIENTOS PARA ESCOJER NUESTRO NÚMERO DE ASIENTO
                Asientos sala = new Asientos();
                sala.NumAsiento = 12;
                Console.WriteLine("Su asiento escogido fue el asiento:" + sala.NumAsiento + "\n" + "En la sala #3");
            }
            else if (num1 == 4)
            {
                Console.WriteLine("SU SALA ESCOGIDA FUE LA SALA 4:");
                Console.WriteLine("Con la pelicula de Avengers");
                Console.WriteLine("ESCOJA SU ASIENTO");
                while (num2 >= 2)
                {
                    num2--;
                    Console.WriteLine("Asiento Disponible #" + num2);

                }
                //lLAMAMOS AL METODO ASIENTOS PARA ESCOJER NUESTRO NÚMERO DE ASIENTO
                Asientos sala = new Asientos();
                sala.NumAsiento = 11;
                Console.WriteLine("Su asiento escogido fue el asiento:" + sala.NumAsiento + "\n" + "En la sala #4");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("SU SALA ESCOGIDA FUE LA SALA 5:");
                Console.WriteLine("Con la pelicula de Aladin");
                Console.WriteLine("ESCOJA SU ASIENTO");
                while (num2 >= 2)
                {
                    num2--;
                    Console.WriteLine("Asiento Disponible #" + num2);

                }
                //lLAMAMOS AL METODO ASIENTOS PARA ESCOJER NUESTRO NÚMERO DE ASIENTO
                Asientos sala = new Asientos();
                sala.NumAsiento = 7;
                Console.WriteLine("Su asiento escogido fue el asiento:" + sala.NumAsiento + "\n" + "En la sala #5");
            }


            //Se muestra la cantidad de productos incluidos de manera gratuita por el cine
            Bar bar = new Bar();
                Console.WriteLine("Los aperitivos gratuitos que inclueyen la entrada son: " + bar.ProductosIncluidos());
            //Se selecciona el producto a comprar por el cliente
                Bar barproducto = new Bar();
                barproducto.Producto = "Tacos";
                Console.WriteLine("Su aperitivo escogido a comprar fue: " + barproducto.Producto);
                String Nombre;
                Console.WriteLine("Ingrese su nombre para finalizar el proceso:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Se ha finalizado el proceso a nombre de: " + Nombre); 
            }

        }

    }

