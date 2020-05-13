using GildedRoseRefactoringKata.Logic.ItemLogics;
using GildedRoseRefactoringKata.Logic.UpdateLogic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GildedRoseRefactoringKata.Tests.MainTest
{
    class MainTest
    {
        [Test]
        public void Main_OriginalValues_ValuesMatchingTextFromFile()
        {
            //Arrange
            string path = Path.Combine(Environment.CurrentDirectory, @"MainTest\", "TestText.txt");
            string rightText = File.ReadAllText(path);

            // Act
            Program.Main(new string[] {"smth"});

            // Assert
            Assert.AreEqual(rightText, Program.Text);
        }
    }
}
