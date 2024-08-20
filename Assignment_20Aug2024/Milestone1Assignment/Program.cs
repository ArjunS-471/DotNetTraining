using System.Data;
using System.Text.RegularExpressions;

namespace Assignment_20Aug2024
{
    public class DocInfo
    {
        public int intRegNo;
        public string strDocName;
        public string strCityName;
        public string strSpecialisation;
        public string strClinicAddr;
        public string strClinicTimings;
        public long strContactNum;
    }
    internal class DoctorMgmtSystem
    {
        //For collecting information from Users
        public static DocInfo AddInfo()
        {
            DocInfo i = new DocInfo();
            Boolean LoopExit = true;

            //ID
            while (LoopExit)
            {
                Console.WriteLine("Enter Registration Number :");
                string strTemp = Console.ReadLine();
                if (strTemp == null || strTemp == "")
                {
                    Console.WriteLine("Registration Number cannot be blank");
                }
                else if (strTemp.All(char.IsDigit))
                {
                    i.intRegNo = Convert.ToInt32(strTemp);
                    if (i.intRegNo.ToString().Length == 7)
                    {
                        LoopExit = false;
                    }
                    else
                    {
                        Console.WriteLine("Registration Number must have 7 digits, please re-enter");
                    }
                }
                else
                {
                    Console.WriteLine("Registration Number must contain only numbers");
                }
            }
            LoopExit = true;

            //Name
            while (LoopExit)
            {
                Console.WriteLine("Enter Doctor Name :");
                i.strDocName = Console.ReadLine();
                if (i.strDocName == null || i.strDocName == "")
                {
                    Console.WriteLine("Name cannot be blank");
                }
                else if (i.strDocName.All(char.IsLetter)) 
                {
                    LoopExit = false;
                } 
                else
                {
                    Console.WriteLine("Only alphabets to be present in name, please re-enter");
                }
            }
            LoopExit = true;

            //City Name
            while (LoopExit)
            {
                Console.WriteLine("Enter City Name :");
                i.strCityName = Console.ReadLine();
                if (i.strCityName == null || i.strCityName == "")
                {
                    Console.WriteLine("City cannot be blank");
                }
                else if (i.strCityName.All(char.IsLetter))
                {
                    LoopExit = false;
                }
                else
                {
                    Console.WriteLine("Only alphabets to be present in city name, please re-enter");
                }
            }
            LoopExit = true;

            //Specialisation
            Console.WriteLine("Enter Specialisation :");
            i.strSpecialisation = Console.ReadLine();
            //Clinic address
            Console.WriteLine("Enter clinic address :");
            i.strClinicAddr = Console.ReadLine();

            //Clinic timings
            while (LoopExit)
            {
                Console.WriteLine("Enter clinic timings :");
                i.strClinicTimings = Console.ReadLine();
                if (i.strClinicTimings == null || i.strClinicTimings == "")
                {
                    Console.WriteLine("Clinic timings cannot be blank");
                }
                else if (Regex.IsMatch(i.strClinicTimings,@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).+$"))
                {
                    LoopExit = false;
                }
                else
                {
                    Console.WriteLine("Clinic timings can have only numbers, alphabets and special character");
                }
            }
            LoopExit = true;

            //Contact number
            while (LoopExit)
            {
                Console.WriteLine("Enter Contact Number :");
                string strTemp = Console.ReadLine();
                if (strTemp == null || strTemp == "")
                {
                    Console.WriteLine("Contact Number cannot be blank");
                }
                else if (strTemp.All(char.IsDigit))
                {
                    i.strContactNum = Convert.ToInt32(strTemp);
                    if (i.strContactNum.ToString().Length == 10)
                    {
                        LoopExit = false;
                    }
                    else
                    {
                        Console.WriteLine("Contact Number must have 7 digits, please re-enter");
                    }
                }
                else
                {
                    Console.WriteLine("Contact Number must contain only numbers");
                }
            }
            
            return i;
        }

        //For displaying collected Doctor Details
        public static void DisplayInfo(DocInfo[] InfoList)
        {
            Console.WriteLine("Reg No" + "\t" + "Doc Name" + "\t" + "City Name" + "\t" + "Specialisation" + "\t" + "Clinic Address" + "\t" + "Clinic Timings" + "\t" + "Contact No.");
            for (int i = 0; i < InfoList.Length; i++)
            {
                if (InfoList[i] == null)
                {
                    break;
                }
                else
                {
                    Console.Write(InfoList[i].intRegNo + "\t" + InfoList[i].strDocName + "\t" + InfoList[i].strCityName + "\t" + InfoList[i].strSpecialisation + "\t" + InfoList[i].strClinicAddr + "\t" + InfoList[i].strClinicTimings + "\t" + InfoList[i].strContactNum + "\n");
                }
            }
        }

        //For searching a doc info details based on provided RegNo.
        public static void FetchInfo(DocInfo[] InfoList)
        {
            int Num;
            Console.WriteLine("Enter RegNo to be fetched = ");
            Num = Int32.Parse(Console.ReadLine());

            DocInfo[] List2 = new DocInfo[10];
            bool blnItemFound = true;

            //Except for the matching Reg No, all other items added to new array
            for (int i = 0; i < InfoList.Length; i++)
            {
                if (InfoList[i] == null)
                {
                    break;
                }
                else if (InfoList[i].intRegNo == Num)
                {
                    Console.WriteLine("Reg No" + "\t" + "Doc Name" + "\t" + "City Name" + "\t" + "Specialisation" + "\t" + "Clinic Address" + "\t" + "Clinic Timings" + "\t" + "Contact No.");
                    Console.Write(InfoList[i].intRegNo + "\t" + InfoList[i].strDocName + "\t" + InfoList[i].strCityName + "\t" + InfoList[i].strSpecialisation + "\t" + InfoList[i].strClinicAddr + "\t" + InfoList[i].strClinicTimings + "\t" + InfoList[i].strContactNum + "\n");
                    blnItemFound = true;
                    break;
                }
            }
            if (blnItemFound)
            {
                Console.WriteLine("Entered number not present in available list");
            }
        }

        //For deleting a doc info details based on provided RegNo.
        public static DocInfo[] DeleteInfo(DocInfo[] InfoList)
        {
            int Num;
            Console.WriteLine("Enter RegNo to be deleted = ");
            Num = Int32.Parse(Console.ReadLine());

            DocInfo[] List2 = new DocInfo[10];
            int intIndex = 0;
            //Except for the matching Reg No, all other items added to new array
            for (int i = 0; i < InfoList.Length; i++)
            {
                if (InfoList[i] != null)
                {
                    if (InfoList[i].intRegNo != Num)
                    {
                        List2[intIndex] = InfoList[i];
                        intIndex++;
                    }
                }
            }
            //returning new array
            return List2;
        }
        public static void Main()
        {
            DocInfo[] Info = new DocInfo[10];
            int counter = 0;
            bool CircuitBreaker = true;
            while (CircuitBreaker)
            {
                Console.WriteLine("\n Please enter your choice \n 1.Add Info details \n 2.Display full Info \n 3.Fetch specific Info \n 4.Delete Info \n 5.Exit");
                Boolean choiceCheck = Int32.TryParse(Console.ReadLine(), out int choice);
                //choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Info[counter] = AddInfo();
                        counter++;
                        break;
                    case 2:
                        DisplayInfo(Info);
                        break;
                    case 3:
                        FetchInfo(Info);
                        break;
                    case 4:
                        Info = DeleteInfo(Info); ;
                        break;
                    case 5:
                        CircuitBreaker = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
                if (!CircuitBreaker)
                {
                    break;
                }
            }

        }
    }
}