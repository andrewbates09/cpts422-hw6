using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace bankapp
{
	public class BankManagerTest
    {
        [Fact]
        public void createAccount()
        {
            BankManager bm = new BankManager();

            //bm.createAccount();

            bm.Accounts[0].AccountNumber = 1;
            bm.Accounts[0].Name = "TestAcct";
            bm.Accounts[0].Balance = 50;
            bm.Accounts[0].DateCreated = "1/1/11";
            bm.AccountsAvailable[0] = false;

            Assert.True(bm.Accounts[0].AccountNumber == 1);
            Assert.True(bm.Accounts[0].Name == "TestAcct");
            Assert.True(bm.Accounts[0].Balance == 50);
            Assert.True(bm.Accounts[0].DateCreated == "1/1/11");
            Assert.True(bm.AccountsAvailable[0] == false);
        }
    }
}
