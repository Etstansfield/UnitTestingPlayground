using System;
using Xunit;
using UnitTestingPlayground;
using System.Collections.Generic;
using System.IO;

namespace UnitTestingPlayground.Test
{
    public class DummyCsvTest
    {
        // Data for MemberData Tests
        public static IEnumerable<object[]> Data => new List<object[]> {
           new object[] { new List<string>{"Test, Mcgee"}, "people.txt" },
           new object[] { new List<string>{"Test, Mcgee", "Test2, Test2", "Test3, Test3" }, "people.txt" }
        };

        public static IEnumerable<object[]> PeopleCsvData => new List<object[]> {
           new object[] { new List<Person>{new Person{FirstName = "Test", LastName = "Test"} }, new List<string> { "Test,Test" } },
           new object[] { new List<Person> { new Person { FirstName = "Test", LastName = "Test" }, new Person { FirstName = "Test2", LastName = "Test2" } }, new List<string> { "Test,Test", "Test2,Test2" } } 
        };


        [Fact]
        public void LoadPeople_NoFile()
        {
            string testString = "THISFILEDOESNOTEXIST.TXT";
            Assert.Throws<System.IO.FileNotFoundException>(() => DummyCsv.LoadPeople(testString));
        }

        [Theory]
        [MemberData(nameof(Data))]      // Need to user MemberData rather than Inline Data to pass lists
        public void LoadPeople_FileExists(List<string> csvLines, string filename)
        {
            // Arrange
            // need to create the file - we can delete it and tidy up afterwards
            File.WriteAllLines(filename, csvLines);

            // Act
            List<Person> loadedPeople = DummyCsv.LoadPeople(filename);

            // Assert
            Assert.Equal(csvLines.Count, loadedPeople.Count);  // check that we have loaded the same amount of people we have added

            // Cleanup
            File.Delete(filename);
        }

        [Theory]
        [MemberData(nameof(PeopleCsvData))]
        public void ConvertToCsv_Test(List<Person> People, List<string> csvLines)
        {
            // Arrange
            // Act
            List<string> ConvertedCsvLines = DummyCsv.ConvertToCsv(People);
            // Assert

            Assert.Equal(csvLines, ConvertedCsvLines);      // Xunit is smart enough to recongise collections so we don't need to do anything special
        }




    }
}
