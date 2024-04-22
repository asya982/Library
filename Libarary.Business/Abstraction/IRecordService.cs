using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstraction
{
    public interface IRecordService
    {
        Record GetSingleById(Guid id);

        ICollection<Record> GetForBook(Guid bookId);

        void Add(Record record);

        void Update(Record record);

        void Delete(Record record);
    }
}
