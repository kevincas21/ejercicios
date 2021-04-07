using System;

namespace banco
{
    public class persona {

        string nombre ;
        public string[] lapersona = new string[3];

        public persona (){

            
            
            for(byte i = 0; i < 3;i++){
                string nombre = Console.ReadLine();
                lapersona[i] = nombre;
                
            
            }

        }
        public void mostrar (){
            for(byte i = 0; i < 3;i++){
                

                Console.WriteLine ("el nombre de la persona es {0}",lapersona[i]);

            }
            
        }
        ~persona(){

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            persona p = new persona();
            p.mostrar();
            

            


            
        }
    }
}
