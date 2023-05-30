using FundamentoCSHARP.Models;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace FundamentoCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            decimal numero = 189.1m;
            //var nombre = "Hector";
            var persona = new { nombre = "Carlitos", apellido = "Carlon" };
            Console.WriteLine(persona.nombre);

            OBJETOS Y CLASES

            Bebida bebida = new Bebida("Coca", 1000);
            bebida.Beberse(300);
            Console.WriteLine(bebida.Cantidad);

            Cerveza cerveza = new Cerveza();
            cerveza.Beberse(200);
            Console.WriteLine(cerveza);
            

            //ARRAYS Y LISTS


            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("iteracion:  " + i + " - " + numeros[i]);
            }

            foreach (var n in numeros)
            {

                Console.WriteLine(n);
            }
            //una cola es una fila, FIFO.
            //Pila LILO
            Console.WriteLine("**************");
            List<int> Listita = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            Listita.Add(9);
            Listita.Add(0);
            Listita.Remove(2);
            foreach (var n in Listita)
            {
                Console.WriteLine("elemento: " + n);
            }
            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(1000, "Andes Rubia") };
            cervezas.Add(new Cerveza(500));
            Cerveza Corona = new Cerveza(500, "Coronita");
            cervezas.Add(Corona);
            
            foreach(var cerveza in cervezas)
            {
                Console.WriteLine("cerveza: " + cerveza.Nombre + " de " + cerveza.Cantidad+"ml");
            }
            
            FIN LISTAS Y ARRAYS.
                

            //INTERFACES

            var bebidaAlcoholica = new Cerveza(60);
            //MostrarRecomendacion(bebidaAlcoholica);

            List<string> lista = new List<string>();
            //

            //    ADD DE CERVEZA A BDD

            CERVEZABD cervezaBD = new CERVEZABD();
            /*
            {
                //insertamos nueva cerveza
                Cerveza cerveza = new Cerveza(15, "Pale Ale");
                cerveza.Marca = "Minerva";
                cerveza.Alcohol = 6;

                cervezaBD.Add(cerveza);
            }
            

            {
                Cerveza cerveza = new Cerveza(5, "Ale");
                cerveza.Marca = "Guiness";
                cerveza.Alcohol = 9;
                cervezaBD.Edit(cerveza, 3);
            }
            
            //Delete
            {
                cervezaBD.Delete(3);
            }

            //obtener todas las cervezas
            var cervezas = cervezaBD.Get();


            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }



        }
        /*static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }*/

            // PARTE 7: SERIALIZACIÓN DE OBJTOS
            // Y DESERIEALIZACION DE JSON

            //Cerveza cerveza = new Cerveza(10, "Cerveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);
            //Ahora lo inverso: Deseriealización

            //string miJson = File.ReadAllText("objeto.txt");
            //Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);

            static async Task Main(string[] args)
            {
                string url = "https://jsonplaceholder.typicode.com/posts";

                HttpClient client = new HttpClient();

                var httpResponse = await client.GetAsync(url);

                //Console.WriteLine("Esperando el getasync");
                //await res;
                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    List<Models.Post> posts = 
                        JsonSerializer.Deserialize<List<Models.Post>>(content);
                }
            }
        }
    }

    
}