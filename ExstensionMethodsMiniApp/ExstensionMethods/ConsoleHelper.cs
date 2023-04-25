using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt (this string message, int minvalue, int maxvalue)
        {
            return message.RequestInt(true,minvalue, maxvalue);
        }


        public static int RequestInt(this string message)
        {
          return message.RequestInt(false);
        }

        private static int RequestInt(this string message,bool usedMinMax,
                                        int minvalue = 0, int maxvalue = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (usedMinMax == true)
                {
                    if (output >= minvalue && output <= maxvalue )
                    {
                        isInValidRange = true;
                    }
                    else
                    {
                        isInValidRange = false;
                    }
                }
            }
            return output;
        }

    }
}
