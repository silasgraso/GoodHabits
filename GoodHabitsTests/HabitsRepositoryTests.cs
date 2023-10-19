using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoodHabits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace GoodHabits.Tests
{
    [TestClass()]
    public class HabitsRepositoryTests
    {
        [TestMethod()]
        public void HabitsRepositoryTest()
        {
            HabitsRepository habitsRepository = new HabitsRepository();
            Assert.IsNotNull(habitsRepository);
            Assert.AreEqual(2, habitsRepository.Read().Count());
        }

        [TestMethod()]
        public void CreateTest()
        {
            Habit habit = new Habit() {Name = "Wash your towel", Frequency = 14 };
            HabitsRepository habitsRepository = new HabitsRepository();
            Habit newHabit = habitsRepository.Create(habit);

            Assert.IsNotNull(newHabit);
            Assert.AreEqual(3, habitsRepository.Read().Count());
            Assert.AreEqual("Wash your towel", newHabit.Name);

            Habit habitNullName = new Habit() { Name=null , Frequency = 14 };
            Assert.ThrowsException<ArgumentNullException>(() => habitsRepository.Create(habitNullName));

            Habit habitShortName = new Habit() { Name = "A", Frequency = 14 };
            Assert.ThrowsException<ArgumentException>(() => habitsRepository.Create(habitShortName));




        }

        [TestMethod()]
        public void ReadTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReadByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}