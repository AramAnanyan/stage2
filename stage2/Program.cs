using System;

namespace stage2
{
    class Program
    {
        static void Main(string[] args)
        {
            pizza vegeteriano = new pizza();
            vegeteriano.caloria = 266;
            vegeteriano.date = DateTime.Now;
            vegeteriano.isdiet = true;
            vegeteriano.price = 3000;
            vegeteriano.size = "big";

            pizza margarita = new pizza();
            margarita.caloria = 300;
            margarita.date = DateTime.Now;
            margarita.isdiet = false;
            margarita.price = 2500;
            margarita.size = "big";


            shaurma myshaurma1 = new shaurma();
            myshaurma1.caloria = 280;
            myshaurma1.date = DateTime.Now;
            myshaurma1.isdiet = false;
            myshaurma1.price = 1000;
            myshaurma1.size = "big";

            shaurma myshaurma2 = new shaurma();
            myshaurma2.caloria = 260;
            myshaurma2.date = DateTime.Now;
            myshaurma2.isdiet = false;
            myshaurma2.price = 800;
            myshaurma2.size = "small";


            burger myburger1 = new burger();
            myburger1.caloria = 220;
            myburger1.date = DateTime.Now;
            myburger1.isdiet = false;
            myburger1.price = 1500;
            myburger1.size = "big";

            burger myburger2 = new burger();
            myshaurma1.caloria = 200;
            myshaurma1.date = DateTime.Now;
            myshaurma1.isdiet = false;
            myshaurma1.price = 1000;
            myshaurma1.size = "small";
        }
    }
}
