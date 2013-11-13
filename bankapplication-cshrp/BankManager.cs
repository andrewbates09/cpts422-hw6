using System;
using System.Collections.Generic;

namespace bankapp
{
    ///////////////////////////////////////////////////////////////////////////////
    /// \file         BankManager.cpp
    /// \author       Andrew S. O'Fallon
    /// \date         
    /// \brief        This application performs basic banking operations.
    ///           
    ///       
    /// REVISION HISTORY:
    /// \date  
    ///            
    ///////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////
    /// \file         BankManager.h
    /// \author       Andrew S. O'Fallon
    /// \date         
    /// \brief        This application performs basic banking operations.
    ///           
    ///       
    /// REVISION HISTORY:
    /// \date 
    ///            
    ///////////////////////////////////////////////////////////////////////////////

    public class BankManager
    {

        ///////////////////////////////////////////////////////////////////////
        /// BankManager ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public BankManager(int maxNumberAccounts = 1024)
        {
            Accounts = new Account[1024];
            AccountsAvailable = new bool[maxNumberAccounts];

            for (int counter = 0; counter < maxNumberAccounts; counter++)
            {
                Accounts[counter] = new Account();
                AccountsAvailable[counter] = true;
            }

            NumberAccounts = maxNumberAccounts;
        }



        ///////////////////////////////////////////////////////////////////////
        /// displayMenu ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void displayMenu()
        {
            Console.Write("1. Create account");
            Console.Write("\n");
            Console.Write("2. Delete account");
            Console.Write("\n");
            Console.Write("3. Update account");
            Console.Write("\n");
            Console.Write("4. Display account");
            Console.Write("\n");
            Console.Write("5. Exit");
            Console.Write("\n");
        }

        ///////////////////////////////////////////////////////////////////////
        /// getMenuOption ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: int getMenuOption() const
        public int getMenuOption()
        {
            int option = 0;

            string line = Console.ReadLine();
            int.TryParse(line, out option);

            Console.Clear();

            return option;
        }

        ///////////////////////////////////////////////////////////////////////
        /// createAccount ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public bool createAccount()
        {
            int accountNumber = 0;
            double balance = 0.0;
            string cStringName = new string(new char[100]);
            string name = "";
            string dateCreated = "";
            bool success = true;

            Console.Write("Enter account number: ");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out accountNumber))
            {
                return false;
            }

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter balance: ");
            line = Console.ReadLine();
            if (!double.TryParse(line, out balance))
            {
                return false;
            }

            Console.Write("Enter date: ");
            dateCreated = Console.ReadLine();

            int counter = 0;
            while ((AccountsAvailable[counter] != true) && (counter < NumberAccounts))
            {
                // search for avialable account space in the array
                counter++;
            }

            if (NumberAccounts <= counter)
            {
                Console.Write("WARNING: Could not create account!");
                Console.Write("\n");
                success = false;
            }
            else
            {
                Accounts[counter].AccountNumber = accountNumber;
                Accounts[counter].Name = name;
                Accounts[counter].Balance = balance;
                Accounts[counter].DateCreated = dateCreated;

                AccountsAvailable[counter] = false;
            }

            return success;
        }

        ///////////////////////////////////////////////////////////////////////
        /// deleteAccount ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public bool deleteAccount()
        {
            bool success = false;
            int accountNumber = 0;

            accountNumber = findAccount();

            if ((accountNumber < NumberAccounts) && (AccountsAvailable[accountNumber] == false)) // we found the account, so delete it
            {
                success = true;
                AccountsAvailable[accountNumber] = true;
                Console.Write("Account deleted!");
                Console.Write("\n");
            }

            return success;
        }

        ///////////////////////////////////////////////////////////////////////
        /// updateAccount ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public bool updateAccount()
        {
            bool success = false;
            string name = "";
            double balance = 0.0;
            double deposit = 0.0;
            int accountNumber = 0;
            int option = 0;

            accountNumber = findAccount();

            if ((accountNumber < NumberAccounts) && (AccountsAvailable[accountNumber] == false)) // we found the account, so delete it
            {
                success = true;

                Console.Write("1. Update Name");
                Console.Write("\n");
                Console.Write("2. Withdraw Money");
                Console.Write("\n");
                Console.Write("3. Deposit Money");
                Console.Write("\n");

                string line = Console.ReadLine();
                if (!int.TryParse(line, out option))
                {
                    return false;
                }

                switch (option)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        name = Console.ReadLine();                        
                        Accounts[accountNumber].Name = name;
                        break;
                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        line = Console.ReadLine();
                        if (!double.TryParse(line, out balance))
                        {
                            break;
                        }
                        Accounts[accountNumber].debit(balance);
                        break;
                    case 3:
                        Console.Write("Enter amount to deposit: ");
                        line = Console.ReadLine();
                        if (!double.TryParse(line, out deposit))
                        {
                            break;
                        }
                        Accounts[accountNumber].credit(deposit);
                        break;
                    default:
                        Console.Write("ERROR: Invalid option!");
                        Console.Write("\n");
                        break;
                }
            }

            return success;
        }

        ///////////////////////////////////////////////////////////////////////
        /// displayAccount ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: void displayAccount() const
        public void displayAccount()
        {
            int counter = 0;

            counter = findAccount();

            if ((counter < NumberAccounts) && (AccountsAvailable[counter] == false)) // we found the account, so delete it
            {
                Accounts[counter].printBalance();
            }
            else
            {
                Console.Write("WARNING: Account does not exist!");
                Console.Write("\n");
            }
        }

        ///////////////////////////////////////////////////////////////////////
        /// findAccount ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: int findAccount() const
        public int findAccount()
        {
            int accountNumber = 0;

            Console.Write("Enter account number: ");
            string line = Console.ReadLine();
            int.TryParse(line, out accountNumber);

            int counter = 0;
            for (counter = 0; ((counter < NumberAccounts) && (Accounts[counter].AccountNumber != accountNumber)); counter++)
            {
                // The header of the for () takes care of all logic
            }

            return counter;
        }


        ///////////////////////////////////////////////////////////////////////
        /// runBankApplication ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void runBankApplication()
        {
            int option = 0;
            bool status = true;
            bool success = true;

            Console.Write("*** Welcome to AO's user friendly banking system ***");
            Console.Write("\n");
            Console.Write("\n");

            do
            {
                Console.Clear();
                displayMenu();
                option = getMenuOption();

                switch (option)
                {
                    case 1:
                        success = createAccount();
                        if (success == false)
                        {
                            Console.Write("WARNING: Could not create account!");
                            Console.Write("\n");
                        }
                        break;
                    case 2:
                        success = deleteAccount();
                        if (success == false)
                        {
                            Console.Write("WARNING: Could not delete account!");
                            Console.Write("\n");
                        }

                        break;
                    case 3:
                        success = updateAccount();
                        if (success == false)
                        {
                            Console.Write("WARNING: Could not update account!");
                            Console.Write("\n");
                        }

                        break;
                    case 4:
                        displayAccount();
                        break;
                    case 5:
                        status = false;
                        break;
                    default:
                        Console.Write("ERROR: Invalid choice!");
                        Console.Write("\n");
                        break;
                }
            } while (status != false);
        }

        public Account[] Accounts { get; set; }
        public bool[] AccountsAvailable { get; set; }
        public int NumberAccounts { get; set; }
    }
}