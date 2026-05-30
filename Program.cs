string userChoice = string.Empty;
do
{
    Console.Clear();
    Console.WriteLine("==========================================");
    Console.WriteLine("             Datebase Of Teachers         ");
    Console.WriteLine("==========================================");
    Console.WriteLine("1. Show Teacher Base ");
    Console.WriteLine("2. Add New Teacher ");
    Console.WriteLine("3. Exit");
    Console.WriteLine("\n");

    int userInput = Convert.ToInt32(Console.ReadLine());
    switch (userInput)
    {
        case 1:
            {
                Console.WriteLine("DatabAseOfTEachers");
                break;
            }
        
        case 2:
            {
                Console.WriteLine("Add new TEacher");
                break;
            }
        
        case 3:
            {
                Console.WriteLine("Done");
                break;
            }
        default:
            {
                Console.WriteLine("Wrong Choice!!!");
                break;
            }
    }
    Console.WriteLine("\nMenu ga qaytish uchun yes yozing:");
    userChoice = Console.ReadLine();
    
} while(userChoice.ToLower() == "yes");
