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
        public static List<Project> projectList = new List<Project>();

        // File Paths
        private static string equipment_path = @"C:\EMPPS\equipment.csv";
        private static string category_path = @"C:\EMPPS\category.csv";
        private static string project_Path = @"C:\EMPPS\project.csv";


        // Initial Reading for EQUIPMENT.csv
        public static void ReadAllEquipment()
        {
            try
            {
                using (StreamReader readerEquipmentCSV = new StreamReader(equipment_path))
                {
                    string headerLine = readerEquipmentCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerEquipmentCSV.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');

                        equipmentList.Add(new Equipment(temp[0], temp[1], temp[2], Double.Parse(temp[3]), temp[4], Int32.Parse(temp[5])));
                    }
                }

                // Testing Purpose - Check List Input
                Console.WriteLine(" --------------------");
                Console.WriteLine("| Read EQUIPMENT.csv |");
                Console.WriteLine($"| Items: {equipmentList.Count,-11} |");
                Console.WriteLine(" --------------------");
                foreach (var item in FileHandling.equipmentList)
                {
                    Console.WriteLine($"{item.E_Id} {item.E_Name} {item.E_Desc} {item.E_Cost} {item.E_Category} {item.E_Status}");
                }
                Console.WriteLine("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Initial Reading for CATEGORY.csv
        public static void ReadAllCategory()
        {
            try
            {
                using (StreamReader readerCategorytCSV = new StreamReader(category_path))
                {
                    string headerLine = readerCategorytCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerCategorytCSV.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');

                        categoryList.Add(new Category(Int32.Parse(temp[0]), temp[1]));
                    }
                }

                // Testing Purpose - Check List input
                Console.WriteLine(" -------------------");
                Console.WriteLine("| Read Category.csv |");
                Console.WriteLine($"| Items: {categoryList.Count,-10} |");
                Console.WriteLine(" -------------------");
                foreach (var item in FileHandling.categoryList)
                {
                    Console.WriteLine($"{item.C_Index} {item.C_Name} ");
                }
                Console.WriteLine("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        // Initial Reading for PROJECT.csv
        public static void ReadAllProject()
        {
            try
            {
                using (StreamReader readerProjectCSV = new StreamReader(project_Path))
                {
                    string headerLine = readerProjectCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerProjectCSV.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');

                        projectList.Add(new Project(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]));
                    }
                }

                // Testing Purpose - Check List input
                Console.WriteLine(" -------------------");
                Console.WriteLine("| Read Project.csv |");
                Console.WriteLine($"| Items: {projectList.Count,-10} |");
                Console.WriteLine(" -------------------");
                foreach (var item in FileHandling.projectList)
                {
                    Console.WriteLine($"{item.P_ID} {item.P_Name} {item.P_Desc} {item.P_LeaderId} {item.P_Duration} {item.P_Budget}");
                }
                Console.WriteLine("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // -----------------------------------------------------------------------------------------------------------------------------------------------------


        // Save EQUIPMENT to EQUIPMENT.csv
        public static void WriteAllEquipment() 
        {
            File.WriteAllText(equipment_path, String.Empty);

            using (StreamWriter writerEquipmentCSV = new StreamWriter(equipment_path))
            {
                Console.WriteLine(" ---------------------");
                Console.WriteLine("| Write EQUIPMENT.csv |");
                Console.WriteLine(" ---------------------");
                writerEquipmentCSV.WriteLine($"ID,NAME,DESCRIPTION,COST,CATEGORY,STATUS");  // Equipment Header Line
                foreach (var item in FileHandling.equipmentList)
                {
                    writerEquipmentCSV.WriteLine($"{item.E_Id},{item.E_Name},{item.E_Desc},{item.E_Cost},{item.E_Category},{item.E_Status}");
                    Console.WriteLine($"{item.E_Id},{item.E_Name},{item.E_Desc},{item.E_Cost},{item.E_Category},{item.E_Status}");
                }
                Console.WriteLine("");
            }
        }

        // Save CATEGORY to CATEGORY.csv
        public static void WriteAllCategory()
        {
            File.WriteAllText(category_path, String.Empty);

            using (StreamWriter writerEquipmentCSV = new StreamWriter(category_path))
            {
                Console.WriteLine(" --------------------");
                Console.WriteLine("| Write CATEGORY.csv |");
                Console.WriteLine(" --------------------");
                writerEquipmentCSV.WriteLine($"INDEX,CATEGORY NAME");   // Category Header Line
                foreach (var item in FileHandling.categoryList)
                {
                    writerEquipmentCSV.WriteLine($"{item.C_Index},{item.C_Name}");
                    Console.WriteLine($"{item.C_Index},{item.C_Name}");
                }
                Console.WriteLine("");
            }
        }

        // Save PROJECT to PROJECT.csv
        public static void WriteAllProject()
        {
            // JIA WEN' CODES
        }
    }
}
