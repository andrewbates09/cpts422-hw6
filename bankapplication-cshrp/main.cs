namespace bankapp
{

    public static class BankApp
    {
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


        public static int Main()
        {
            BankManager bankApp = new BankManager();

            bankApp.runBankApplication();

            return 0;
        }
    }
}
