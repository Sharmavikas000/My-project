using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using System.Configuration;
using System.Data.Entity;
using Repository;
using BusinessManagers;
using BusinessManagers.Interfaces;

namespace Settings
{
    public  static class StructureMap
    {
        public static void Register()
        {
           ObjectFactory.Initialize(x =>
            {
                //Opening Dbcontext instance for per web request.
                x.For<DbContext>().HybridHttpOrThreadLocalScoped().Use<DbDealer>();

                x.For(typeof(IRepository<>)).Use(typeof(EFRepository<>));

                x.For<IEmployeeManager>().Add<EmployeeManager>();
                
                //x.For<IScheduleManager>().Add<ScheduleManager>();

                //x.For<IScheduleMapper>().Add<ScheduleMapper>();

                //x.For<ISystemSetting>().Add<SystemSetting>();
            });
        }
    }
}
