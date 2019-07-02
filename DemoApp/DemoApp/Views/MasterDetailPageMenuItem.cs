﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Views
{

    public class MasterDetailPageMenuItemMenuItem
    {
        public MasterDetailPageMenuItemMenuItem()
        {
            TargetType = typeof(MasterDetailPageMenuItemDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}