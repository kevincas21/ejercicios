using System;

namespace ejercisio
{
    public class cliente {
        string nombre;
        int monto;
        public cliente (string nomb,string mon){
            nombre = nomb;
            
            monto = int.Parse(mon);


        }
        public int depositar(int depo){
            monto = monto + depo;
            int depositoTo = 0;
            depositoTo = depositoTo + depo;
            return depositoTo;

        }
        public int retiro(int ret){

            monto = monto - ret;
            int retiTo = 0;
            retiTo = retiTo + ret;

            return retiTo;



        }
        public void mostrar(){
            Console.WriteLine("el monto es {0}", monto);

        }


        


    }

    public class banco {
        
        cliente[] elCliente = new cliente[3];

        public void añadirCL(){

            for (byte i = 0; i < 3;i++){
                string nombre = Console.ReadLine();
                string monto = Console.ReadLine();
                
                elCliente[i] = new cliente(nombre,monto);
                


            }
        }
            


    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
