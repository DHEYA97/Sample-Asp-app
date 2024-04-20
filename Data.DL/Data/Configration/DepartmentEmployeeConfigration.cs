using Data.DL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DL.Data.Configration
{
    internal class DepartmentEmployeeConfigration : IEntityTypeConfiguration<DepartmentEmployee>
    {
        public void Configure(EntityTypeBuilder<DepartmentEmployee> builder)
        {
            builder.HasKey(e => new { e.DepartmentId , e.EmployeeId});
        }
    }
}
