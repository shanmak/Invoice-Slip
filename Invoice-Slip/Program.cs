using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Slip
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10, z = 0; string Contin = "";
            string[] Code = new string[x];
            int[] Qunty = new int[x];
            double[] Price = new double[x];
            double[] Total = new double[x];
            double[] Discount = new double[x];
            double GrossTotal = 0;
            double[] Net = new Double[x];
            int[] sno = new int[x];
            string mendis = "MEMBER DISCOUNT", Memnumber = "", Gst = "GST @ 7%", gross = "GROSSTOATL", PAY = "PLEASE PAY";
            double Memdis = 0;
            int next = 0;
            do
            {
                for (int i = 0; i <= z; i++)
                {
                    Console.Write("Enter Item Code:");
                    Code[i] = Console.ReadLine();
                    Code[i] = Code[i].ToUpper();

                    Console.Write("Enter Quntity:");
                    Qunty[i] = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Unit Price:");
                    Price[i] = Double.Parse(Console.ReadLine());

                    Console.Write("To enter more items press Y; to end press N:");
                    Contin = Console.ReadLine();

                    Console.WriteLine();
                    if (Contin == "y")
                    {
                        z++;
                    }

                }
            } while (Contin != "n");

            Console.Write("is this MidWeek? y or n:");
            string Midweek = Console.ReadLine();

            Console.Write("The shopper a loyalty member? y or n: ");
            string check = Console.ReadLine();

            if (check == "y")
            {
                Console.Write("Enter you member number:");
                Memnumber = Console.ReadLine();
                Memnumber = Memnumber.ToUpper();

            }

            int a;
            for (a = 0; a <= z; a++)
            {
                Total[a] = Qunty[a] * Price[a];
                //Console.WriteLine(Total[a]);
            }

            if (Midweek == "y")
            {
                Discount[1] = (Total[1] * 0.20);

            }


            for (int i = 0; i <= z; i++)
            {
                Net[i] = Total[i];
            }

            if (Midweek == "y")
            {
                Net[1] = Total[1] - Discount[1];
            }
            for (int i = 0; i <= z; i++)
            {
                GrossTotal = GrossTotal + Net[i];
            }
            if (check == "y")
            {
                Memdis =-(GrossTotal * 0.10);
            }
            double GST = GrossTotal * 0.07;

            double pay = GrossTotal + GST + Memdis;

            for (int i = 0; i <= z; i++)
            {

                sno[i] = 1 + next;
                next = next + 1;
            }

            string com = "ABC COMPANY", add = "SINGAPORE", s = "INVOICE SLIP", sn = "S.NO", item = "ITEM CODE", qunt = "QUNTY", pri = "PRICE", cost = "COST", dis = "DISCOUNT", net = "NET";
            Console.WriteLine(string.Format("{0,40}", com));
            Console.WriteLine(string.Format("{0,38}", add));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(string.Format("{0,36}", s));
            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.WriteLine(string.Format("{0,-10}{1,10}{2,12}{3,12}{4,10}{5,13}{6,10}", sn, item, qunt, pri, cost, dis, net));
            Console.WriteLine();
            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int i = 0; i <= z; i++) {
                Console.WriteLine(string.Format("{0,-10}{1,10}{2,12}{3,12}{4,10}{5,13}{6,10}", sno[i], Code[i], Qunty[i], Price[i], Total[i], -Discount[i], Net[i]));
            }

            for (int i = 0; i < 80; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            
            string GT = GrossTotal.ToString().PadLeft(64, ' ');
            string MD = Memdis.ToString().PadLeft(55, ' ');
            string TAX = GST.ToString().PadLeft(64, ' ');
            string MONEY = pay.ToString().PadLeft(64, ' ');


            Console.WriteLine(string.Format("{0,-10}   {1:0.00}", gross, GT));
            Console.WriteLine(string.Format("{0,-10} {1}  {2:0.00}", mendis,Memnumber, MD));
            Console.WriteLine(string.Format("{0,-10}   {1:0.00}", Gst, TAX));
            Console.WriteLine(string.Format("{0,-10}   {1:0.00}", PAY, MONEY));

        }


    }
}
