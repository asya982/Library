﻿using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Abstraction
{
    public interface IRecordRepository : IRepositoryBase<Record>
    {
        ICollection<Record> GetByUserId(Guid id);

        ICollection<Record> GetByBookId(Guid bookId);
    }
}
