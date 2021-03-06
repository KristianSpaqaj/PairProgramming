using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgramming.Managers;
using PairProgramming.Model;
using System;
using System.Collections.Generic;

namespace PairProgrammingTests
{
    [TestClass]
    public class BackendTests
    {
        private RecordManager _manager;
        [TestInitialize]
        public void Init()
        {
            _manager = new RecordManager(new List<Record>()
            {
                new Record(1,"Silver star", "Frank Valli & The Four Seasons", 362, 1975),
                new Record(2,"Heartless", "The Weeknd", 201, 2019),
                new Record(3,"Flashing Lights", "Kanye West", 237, 2007),
            });
        }
        [TestMethod]
        public void GetAll_Should_Return_3()
        {
            List<Record> results = _manager.GetAll(null,null,null,null);
            Assert.AreEqual(results.Count, 3);
        }

        [TestMethod]
        public void GetAll_Duration_ShouldFilterShorterDurationsOut()
        {
            int duration = 250;
            List<Record> result = _manager.GetAll(null, null, duration, null);
            Record shorterDurationRecord = result.Find(r => r.Duration > duration);
            Assert.IsTrue(shorterDurationRecord == null);
        }

       [TestMethod]
       public void Add()
        {
            //Record r = new Record(5, "I Wonder Why", "Dion and the belmonts", 121, new DateTime(1959, 1, 1));
            Record r = new Record() {Title = "I Wonder Why", Artist = "Dion an the Belmonts", Duration = 121, ReleaseDate = 1959 };
            Record added = _manager.Add(r);
            Assert.AreEqual(4, added.Id);
        }
    }
}
