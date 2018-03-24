﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Person : Item
    {
        public ICollection<SocialMediaProfile> socialMediaProfiles { get; set; }

        public Organization Organization { get; set; }
    }
}