﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5.Models
{
    public interface iBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
