using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Appointment_system_API.model;

namespace Appointment_system_API.Data
{
    public class Database : DbContext
    {
        public Database (DbContextOptions<Database> options)
            : base(options)
        {
        }

        public DbSet<Appointment_system_API.model.table> table { get; set; }
    }
}
