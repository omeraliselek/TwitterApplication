using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApplication.Core.Map;
using TwitterApplication.Model.Option;

namespace TwitterApplication.Map.Option
{
   public class LikeMap:CoreMap<Like>
    {
        public LikeMap()
        {
            ToTable("dbo.Like");
            Property(x => x.LikeNumber).IsRequired();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Likes)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(true);//Üye silinirse like silinsin

            HasRequired(x => x.Tweet)
               .WithMany(x => x.Likes)
               .HasForeignKey(x => x.TweetID)
               .WillCascadeOnDelete(true);// Üye Silinirse Beğenileri Silinsin

            HasRequired(x => x.Comment)
               .WithMany(x => x.Likes)
               .HasForeignKey(x => x.CommentID)
               .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin



        }
    }
}
