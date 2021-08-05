﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Data;
using tester1.IServices;
using tester1.Models;

namespace tester1.Services
{
    public class TipsCategoryRepos : GenericRepos<TipsCategory> , ITipsCategoryRepos
    {
        public TipsCategoryRepos(ApplicationDbContext context) : base(context)
        {

        }
    }
}
