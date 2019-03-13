using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Count() < 2)
                {
                    throw new Exception("Provide valid inputs.");
                }

                string result = FileInformation.GetFileDetails(args[0], args[1]);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
            }
        }
    }
}
