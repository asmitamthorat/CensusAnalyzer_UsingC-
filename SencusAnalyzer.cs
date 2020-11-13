using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace SencusAnalyzerFinal
{
    class SencusAnalyzer
    {

        static private List<IndiaStateCode> indiaStateCodeCsvList = new List<IndiaStateCode>();
        public int LoadStateCodeData() {
            int count = 0;   
            using (var file = new StreamReader(@"C:\\Users\\com\\Desktop\\csv\\IndiaStateCode.csv"))
                {
                    indiaStateCodeCsvList = new CsvHelper.CsvReader(file, System.Globalization.CultureInfo.InvariantCulture).GetRecords<IndiaStateCode>().ToList();
                    foreach (var p in indiaStateCodeCsvList)
                    {
                       count = count + 1;
                        Console.WriteLine(p);
                    }
                    
                }

            return count;

         
           

           

        }
    }
}
