﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApplication.Core.Entity;

namespace TwitterApplication.Model.Option
{
    public class Tweet: CoreEntity
    {
        public string Content { get; set; }
        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public string XSmallUserImage { get; set; }
        public string CruptedUserImage { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }

    }
}
