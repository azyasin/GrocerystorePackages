using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* XR Element
 * Online Grocery Store Packages Calculator
 * Author: A. Yasin
 * 10 Jun 2019
* /


/* This program will find the least number of packs given 
 * a quantity and a predefined array of available package 
 * sizes
*/

using System;
using System.Collections.Generic;
namespace GroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            SlicedHam(10);
            Yougurt(28);
            ToiletRolls(12);

            Console.WriteLine("Enter Sliced Ham Order Quantity. (available pack sizes: 3, 5):");
            int SHquantity = Convert.ToInt32(Console.ReadLine());
            SlicedHam(SHquantity);

            Console.WriteLine("Enter Yoghurt Order Quantity. (available pack sizes: 4, 10, 15):");
            int Ygquantity = Convert.ToInt32(Console.ReadLine());
            Yougurt(Ygquantity);

            Console.WriteLine("Enter Toilet Rolls Order Quantity. (available pack sizes: 3, 5, 9):");
            int TRquantity = Convert.ToInt32(Console.ReadLine());
            ToiletRolls(TRquantity);

            Console.ReadKey();

        }


        private static void SlicedHam(int quantity)
        {
            int[] packs = { 5, 3 };
            float[] packPrice = { 4.49f, 2.99f };
            int p5SH, p3SH;
            bool found = false; //boolean used to determine if no packages can be created for a given quantity 
            int[] CurrentTotalPacks = { quantity / packs[0], quantity / packs[1] };

            for (int i = (int)quantity / packs[0]; i > -1; i--)
            {
                for (int j = (int)quantity / packs[1]; j >= 0; j--)
                {

                    if (i * packs[0] + j * packs[1] == quantity)
                    {
                        found = true;
                        {
                            p5SH = i;
                            p3SH = j;

                            //check if this iteration holds the minimum number of total packs
                            if (i + j < CurrentTotalPacks[0] + CurrentTotalPacks[1])
                            {
                                CurrentTotalPacks[0] = i;
                                CurrentTotalPacks[1] = j;
                            }
                        }
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("The entered quantity should be a multiple or a sum of multiples of " + packs[0] + ", " + packs[1] + "\n");
            }
            else
            {
                Console.WriteLine("SH Order = " + quantity + "\t packs(" + packs[0] + ")= " + CurrentTotalPacks[0] +
                            ",  packs(" + packs[1] + ")= " + CurrentTotalPacks[1] +
                            " \t Total packs: " + (CurrentTotalPacks[0] + CurrentTotalPacks[1] +
                            " Total " +
                            quantity + ", \t TR $" + String.Format("{0:0.00}", (CurrentTotalPacks[0] * packPrice[0] + CurrentTotalPacks[1] * packPrice[1])) +
                            "\n=============== \nPrice breakdown" + "\n===============" +
                            "\n" + " " + CurrentTotalPacks[0] + " x $" + packPrice[0] +
                            "\n" + " " + CurrentTotalPacks[1] + " x $" + packPrice[1] + "\n"
                            ));
            }
        }



        private static void Yougurt(int quantity)
        {
            int[] packs = { 15, 10, 4 };
            float[] packPrice = { 13.95f, 9.95f, 4.95f };
            int p15Yg, p10Yg, p04Yg;
            bool found = false;
            int[] CurrentTotalPacks = { quantity / packs[0], quantity / packs[1], quantity / packs[2] };

            for (int i = (int)quantity / packs[0]; i > -1; i--)
            {
                for (int j = (int)quantity / packs[1]; j >= 0; j--)
                {
                    for (int k = (int)quantity / packs[2]; k >= 0; k--)
                    {
                        if (i * packs[0] + j * packs[1] + k * packs[2] == quantity)
                        {
                            found = true;
                            {
                                p15Yg = i;
                                p10Yg = j;
                                p04Yg = k;
                                //check if this iteration holds the minimum number of total packs
                                if (i + j + k < CurrentTotalPacks[0] + CurrentTotalPacks[1] + CurrentTotalPacks[2])
                                {
                                    CurrentTotalPacks[0] = i;
                                    CurrentTotalPacks[1] = j;
                                    CurrentTotalPacks[2] = k;
                                }
                            }
                            break;
                        }
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("The entered quantity should be a multiple or a sum of multiples of " + packs[0] + ", " + packs[1] + ", " + packs[2] + "\n");
            }
            else
            {
                Console.WriteLine("YG Order = " + quantity + "\t packs(" + packs[0] + ")= " + CurrentTotalPacks[0] +
                                            ",  packs(" + packs[1] + ")= " + CurrentTotalPacks[1] +
                                            ",  packs(" + packs[2] + ")= " + CurrentTotalPacks[2] +
                                            " \t Total packs: " + (CurrentTotalPacks[0] + CurrentTotalPacks[1] + CurrentTotalPacks[2]) +
                                            " Total " +
                                            quantity + ", \t TR $" + String.Format("{0:0.00}", (CurrentTotalPacks[0] * packPrice[0] + CurrentTotalPacks[1] * packPrice[1] + CurrentTotalPacks[2] * packPrice[2])) +
                                            "\n=============== \nPrice breakdown" + "\n===============" +
                                            "\n" + " " + CurrentTotalPacks[0] + " x $" + packPrice[0] +
                                            "\n" + " " + CurrentTotalPacks[1] + " x $" + packPrice[1] +
                                            "\n" + " " + CurrentTotalPacks[2] + " x $" + packPrice[2] + "\n"
                                            );
            }
        }


        private static void ToiletRolls(int quantity)
        {
            int[] packs = { 9, 5, 3 };
            float[] packPrice = { 7.99f, 4.45f, 2.95f };
            int p9TR, p5TR, p3TR;
            bool found = false;
            int[] CurrentTotalPacks = { quantity / packs[0], quantity / packs[1], quantity / packs[2] };

            for (int i = (int)quantity / packs[0]; i > -1; i--)
            {
                for (int j = (int)quantity / packs[1]; j >= 0; j--)
                {
                    for (int k = (int)quantity / packs[2]; k >= 0; k--)
                    {
                        if (i * packs[0] + j * packs[1] + k * packs[2] == quantity)
                        {
                            found = true;
                            {
                                p9TR = i;
                                p5TR = j;
                                p3TR = k;
                                //check if this iteration holds the minimum number of total packs
                                if (i + j + k < CurrentTotalPacks[0] + CurrentTotalPacks[1] + CurrentTotalPacks[2])
                                {
                                    CurrentTotalPacks[0] = i;
                                    CurrentTotalPacks[1] = j;
                                    CurrentTotalPacks[1] = j;
                                    CurrentTotalPacks[2] = k;
                                }
                            }
                            break;
                        }
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("The entered quantity should be a multiple or a sum of multiples of " + packs[0] + ", " + packs[1] + ", " + packs[2] + "\n");
            }
            else
            {
                Console.WriteLine("TR Order = " + quantity + "\t packs(" + packs[0] + ")= " + CurrentTotalPacks[0] +
                                            ",  packs(" + packs[1] + ")= " + CurrentTotalPacks[1] +
                                            ",  packs(" + packs[2] + ")= " + CurrentTotalPacks[2] +
                                            " \t Total packs: " + (CurrentTotalPacks[0] + CurrentTotalPacks[1] + CurrentTotalPacks[2]) +
                                            " Total " +
                                            quantity + ", \t TR $" + String.Format("{0:0.00}", (CurrentTotalPacks[0] * packPrice[0] + CurrentTotalPacks[1] * packPrice[1] + CurrentTotalPacks[2] * packPrice[2])) +
                                            "\n=============== \nPrice breakdown" + "\n===============" +
                                            "\n" + " " + CurrentTotalPacks[0] + " x $" + packPrice[0] +
                                            "\n" + " " + CurrentTotalPacks[1] + " x $" + packPrice[1] +
                                            "\n" + " " + CurrentTotalPacks[2] + " x $" + packPrice[2] + "\n"
                                            );
            }
        }
    }
}