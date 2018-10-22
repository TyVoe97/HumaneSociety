using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    //class Program
    //{
    //    static void Main(string[] args)
        //{
        //    PointOfEntry.Run();
        //}

        public class General
        {
            public List<string> loadCsvFile(string filePath)
            {
                var reader = new StreamReader(File.OpenRead(filePath));
                List<string> searchList = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    searchList.Add(line);
                }
                return searchList;
            }
        }
    }




