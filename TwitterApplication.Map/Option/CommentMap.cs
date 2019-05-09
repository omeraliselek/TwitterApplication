using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApplication.Core.Map;
using TwitterApplication.Model.Option;

namespace TwitterApplication.Map.Option
{
    public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comment");
            Property(x => x.Content).HasMaxLength(500).IsRequired();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(true);// Üye Silinirse Yorumları Silinsin

            HasRequired(x => x.Tweet)
               .WithMany(x => x.Comments)
               .HasForeignKey(x => x.TweetID)
               .WillCascadeOnDelete(true);// Üye Silinirse Yorumları Silinsin

            HasMany(x => x.Likes)//Birden fazla ürünü olacaktır.
                .WithRequired(x => x.Comment)//Bir ürünün bir kategorisi olur.
                .HasForeignKey(x => x.CommentID);

        }
    }
}
