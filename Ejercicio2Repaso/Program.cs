namespace Ejercicio2Repaso
{


    class Program
    {


        static void Main(string[] args) {

            Console.WriteLine("Dame un número de 2 cifras");
            int num = Convert.ToInt32(Console.ReadLine());
            int numAux;
            if (num > 9 & num < 100)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("El número introducido es: " + num);
                
            }
            else
            {
                Console.WriteLine("El número introducido no es de 2 cifras");
            }
            List<int> listaNum = new List<int>();
            for (int i = 401; i < 700; i++){ 
            
                if(i % num == 0)
                {
                    
                    Console.WriteLine(i);
                    numAux = i;

                   

                    /*for(i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine(numeros[i]);
                        Console.WriteLine(i);
                    }*/
                    listaNum.Add(i);
                    
                  
                }
                
            }
            foreach (int i in listaNum)
            {
                Console.WriteLine(i + i);
            }

         

        
        
        }




    }





}

