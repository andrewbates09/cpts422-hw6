using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace bankapp
{
    public class AccountTest
    {
        [Fact]
        public void createAccount()
        {
            Account account = new Account(50.0, 1, "TestAcct", "1/1/11");

            Assert.True(account.Balance == 50.0);
            Assert.True(account.AccountNumber == 1);
            Assert.True(account.Name == "TestAcct");
            Assert.True(account.DateCreated == "1/1/11");
        }

        [Fact]
        public void copyAccount()
        {
            Account account = new Account(50.0, 1, "TestAcct", "1/1/11");
            Account account2 = new Account(account);

            Assert.True(account.Balance == account2.Balance);
            Assert.True(account.AccountNumber == account2.AccountNumber);
            Assert.True(account.Name == account2.Name);
            Assert.True(account.DateCreated == account2.DateCreated);
        }

        [Fact]
        public void copyAccount()
        {
            Account account = new Account(50.0, 1, "TestAcct", "1/1/11");
            Account account2 = new Account(account);
        }


    }
}
