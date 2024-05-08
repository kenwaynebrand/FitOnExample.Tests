using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FitOnExample.Tests
{
    public class RelationshipTests
    {
        [Fact]
        public void AddFriend_CanAdd()
        {
            // Arrange
            List<string> expected = new List<string>();
            expected.Add("Mary");

            // Act
            bool actual = Relationships.AddFriend("Ken", "Mary");

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void AddFriend_DoesAdd()
        {
            // Arrange
            List<string> expected = new List<string>();
            expected.Add("Mary");

            // Act
            Relationships.AddFriend("Ken", "Mary");
            List<string> actual = Relationships.ListDirectFriends("Ken");

            // Assert
            Assert.Equal(expected, actual);
        }



    }
}

