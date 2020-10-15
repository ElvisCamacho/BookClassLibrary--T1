using System.Reflection;
using BookClassLibrary;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBook
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TITLE_lessthan2_throwArgumentOutOfRangeException()
        {
            Book book = new Book();

            try
            {
                book.Title= "s";
            }

            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }

            Assert.Fail();
        }


        [TestMethod]
        public void TITLE_MoreThan2Character()
        {
            Book book = new Book();

            string title = book.Title = "The man";
            book.Author = "Someone";
            book.Pages = 100;
            book.Isbn13 = "9876543219876";

            Assert.AreEqual("The man", title);
        }

        
        [TestMethod]
        public void IncorrectPage()
        {
            //Assign
            Book book;

            //Act
            book = new Book("The Book", "Anyone", 5, "1234567891234");
        }

        [TestMethod]
        public void Incorrect_Isbn13()
        {
            Book book = new Book();

            try
            {
                book.Isbn13= "2";
            }

            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void Correct_Isbn13()
        {
            Book book = new Book();

            string isbn13 = book.Isbn13 = "1234567891234";

            Assert.AreEqual("1234567891234", isbn13);
        }


        [TestMethod]
        public void CorrectSet()
        {
            //Assign
            Book book = new Book("The Book", "Anyone", 50, "1234567891234");

            //Act
            book.Title = "The Other Book";
            book.Author = "Someone";
            book.Pages = 100;
            book.Isbn13 = "9876543219876";

            //Assert
            Assert.AreEqual(book.Title, "The Other Book");
            Assert.AreEqual(book.Author, "Someone");
            Assert.AreEqual(book.Pages, 100);
            Assert.AreEqual(book.Isbn13, "9876543219876");
        }
    }
}
