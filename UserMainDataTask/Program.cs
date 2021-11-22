using System;

namespace UserMainDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutala sisestada eesnime
            //programm kusib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnime:");
            string userName = Console.ReadLine();
            Console.WriteLine("Vali number (sisesta '1', '2' või '3')");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if(userNumber == 1)
            {
                GetUserNameData(userName);
            }
            else if(userNumber == 2)
            {
                S
            }
            


        }

        public static void GetUserNameData(string userInput)
        {

                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    Console.Write(userInput[i]);
                    
                }
          
        }

            



        }
    }  

