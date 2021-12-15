using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranThiLanAnh114.Models;
namespace TranThiLanAnh114.Data{

    public class LanAnhDBContext : DbContext
    {
        public LanAnhDBContext (DbContextOptions<LanAnhDBContext> options)
            : base(options)
        {
        }

        public DbSet<TranThiLanAnh114.Models.UniversityTTLA114> UniversityTTLA114 { get; set; }
    }
}
