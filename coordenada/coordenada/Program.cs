using System;
using System.IO;
namespace coordenada
{
    public class coordenada {

        int x ,y;
        public coordenada(){
            string numPun;
            Console.WriteLine("cantidad de puntos a crear");
            numPun = Console.ReadLine();
            int puntos = int.Parse(numPun);
            
            for(int i = puntos;i < 0;i --){

                coordenada[] lista = new coordenada[puntos];
               
                


            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (string line in File.ReadLines(@"C:\Users\user\Desktop\Kevin\SII\appcomr\database\usuarios\kevincastillo21@gmail.com\kevincastillo21@gmail.com.txt"))
            {
            if (line.Contains("Meteoro7"))
                {
                    Console.WriteLine(line);
                }
            }

        }

        
    }
    
            

        


}
    
        
    

