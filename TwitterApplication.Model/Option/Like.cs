using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApplication.Core.Entity;

namespace TwitterApplication.Model.Option
{
   public class Like:CoreEntity
    {
        public int LikeNumber  { get; set; }
        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid TweetID { get; set; }
        public virtual Tweet Tweet { get; set; }

        public Guid CommentID { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
