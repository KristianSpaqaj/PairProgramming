using PairProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PairProgramming.Managers
{
    public class RecordManager
    {
        private List<Record> Data;
        public static int _nextId = 1;

        public RecordManager(List<Record> data)
        {
            Data = data;
            _nextId = data.OrderByDescending((r) => r.Id).First().Id;
        }


        public List<Record> GetAll(string title, string artist, int? duration, DateTime? date)
        {
            return Data
                .Where(r => title == null ? true : r.Title.Contains(title))
                .Where(r => artist == null ? true : r.Artist.Contains(artist))
                .Where(r => duration == null ? true : r.Duration < duration)
                .Where(r => date == null ? true : r.ReleaseDate < date)
                .ToList();
        }

        public Record GetById(int id)
        {
            return Data.Find((record) => record.Id == id);
        }

        public Record Add(Record value) 
        {
            value.Id = ++_nextId;
            Data.Add(value);
            return value;
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