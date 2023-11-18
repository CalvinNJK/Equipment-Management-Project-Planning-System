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
        public static List<EquipmentUsed> equipmentUsedList = new List<EquipmentUsed>();

        // File Paths
        private static string equipment_path = @"C:\EMPPS\equipment.csv";
        private static string category_path = @"C:\EMPPS\category.csv";
        private static string project_path = @"C:\EMPPS\project.csv";
        private static string equipmentUsed_path = @"C:\EMPPS\equipmentUsed.csv";


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

                        equipmentList.Add(new Equipment(temp[0], temp[1], temp[2], Double.Parse(temp[3]), Double.Parse(temp[4]), Int32.Parse(temp[5]), Int32.Parse(temp[6])));
                    }
                }

                // Testing Purpose - Check List Input
                Console.WriteLine(" --------------------");
                Console.WriteLine("| Read EQUIPMENT.csv |");
                Console.WriteLine($"| Items: {equipmentList.Count,-11} |");
                Console.WriteLine(" --------------------");
                foreach (var item in FileHandling.equipmentList)
                {
                    Console.WriteLine($"{item.E_Id} {item.E_Name} {item.E_Desc} {item.E_Cost} {item.E_CostPerDay} {item.E_Category} {item.E_Status}");
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
                using (StreamReader readerProjectCSV = new StreamReader(project_path))
                {
                    string headerLine = readerProjectCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerProjectCSV.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');

                        projectList.Add(new Project(temp[0], temp[1], temp[2], temp[3], Int32.Parse(temp[4]), Double.Parse(temp[5])));
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

        // Initial Reading for PROJECT.csv
        public static void ReadAllEquipmentUsed()
        {
            try
            {
                using (StreamReader readerEquipmentUsedCSV = new StreamReader(equipmentUsed_path))
                {
                    string headerLine = readerEquipmentUsedCSV.ReadLine();   // To ignore the first (HEADER) line

                    string line;
                    while ((line = readerEquipmentUsedCSV.ReadLine()) != null)
                    {
                        string[] temp = line.Split(',');

                        equipmentUsedList.Add(new EquipmentUsed(temp[0], temp[1], temp[2], Int32.Parse(temp[3])));
                    }
                }

                // Testing Purpose - Check List input
                Console.WriteLine(" -------------------");
                Console.WriteLine("| Read Equipment Used.csv |");
                Console.WriteLine($"| Items: {equipmentUsedList.Count,-10} |");
                Console.WriteLine(" -------------------");
                foreach (var item in FileHandling.equipmentUsedList)
                {
                    Console.WriteLine($"{item.EUP_ID} {item.EU_ID} {item.EU_CostPerDay} {item.EU_Duration}");
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
                writerEquipmentCSV.WriteLine($"ID,NAME,DESCRIPTION,COST,COST PER DAY,CATEGORY,STATUS");  // Equipment Header Line
                foreach (var item in FileHandling.equipmentList)
                {
                    writerEquipmentCSV.WriteLine($"{item.E_Id},{item.E_Name},{item.E_Desc},{item.E_Cost},{item.E_CostPerDay},{item.E_Category},{item.E_Status}");
                    Console.WriteLine($"{item.E_Id},{item.E_Name},{item.E_Desc},{item.E_Cost},{item.E_CostPerDay},{item.E_Category},{item.E_Status}");
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
            File.WriteAllText(project_path, String.Empty);

            using (StreamWriter writerProjectCSV = new StreamWriter(project_path))
            {
                Console.WriteLine(" --------------------");
                Console.WriteLine("| Write PROJECT.csv |");
                Console.WriteLine(" --------------------");
                writerProjectCSV.WriteLine($"ID,NAME,DESCRIPTION,LEADER ID,DURATION,BUDGET");   // Project Header Line
                foreach (var item in FileHandling.projectList)
                {
                    writerProjectCSV.WriteLine($"{item.P_ID},{item.P_Name},{item.P_Desc},{item.P_LeaderId},{item.P_Duration},{item.P_Budget}");
                    Console.WriteLine($"{item.P_ID},{item.P_Name},{item.P_Desc},{item.P_LeaderId},{item.P_Duration},{item.P_Budget}");
                }
                Console.WriteLine("");
            }
        }

        // Save EQUIPMENT USED to EuipmentUsed.csv
        public static void WriteAllEquipmentUsed()
        {
            File.WriteAllText(equipmentUsed_path, String.Empty);

            using (StreamWriter writerProjectCSV = new StreamWriter(equipmentUsed_path))
            {
                Console.WriteLine(" --------------------");
                Console.WriteLine("| Write EuipmentUsed.csv |");
                Console.WriteLine(" --------------------");
                writerProjectCSV.WriteLine($"EQUIPMENT USED PROJECT ID,EQUIPMENT USED ID,COST PER DAY,DURATION");   // Project Header Line
                foreach (var item in FileHandling.equipmentUsedList)
                {
                    writerProjectCSV.WriteLine($"{item.EUP_ID},{item.EU_ID},{item.EU_CostPerDay},{item.EU_Duration}");
                    Console.WriteLine($"{item.EUP_ID},{item.EU_ID},{item.EU_CostPerDay},{item.EU_Duration}");

                }
                Console.WriteLine("");
            }
        }
    }
}
