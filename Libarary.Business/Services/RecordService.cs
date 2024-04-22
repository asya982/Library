using Library.Business.Abstraction;
using Library.DataAccess.Abstraction;
using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        private readonly IBookRepository _bookRepository;

        public RecordService(IBookRepository bookRepository, IRecordRepository recordRepository)
        {
            _bookRepository = bookRepository;
            _recordRepository = recordRepository;
        }
        public void Add(Record record)
        {
            _recordRepository.Add(record);
            _recordRepository.SaveChanges();
        }

        public void Delete(Record record)
        {
            _recordRepository.Delete(record);
            _recordRepository.SaveChanges();
        }

        public ICollection<Record> GetForBook(Guid bookId)
        {
            return _bookRepository.GetSingleById(bookId).Records;
        }

        public Record GetSingleById(Guid id)
        {
            return _recordRepository.GetSingleById(id);
        }

        public void Update(Record record)
        {
            _recordRepository.Update(record);
            _recordRepository.SaveChanges();
        }
    }
}
