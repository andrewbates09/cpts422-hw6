using System;


namespace bankapp
{
    ///////////////////////////////////////////////////////////////////////////////
    /// \file         Account.cpp
    /// \author       Andrew S. O'Fallon
    /// \date         
    /// \brief        This application performs basic banking operations.
    ///           
    ///       
    /// REVISION HISTORY:
    /// \date  
    ///            
    ///////////////////////////////////////////////////////////////////////////////
    public class Account
    {

        ///////////////////////////////////////////////////////////////////////
        /// Account ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public Account(double initialBalance = 0.0, int newAccountNumber = 0, string newName = "", string newDateCreated = "")
        {
            if (initialBalance < 0.0)
            {
                Balance = 0.0;
            }
            else
            {
                Balance = initialBalance;
            }

            AccountNumber = newAccountNumber;
            Name = newName;
            DateCreated = newDateCreated;
        }

        ///////////////////////////////////////////////////////////////////////
        /// Account (Account &)
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public Account(Account copyAccount)
        {
            Balance = copyAccount.Balance;
            AccountNumber = copyAccount.AccountNumber;
            Name = copyAccount.Name;
            DateCreated = copyAccount.DateCreated;
        }

        ///////////////////////////////////////////////////////////////////////
        /// Assignment operator
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
        //ORIGINAL LINE: Account & operator = (const Account &rhs)
        public Account CopyFrom(Account rhs)
        {
            if (this != rhs)
            {
                Balance = rhs.Balance;
                AccountNumber = rhs.AccountNumber;
                Name = rhs.Name;
                DateCreated = rhs.DateCreated;
            }

            return this;
        }

        ///////////////////////////////////////////////////////////////////////
        /// credit ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public double credit(double newAmount)
        {
            Balance += newAmount;
            return Balance;
        }

        ///////////////////////////////////////////////////////////////////////
        /// debit ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public double debit(double newAmount)
        {
            if (newAmount > Balance)
            {
                Console.Write("WARNING: Can't withdraw ");
                Console.Write(newAmount);
                Console.Write(" exceeds your funds!");
                Console.Write("\n");
            }
            else
            {
                Balance -= newAmount;
            }

            return Balance;
        }

        ///////////////////////////////////////////////////////////////////////
        /// printBalance ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void printBalance()
        {
            Console.Write("A#: ");
            Console.Write(AccountNumber);
            Console.Write("\n");
            Console.Write("Name: ");
            Console.Write(Name);
            Console.Write("\n");
            Console.Write("Current Balance: ");
            Console.Write(Balance);
            Console.Write("\n");
            Console.Write("Date Created: ");
            Console.Write(DateCreated);
            Console.Write("\n");
        }

        public double Balance { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public string DateCreated { get; set; }
    }
}