using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Data;
using tester1.IServices;
using tester1.Models;

namespace tester1.Services
{
    public class SleepingQuantityRepos : GenericRepos<SleepingQuantity> , ISleepingQuantityRepos
    {
        public SleepingQuantityRepos(ApplicationDbContext context) : base(context)
        {

        }
    }
}
