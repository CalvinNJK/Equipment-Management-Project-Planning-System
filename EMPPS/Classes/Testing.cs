using EMPPS.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EMPPS.Classes
{
    internal class Testing
    {
        // Variables 
        private string t_id;
        private string t_name;
        private string t_desc;
        private int[] t_eid;

        // Setter & Getter
        public string T_ID
        {
            get { return t_id; }
            set { t_id = value; }
        }
        public string T_Name
        {
            get { return t_name; }
            set { t_name = value; }
        }
        public string T_Desc
        {
            get { return t_desc; }
            set { t_desc = value; }
        }
        public int[] T_Eid
        {
            get { return t_eid; }
            set { t_eid = value; }
        }

        public Testing(string id, string name, string desc, int[] eid)
        {
            this.t_id = id;
            this.t_name = name;
            this.t_desc = desc;
            this.t_eid = eid;
        }

        
    }




    internal class FileHandlingForTesting
    {

        public static List<Testing> testingList = new List<Testing>();
        private static string testing_path = @"C:\EMPPS\testing.csv";


        // Initial Reading for TESTING.csv
        public static void ReadAllTesting()
        {
            try
            {
                using (StreamReader readerCategorytCSV = new StreamReader(testing_path))
                {
                    string headerLine = readerCategorytCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerCategorytCSV.ReadLine()) != null)
                    {
                        // Split all the column
                        string[] temp = line.Split(',');

                        // Split the EQUIPMENT ID into ARRAY
                        int[] eidArray = temp[3].Split('.').Select(int.Parse).ToArray();

                        testingList.Add(new Testing((temp[0]), temp[1], temp[2], eidArray));

                    }
                }

                // Testing Purpose - Check List input
                Console.WriteLine(" -------------------");
                Console.WriteLine("| Read TESTING.csv |");
                Console.WriteLine($"| Items: {testingList.Count,-10} |");
                Console.WriteLine(" -------------------");
                foreach (var item in testingList)
                {
                    Console.WriteLine(" Project ID : " + item.T_ID);
                    Console.WriteLine(" Name : " + item.T_Name);
                    Console.WriteLine(" Desc : " + item.T_Desc);

                    foreach (var item2 in item.T_Eid)
                    {
                        Console.WriteLine("    EID: " + item2);
                    }
                }
                Console.WriteLine("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        // Save CATEGORY to TESTING.csv
        public static void WriteAllTesting()
        {
            File.WriteAllText(testing_path, String.Empty);

            using (StreamWriter writerEquipmentCSV = new StreamWriter(testing_path))
            {
                Console.WriteLine(" -------------------");
                Console.WriteLine("| Write TESTING.csv |");
                Console.WriteLine(" -------------------");
                
                writerEquipmentCSV.WriteLine($"ID,NAME,DESCRIPTION,EQUIPMENT ID");   // Category Header Line
                
                
                foreach (var item in testingList)
                {
                    // Make the int array of eid back into one line of string, so can write into the file.
                    string[] eidArrayString = item.T_Eid.Select(x => x.ToString()).ToArray();    
                    string eid = string.Join(".", eidArrayString);

                    writerEquipmentCSV.WriteLine($"{item.T_ID},{item.T_Name},{item.T_Desc},{eid}");
                    Console.WriteLine($"{item.T_ID},{item.T_Name},{item.T_Desc},{eid}");
                }
                Console.WriteLine("");
            }
        }

    }
}
