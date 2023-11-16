using EMPPS.Classes;
using EMPPS.Project_Planning;
using EMPPS.Equipment_Management;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPPS
{
    internal class FileHandling
    {
        // List Array (Globally used)
        public static List<Equipment> equipmentList = new List<Equipment>();
        public static List<Category> categoryList = new List<Category>();
        public static List<Project> ProjectList = new List<Project>();


        // Initial Reading for EQUIPMENT.csv
        public static void ReadAllEquipment()
        {

            string file_path = @"C:\EMPPS\equipment.csv";

            try
            {
                using (StreamReader readerEquipmentCSV = new StreamReader(file_path))
                {
                    string headerLine = readerEquipmentCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerEquipmentCSV.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');

                        equipmentList.Add(new Equipment(temp[0], temp[1], temp[2], Double.Parse(temp[3]), temp[4], Int32.Parse(temp[5])));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Initial Reading for CATEGORY.csv
        public static void ReadAllCategory()
        {

            string file_path = @"C:\EMPPS\Category.csv";

            try
            {
                using (StreamReader readerCategorytCSV = new StreamReader(file_path))
                {
                    string headerLine = readerCategorytCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerCategorytCSV.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');

                        categoryList.Add(new Category(Int32.Parse(temp[0]), temp[1]));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        // Initial Reading for PROJECT.csv
        public static void ReadAllProject()
        {
            // JIA WEN' CODES
        }


    }
}
