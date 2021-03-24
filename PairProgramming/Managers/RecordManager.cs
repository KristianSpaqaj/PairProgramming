using PairProgramming.Model;
using System;
using System.Collections.Generic;

namespace PairProgramming.Managers
{
    public class RecordManager
    {
        private List<Record> Data;

        public RecordManager(List<Record> data)
        {
            Data = data;
        }

        public List<Record> GetAll()
        {
            return Data;
        }

        public Record GetById(int id)
        {
            return Data.Find((record) => record.Id == id);
        }

        public Record Add(Record value)
        {
            throw new NotImplementedException();
        }

        public Record Update(int id, Record value)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}