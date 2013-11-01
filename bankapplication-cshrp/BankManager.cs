using System;

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

		public BankManager()
		{
			mAccountsPtr = Arrays.InitializeWithDefaultInstances<Account>(1024);
			mAccountsAvailablePtr = new bool[1024];

			for (int counter = 0; counter < 1024; counter++)
			{
				mAccountsAvailablePtr[counter] = true;
			}

			mNumberAccounts = 1024;
		}

		///////////////////////////////////////////////////////////////////////
		/// BankManager ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

		public BankManager(int maxNumberAccounts)
		{
			mAccountsPtr = Arrays.InitializeWithDefaultInstances<Account>(maxNumberAccounts);
			mAccountsAvailablePtr = new bool[maxNumberAccounts];

			for (int counter = 0; counter < maxNumberAccounts; counter++)
			{
				mAccountsAvailablePtr[counter] = true;
			}

			mNumberAccounts = maxNumberAccounts;
		}

		///////////////////////////////////////////////////////////////////////
		/// ~BankManager ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

		public void Dispose()
		{
			mAccountsPtr = null;
			mAccountsAvailablePtr = null;
		}

		// overloaded assignment operator
//C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
//ORIGINAL LINE: BankManager & operator = (const BankManager &rhs);
//		BankManager CopyFrom (BankManager rhs);

		// getters / accessors

		///////////////////////////////////////////////////////////////////////
		/// getAccountPtr ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: Account * getAccountsPtr() const
		public Account getAccountsPtr()
		{
			return mAccountsPtr;
		}

		///////////////////////////////////////////////////////////////////////
		/// getAccountsAvailablePtr ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: bool * getAccountsAvailablePtr() const
//C++ TO C# CONVERTER WARNING: C# has no equivalent to methods returning pointers to value types:
		public bool getAccountsAvailablePtr()
		{
			return mAccountsAvailablePtr;
		}

		///////////////////////////////////////////////////////////////////////
		/// getNumberAccounts ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
//ORIGINAL LINE: int getNumberAccounts() const
		public int getNumberAccounts()
		{
			return mNumberAccounts;
		}

		// setters / mutators

		///////////////////////////////////////////////////////////////////////
		/// setAccountsPtr ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

		public void setAccountsPtr(Account newAccountsPtr)
		{
			mAccountsPtr = newAccountsPtr;
		}

		///////////////////////////////////////////////////////////////////////
		/// setAccountsAvailablePtr ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

		public void setAccountsAvailablePtr(ref bool newAccountsAvailablePtr)
		{
			mAccountsAvailablePtr = newAccountsAvailablePtr;
		}

		///////////////////////////////////////////////////////////////////////
		/// setNumberAccounts ()
		/// \pre    
		/// \post   
		/// \param  (repeat for every parameter)
		/// \return
		/// \throw  
		///////////////////////////////////////////////////////////////////////

		public void setNumberAccounts(int newNumberAccounts)
		{
			mNumberAccounts = newNumberAccounts;
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

			cin >> option;

			system("cls");

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
			cin >> accountNumber;

			Console.Write("Enter name: ");
			cin.clear();
			cin.sync();
			cStringName = Console.ReadLine();
			name = ((char)cStringName).ToString();

			Console.Write("Enter balance: ");
			cin >> balance;

			Console.Write("Enter date: ");
			cin >> dateCreated;

			int counter = 0;
			while ((mAccountsAvailablePtr[counter] != true) && (counter < mNumberAccounts))
			{
				// search for avialable account space in the array
				counter++;
			}

			if (mNumberAccounts <= counter)
			{
				Console.Write("WARNING: Could not create account!");
				Console.Write("\n");
				success = false;
			}
			else
			{
				mAccountsPtr[counter].setAccountNumber(accountNumber);
				mAccountsPtr[counter].setName(name);
				mAccountsPtr[counter].setBalance(balance);
				mAccountsPtr[counter].setDateCreated(dateCreated);

				mAccountsAvailablePtr[counter] = false;
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
			int counter = 0;

			counter = findAccount();

			if ((counter < mNumberAccounts) && (mAccountsAvailablePtr[counter] == false)) // we found the account, so delete it
			{
				success = true;
				mAccountsAvailablePtr[counter] = true;
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
			string dateCreated = "";
			double balance = 0.0;
			double deposit = 0.0;
			int accountNumber = 0;
			int counter = 0;
			int option = 0;

			counter = findAccount();

			if ((counter < mNumberAccounts) && (mAccountsAvailablePtr[counter] == false)) // we found the account, so delete it
			{
				success = true;

				Console.Write("1. Update Name");
				Console.Write("\n");
				Console.Write("2. Withdraw Money");
				Console.Write("\n");
				Console.Write("3. Deposit Money");
				Console.Write("\n");

				cin >> option;

				switch (option)
				{
					case 1:
						Console.Write("Enter name: ");
							cin >> name;
							mAccountsPtr[counter].setName(name);
							break;
					case 2:
						Console.Write("Enter amount to withdraw: ");
							cin >> balance;
							mAccountsPtr[counter].debit(balance);
							break;
					case 3:
						Console.Write("Enter amount to deposit: ");
							cin >> deposit;
							mAccountsPtr[counter].credit(deposit);
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

			if ((counter < mNumberAccounts) && (mAccountsAvailablePtr[counter] == false)) // we found the account, so delete it
			{
				mAccountsPtr[counter].printBalance();
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
			cin >> accountNumber;

			int counter = 0;
			for (counter = 0; ((counter < mNumberAccounts) && (mAccountsPtr[counter].getAccountNumber() != accountNumber)); counter++)
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

		private Account mAccountsPtr;
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: bool *mAccountsAvailablePtr;
		private bool mAccountsAvailablePtr;
		private int mNumberAccounts;
}