using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, string> stocks = new Dictionary<string, string> () { { "GM", "General Motors" }, { "GE", "General Electric" }, { "CAT", "Caterpillar" }, { "AAPL", "Apple" }, { "MSFT", "Microsoft" },
            };

            Dictionary<string, List<double>> purchases = new Dictionary<string, List<double>> ();

            // Create some purchases
            purchases.Add ("AAPL", new List<double> () { 2100.32, 5500.91 });
            purchases.Add ("MSFT", new List<double> () { 43908, 9823.21 });
            purchases.Add ("GE", new List<double> () { 3259.94, 3402.24 });
            purchases.Add ("GM", new List<double> () { 390.2, 385.90, 7845.23, 4598.29 });

            Dictionary<string, double> stockReport = new Dictionary<string, double> ();

            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */
            foreach (KeyValuePair<string, List<double>> position in purchases) {
                Console.WriteLine ($"The position in {position.Key} is worth {position.Value.Sum()}");
            }

        }

    }
}