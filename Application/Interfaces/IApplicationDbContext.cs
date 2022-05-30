﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}
