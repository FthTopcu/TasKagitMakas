using System;

namespace TasKagitMakas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameLoop = true;
            int kulPuan = 0;
            int pcPuan = 0;
            while (gameLoop)
            {
                Console.WriteLine("Lütfen seçiminizi giriniz:");

                Console.WriteLine("1.Taş");
                Console.WriteLine("2.Kağıt");
                Console.WriteLine("3.Makas");
                string kulSecim = Console.ReadLine();

                Random rnd = new Random();
                int pcSecim = rnd.Next(1, 4);

                switch (pcSecim)
                {
                    //c taş seçti.
                    case 1:
                        if (kulSecim == "1")
                        {
                            //Beraberlik
                            Console.WriteLine("Kullanıcı taş seçti");
                            Console.WriteLine("Pc taş seçti");
                            Console.WriteLine("Beraberlik.");
                        }
                        else if (kulSecim == "2")
                        {
                            Console.WriteLine("Kullanıcı kağıt seçti");
                            Console.WriteLine("Pc taş seçti");
                            Console.WriteLine("Kullanıcı kazandı.");
                            kulPuan++;
                        }
                        else if (kulSecim == "3")
                        {
                            Console.WriteLine("Kullanıcı makas seçti");
                            Console.WriteLine("Pc taş setçi");
                            Console.WriteLine("Pc kazandı");
                            pcPuan++;
                        }
                        break;
                    //Pc kağıt seçti.
                    case 2:
                        if (kulSecim == "1")
                        {

                            Console.WriteLine("Kullanıcı taş seçti");
                            Console.WriteLine("Pc kağıt seçti");
                            Console.WriteLine("Pc kazandı");
                            pcPuan++;
                            
                        }

                        else if (kulSecim == "2")
                        {
                            //Beraberlik
                            Console.WriteLine("Kullanıcı kağıt seçti");
                            Console.WriteLine("Pc kağıt seçti");
                            Console.WriteLine("this is a tie");
                        }
                        else if (kulSecim == "3")
                        {
                            Console.WriteLine("Kullanıcı makas seçti");
                            Console.WriteLine("Pc kağıt seçti");
                            Console.WriteLine("Kullanıcı kazandı.");
                            kulPuan++;

                        }
                        break;
                    //Pc makas seçti
                    case 3:
                        if (kulSecim == "1")
                        {
                            Console.WriteLine("Kullanıcı taş seçti");
                            Console.WriteLine("Pc makas seçti");
                            Console.WriteLine("Kullanıcı kazandı.");
                            kulPuan++;
                        }

                        else if (kulSecim == "2")
                        {
                            Console.WriteLine("Kullanıcı kağıt seçti");
                            Console.WriteLine("Pc makas seçti");
                            Console.WriteLine("Pc kazandı");
                            pcPuan++;
                        }
                        else if (kulSecim == "3")
                        {
                            //Beraberlik
                            Console.WriteLine("Kullanıcı makas seçti");
                            Console.WriteLine("Pc makas seçti");
                            Console.WriteLine("Beraberlik");
                        }
                        break;
                       
                }
                Console.WriteLine();
                Console.WriteLine("Tekrar oynamak ister misiniz?");
                Console.WriteLine("E/H");
                string playAgain = Console.ReadLine();
                if (playAgain == "H" || playAgain == "h" || playAgain == "hayır")
                {
                    gameLoop = false;
                    Console.WriteLine($"Kullanıcı {kulPuan} puana sahip - Pc {pcPuan} puana sahip");
                }
                Console.WriteLine();
            }
        }
    }
}
