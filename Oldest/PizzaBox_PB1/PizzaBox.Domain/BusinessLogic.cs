using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class BusinessLogic
    {
        public static int GlobalId;
        public static string SelectSize(int usersize)
        {
            string sizesels = "Small";

            if (usersize == 1)
            {
                sizesels = "Small";
            }
            else if (usersize == 2)
            {
                sizesels = "Medium";
            }
            else if (usersize == 3)
            {
                sizesels = "Large";
            }
            else
            {
                Console.WriteLine("Error");
            }
            return sizesels;
        }
        public static int SizeCost(string sizesels)
        {
            int costofsels = 0;
            if (sizesels == "Small")
            {
                costofsels = 6;
            }
            else if (sizesels == "Medium")
            {
                costofsels = 12;
            }
            else if (sizesels == "Large")
            {
                costofsels = 20;
            }
            else
            {
                Console.WriteLine("Error");
            }
            return costofsels;
        }
        public static string SelectCrust(int usersizec)
        {
            string sizeselc = "Thin";

            if (usersizec == 1)
            {
                sizeselc = "Thin";
            }
            else if (usersizec == 2)
            {
                sizeselc = "Flat";
            }
            else if (usersizec == 3)
            {
                sizeselc = "Thick";
            }
            else
            {
                Console.WriteLine("Error");
            }
            return sizeselc;
        }
        public static int CrustCost(string crustselc)
        {
            int costofselc = 0;
            if (crustselc == "Thin")
            {
                costofselc = 6;
            }
            else if (crustselc == "Flat")
            {
                costofselc = 12;
            }
            else if (crustselc == "Thick")
            {
                costofselc = 20;
            }
            else
            {
                Console.WriteLine("Error");
            }
            return costofselc;
        }
        public static int totalordercost(int a, int b)
        {
            return a + b;
        }
    }
}
