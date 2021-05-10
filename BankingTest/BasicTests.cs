using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTest
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void CantTakeMorwthanYouHave()
        {
            var account = new BankAccount("Ram", 10000);
            //Test for negative balance
            Assert.Throws<InvalidOperationException>(
                ()=>account.MakeWithdrawal(35000,DateTime.Now,"Attempt To Overdraw")
                );
        }

       [Fact]
       public void NeedbalnceToStart()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                ()=>new BankAccount("Invalid",-55)
                );
        }
    }
}
