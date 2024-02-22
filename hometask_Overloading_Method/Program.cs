namespace hometask_Overloading_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //Cem hesablama

            //Console.WriteLine("cem hesbala " + CemHesabla(1, 2, 3));

            //Fesil

            //int ay = 2;
            //Console.WriteLine($"{ay}-ci ay {FesilTapma(ay)}  Fesilne mexsusdur");

            //int eded = 231; 
            //Console.WriteLine($"{eded} Eded: {ReqemlerinHasili(eded)}");




            Console.Write("1 ci məhsulun qiymetini daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 ci məhsulun qiymetini daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 cu mehsulun qiymetini daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int toplamQiymet = a + b + c - EnUcuzQiymet(a, b, c);

            Console.WriteLine("Odemeli oldugnuz toplam qiymet: " + toplamQiymet + " manat");


        }

        #region task1 CemHesablama
        //   static int CemHesabla(int eded1, int eded2, int eden3){



        //       int cem = 0;
        //       int[] ededler = {eded1, eded2, eden3};
        //       foreach(int eded in ededler) {
        //           if (eded<= 10 && eded <= 100)
        //           {
        //               cem += eded;
        //           }


        //       }


        //       return cem;
        //}
        #endregion

        #region task2 Fesil
        //static string FesilTapma(int ay)
        //{
        //    switch (ay)
        //    {
        //        case 12:
        //        case 1:
        //        case 2:
        //            return "Qish";


        //        case 3:
        //        case 4:
        //        case 5:
        //            return "Yaz";

        //        case 6:
        //        case 7:
        //        case 8:
        //            return "Yay";

        //        case 9:
        //        case 10:
        //        case 11:
        //            return "Payiz";

        //        default:
        //            return "Duzgun Ayi daxil edin";

        //    }
        //}



        #endregion

        #region task3 231

        //static int ReqemlerinHasili(int eded)
        //{
        //    int hasil = 1;

        //    while (eded!= 0)
        //    {
        //        int reqem = eded % 10;
        //        hasil *= reqem;
        //        eded /= 10;
        //    }

        //    return hasil;
        //}


        #endregion


        #region task4


        static int EnUcuzQiymet(params int[] qiymetler)
        {
            int enUcuz = qiymetler[0]; 

            foreach (int qiymet in qiymetler)
            {
                if (qiymet < enUcuz)
                {
                    enUcuz = qiymet;
                }
            }

            return enUcuz;
        }

        #endregion

    }
}
