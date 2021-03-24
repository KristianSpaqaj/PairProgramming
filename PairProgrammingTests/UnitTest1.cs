using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairProgramming.Managers;
using PairProgramming.Model;
using System;
using System.Collections.Generic;

namespace PairProgrammingTests
{
    [TestClass]
    public class UnitTest1
    {
        private RecordManager _manager;
        [TestInitialize]
        public void Init()
        {
            _manager = new RecordManager(new List<Record>()
            {
                new Record(1,"Silver star", "Frank Valli & The Four Seasons", 362, new DateTime(1975, 11, 1)),
                new Record(2,"Heartless", "The Weeknd", 201, new DateTime(2019, 11, 27)),
                new Record(3,"Flashing Lights", "Kanye West", 237, new DateTime(2007, 11, 12)),
            });
        }
        [TestMethod]
        public void GetAll_Should_Return_3()
        {
            List<Record> results = _manager.GetAll();
            Assert.AreEqual(results.Count, 3);
        }
    }
}
