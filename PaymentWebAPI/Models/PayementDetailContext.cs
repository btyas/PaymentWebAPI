using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentWebAPI.Models
{
    public class PayementDetailContext : DbContext
    {

        public PayementDetailContext(DbContextOptions<PayementDetailContext> options) : base(options)
        {

        }

        public DbSet<PaymentDetail>  PaymentDetails { get; set; }
    }
}
