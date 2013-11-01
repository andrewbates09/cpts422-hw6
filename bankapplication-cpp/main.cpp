///////////////////////////////////////////////////////////////////////////////
/// \file         Main Program App (BankApplication.cpp)
/// \author       Andrew S. O'Fallon
/// \date         
/// \brief        This application performs basic banking operations.
///               Limited error checking is provided.
///           
///       
/// REVISION HISTORY:
/// \date  
///            
///////////////////////////////////////////////////////////////////////////////

#include "BankManager.h"

int main (void)
{
	BankManager bankApp;

	bankApp.runBankApplication ();

	return 0;
}