using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UPIWallet_CodeFirstEFCore.Models
{
    public class UPIWalletContext : DbContext
    {
        public DbSet<UPIModel> UPIModels { get; set; }
        public DbSet<TransactionModel> TransactionModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VF0EORP; Database=UPIWallet_DB; integrated security=true");
        }

    }
}
