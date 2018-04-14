using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DBMapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            this.ToTable("States");
            this.Property(t => t.StateId);
            this.Property(t => t.StateName);
        }
    }
}
