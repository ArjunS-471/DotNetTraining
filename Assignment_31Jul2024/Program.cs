using System.Data;

namespace Assignment_31Jul2024
{
    public class Books
    {
        public int intBookId;
        public string strBookName;
        public int intISBNNo;
        public int intPrice;
        public string strPublisher;
        public int intPages;
        public string strLanguage;
        public string strLoT;
        public string strSummary;
    }
    internal class BooksProgram
    {
        //For collecting book details
        public static Books AddBooks()
        {
            Books b = new Books();
            Boolean LoopExit = true;

            //ID
            while (LoopExit)
            {
                Console.WriteLine("Enter Book ID :");
                string strTemp = Console.ReadLine();
                if (strTemp == null || strTemp == "")
                {
                    Console.WriteLine("Book ID cannot be blank");
                }
                else
                {
                    b.intBookId = Convert.ToInt32(strTemp);
                    if(b.intBookId.ToString().Length == 5)
                    {
                        LoopExit = false;
                    }
                    else
                    {
                        Console.WriteLine("Book id should have 5 digits, please re-enter");
                    }
                }
            }
            LoopExit = true;

            //Name
            while (LoopExit)
            {
                Console.WriteLine("Enter Book Name :");
                b.strBookName = Console.ReadLine();
                if (b.strBookName == null || b.strBookName == "")
                {
                    Console.WriteLine("Book Name cannot be blank");
                }
                else
                {
                    LoopExit = false;
                }
            }
            LoopExit = true;

            //ISBN, Price, Publisher, Page count
            Console.WriteLine("Enter Book ISBN (number expected) :");
            b.intISBNNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book price (number expected) :");
            b.intPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book publisher name :");
            b.strPublisher = Console.ReadLine();

            Console.WriteLine("Enter Book page number count (number expected) :");
            b.intPages = Convert.ToInt32(Console.ReadLine());

            //Language
            Console.WriteLine("Enter Book language :");
            b.strLanguage = Console.ReadLine();
            if (b.strLanguage == "")
            {
                b.strLanguage = "English";
            }

            //LoT
            while (LoopExit)
            {
                Console.WriteLine("Enter Book LoT :");
                b.strLoT = Console.ReadLine();
                if (b.strLoT == "")
                {
                    b.strLoT = "Technical";
                    LoopExit = false;
                }
                else if (b.strLoT != ".NET" && b.strLoT != "Java" && b.strLoT != "IMS" && b.strLoT != "V&V" && b.strLoT != "BI" && b.strLoT != "RDBMS")
                {
                    Console.WriteLine("Entered strLot is incorrect");
                }
                else
                {
                    LoopExit = false;
                }
            }
            
            //Summary
            Console.WriteLine("Enter book summary :");
            b.strSummary = Console.ReadLine();

            return b;
        }

        //For displaying collected book details
        public static void DisplayBooks(Books[] BooksList)
        {
            Console.WriteLine("ID" + "\t" + "Name" + "\t" + "ISBN No" + "\t" + "Price" + "\t" + "Publisher" + "\t" + "Pages" + "\t" + "Language" + "\t" + "LoT" + "\t" + "Summary");
            for (int i = 0; i < BooksList.Length; i++)
            {
                if (BooksList[i] == null)
                {
                    break;
                }
                else
                {
                    Console.Write(BooksList[i].intBookId + "\t" + BooksList[i].strBookName + "\t" + BooksList[i].intISBNNo + "\t" + BooksList[i].intPrice + "\t" + BooksList[i].strPublisher + "\t" + BooksList[i].intPages + "\t" + BooksList[i].strLanguage + "\t" + BooksList[i].strLoT + "\t" + BooksList[i].strSummary + "\n");
                }
            }
        }

        //For deleting a book details based on provided ID
        public static Books[] DeleteBook(Books[] BookList)
        {
            int Num;
            Console.WriteLine("Enter book id to be deleted = ");
            Num = Int32.Parse(Console.ReadLine());

            Books[] Books2 = new Books[10];
            int intIndex = 0;
            //Except for the matching ID, all other items added to new array
            for (int i = 0; i < BookList.Length; i++)
            {
                if (BookList[i] != null)
                {
                    if (BookList[i].intBookId != Num)
                    {
                        Books2[intIndex] = BookList[i];
                        intIndex++;
                    }
                }
            }
            //returning new array
            return Books2;
        }
        public static void Main()
        {
            Books[] Books = new Books[10];
            int counter = 0;
            bool CircuitBreaker = true;
            while (CircuitBreaker)
            {
                Console.WriteLine("\n Please enter your choice \n 1.Add Book details \n 2.Display Books \n 3.Delete Books \n 4.Exit");
                Boolean choiceCheck = Int32.TryParse(Console.ReadLine(), out int choice);
                //choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Books[counter] = AddBooks();
                        counter++;
                        break;
                    case 2:
                        DisplayBooks(Books);
                        break;
                    case 3:
                        Books = DeleteBook(Books); ;
                        break;
                    case 4:
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