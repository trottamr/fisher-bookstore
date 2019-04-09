using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests
{
    public class BookTest
    {
        [Fact]
        public void ChangePublicationDate()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans" 
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //Act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(DateTime.Now.AddMonths(2));

            //Assert
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();
            Assert.Equal(expectedPublicationDate, actualPublicationDate);
        }

        [Fact]
        public void ChangeBookTitle()
        {
            //Arrange
            var book = new Book()
            {
                Id = 2,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans" 
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //Act
            var newBookTitle = "Design Driven by Domain";
            book.ChangeBookTitle(newBookTitle);

            //Assert
            var expectedBookTitle = newBookTitle;
            var actualBookTitle = book.Title;
            Assert.Equal(expectedBookTitle, actualBookTitle);
        }

        [Fact]
        public void ChangePublisher()
        {
            //Arrange
            var book = new Book()
            {
                Id = 2,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans" 
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //Act
            var newPublisher = "McGraw-Hill Sucks";
            book.ChangePublisher(newPublisher);

            //Assert
            var expectedPublisher = newPublisher;
            var actualPublisher = book.Publisher;
            Assert.Equal(expectedPublisher, actualPublisher);
        }
    }
}