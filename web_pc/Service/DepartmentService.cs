﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_pc.Data;
using web_pc.Models;
using Microsoft.EntityFrameworkCore;

namespace web_pc.Service
{
    public class DepartmentService
    {
        private readonly web_pcContext _context;
        public DepartmentService(web_pcContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
