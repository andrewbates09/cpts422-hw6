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
    ///////////////////////////////////////////////////////////////////////////////
    /// \file         Account.h
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
                mBalance = 0.0;
            }
            else
            {
                mBalance = initialBalance;
            }

            mAccountNumber = newAccountNumber;
            mName = newName;
            mDateCreated = newDateCreated;
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
            mBalance = copyAccount.getBalance();
            mAccountNumber = copyAccount.getAccountNumber();
            mName = copyAccount.getName();
            mDateCreated = copyAccount.getName();
        }

        ///////////////////////////////////////////////////////////////////////
        /// ~Account ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void Dispose()
        {
            // Accounts are not created using dynamic memory.
            // This method does nothing.
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
                mBalance = rhs.getBalance();
                mAccountNumber = rhs.getAccountNumber();
                mName = rhs.getName();
                mDateCreated = rhs.getName();
            }

            return this;
        }


        ///////////////////////////////////////////////////////////////////////
        /// getBalance ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: double getBalance() const
        public double getBalance()
        {
            return mBalance;
        }

        ///////////////////////////////////////////////////////////////////////
        /// getAccountNumber ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: int getAccountNumber() const
        public int getAccountNumber()
        {
            return mAccountNumber;
        }

        ///////////////////////////////////////////////////////////////////////
        /// getName ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: string getName() const
        public string getName()
        {
            return mName;
        }

        ///////////////////////////////////////////////////////////////////////
        /// getDateCreated ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: string getDateCreated() const
        public string getDateCreated()
        {
            return mDateCreated;
        }


        ///////////////////////////////////////////////////////////////////////
        /// setBalance ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void setBalance(double newBalance)
        {
            mBalance = newBalance;
        }

        ///////////////////////////////////////////////////////////////////////
        /// setAccountNumber ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void setAccountNumber(int newAccountNumber)
        {
            mAccountNumber = newAccountNumber;
        }

        ///////////////////////////////////////////////////////////////////////
        /// setName ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void setName(string newName)
        {
            mName = newName;
        }

        ///////////////////////////////////////////////////////////////////////
        /// setDateCreated ()
        /// \pre    
        /// \post   
        /// \param  (repeat for every parameter)
        /// \return
        /// \throw  
        ///////////////////////////////////////////////////////////////////////

        public void setDateCreated(string newDateCreated)
        {
            mDateCreated = newDateCreated;
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
            mBalance += newAmount;
            return mBalance;
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
            if (newAmount > mBalance)
            {
                Console.Write("WARNING: Can't withdraw ");
                Console.Write(newAmount);
                Console.Write(" exceeds your funds!");
                Console.Write("\n");
            }
            else
            {
                mBalance -= newAmount;
            }

            return mBalance;
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
            Console.Write(mAccountNumber);
            Console.Write("\n");
            Console.Write("Name: ");
            Console.Write(mName);
            Console.Write("\n");
            Console.Write("Current Balance: ");
            Console.Write(mBalance);
            Console.Write("\n");
            Console.Write("Date Created: ");
            Console.Write(mDateCreated);
            Console.Write("\n");
        }

        private double mBalance;
        private int mAccountNumber;
        private string mName;
        private string mDateCreated;
    }
}