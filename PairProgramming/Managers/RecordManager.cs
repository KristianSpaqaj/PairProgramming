using PairProgramming.Model;
using System;
using System.Collections.Generic;

namespace PairProgramming.Managers
{
    internal class RecordManager
    {
        private List<Record> lists;

        public RecordManager(List<Record> lists)
        {
            this.lists = lists;
        }

        internal IEnumerable<Record> GetAll()
        {
            throw new NotImplementedException();
        }

        internal Record GetById()
        {
            throw new NotImplementedException();
        }

        internal Record Add(Record value)
        {
            throw new NotImplementedException();
        }

        internal Record Update(int id, Record value)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}