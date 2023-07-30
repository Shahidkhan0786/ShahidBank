class Program
{
    static void Main()
    {
        //display name 
        System.Console.WriteLine("*************** ShahidBank ******************");
        System.Console.WriteLine(":: Login Page ::");

        //declare variables to store username and password
        string userName = null, password = null;

        //read username from keyboard
        System.Console.Write("Enter userName: ");
        userName = System.Console.ReadLine();

        if(userName != null)
        {
            System.Console.Write("Enter password: ");
            password = System.Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine("TODO: Main Menu Here");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.WriteLine("Enter Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice) {
                    case 1: CustomersMenu(); // Display Customer Name
                        break;
                    case 2:AccountsMenu(); // Display Accounts Menu
                        break;
                    case 3: // Display Funds Transfer
                        break; 
                    case 4: // Display Fund Transfer Statement
                        break;
                    case 5: // Display Account Statement
                        break;
                }
            }while(mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid username and password");
        }


        System.Console.WriteLine("Thankyou! Visit Again .");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        // varicle to store customer menu choice
        int customerMenuChoice = -1;
        // do while loops start
        do {
            // print customerMenu 
            System.Console.WriteLine("\n :::: Customer Menu ::::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Del Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customer");
            System.Console.WriteLine("0. Back to main menu");

            //take input
            System.Console.Write("Enter Choice : ");
            customerMenuChoice = int.Parse(System.Console.ReadLine());
        }
        while (customerMenuChoice != 0); 
    }

    // Accounts Menu Function
    static void AccountsMenu()
    {
        // varicle to store customer menu choice
        int accountMenuChoice = -1;
        // do while loops start
        do
        {
            // print customerMenu 
            System.Console.WriteLine("\n :::: Customer Menu ::::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Del Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Account");
            System.Console.WriteLine("0. Back to main menu");

            //take input
            System.Console.Write("Enter Choice : ");
            accountMenuChoice = int.Parse(System.Console.ReadLine());
        }
        while (accountMenuChoice != 0);
    }
}