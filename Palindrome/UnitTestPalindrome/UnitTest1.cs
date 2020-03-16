using Microsoft.VisualStudio.TestTools.UnitTesting;
// added reference Palindrome to UnitTestPalindrome
using Palindrome;
using System;

namespace UnitTestPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        Interface1 _io;
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestPalindrome(_io);
        }

        /*a palindrome reads the same forwards and backwards.
        for example, these should be considered palindromes:
        - "nurses run"
        - "racecaR"
        - "1221"
        - "never odd, or even."
        and these should not be considered palindromes:
        - "one two one"
        - "123abccba123"*/
        public void UnitTestPalindrome(Interface1 io)
        {
            _io = io;
            bool testBool = _io.IsPalindrome("racecar");
            Console.WriteLine(Convert.ToString(testBool));
        }
    }
}
