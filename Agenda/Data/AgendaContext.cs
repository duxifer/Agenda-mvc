﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Models
{
    public class AgendaContext : DbContext
    {
        public AgendaContext (DbContextOptions<AgendaContext> options)
            : base(options)
        {
        }

        public DbSet<Agenda.Models.Registro> Registro { get; set; }
    }
}
