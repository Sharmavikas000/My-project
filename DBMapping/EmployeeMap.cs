using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity.ModelConfiguration;


namespace DBMapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            this.ToTable("Employee");
            //this.Property(t => t.EmpId);
            this.Property(t => t.Empname);
            this.Property(t => t.EmpSal);
            this.Property(t => t.EmpCity);
            

        }
    }
}
