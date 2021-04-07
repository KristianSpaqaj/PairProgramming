using PairProgramming.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PairProgramming.Managers
{
    public class RecordManager
    {
        private List<Record> Data;

        public RecordManager(List<Record> data)
        {
            Data = data;
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