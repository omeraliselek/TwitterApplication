using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApplication.Core.Map;
using TwitterApplication.Model.Option;

namespace TwitterApplication.Map.Option
{
    public class TweetMap : CoreMap<Tweet>
    {
        public TweetMap()
        {
            ToTable("dbo.Tweet");

            Property(x => x.Content).HasMaxLength(140).IsRequired();
            Property(x => x.XSmallUserImage).IsOptional();
            Property(x => x.CruptedUserImage).IsOptional();

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Tweets)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(true);//katerorisi silinirse ürün silinsin

            HasMany(x => x.Comments)//Birden fazla Yorum olacaktır.
                .WithRequired(x => x.Tweet)//Bir Yorumun bir Üyesi olur.
                .HasForeignKey(x => x.TweetID);

            HasMany(x => x.Likes)//Birden fazla Yorum olacaktır.
               .WithRequired(x => x.Tweet)//Bir Yorumun bir Üyesi olur.
               .HasForeignKey(x => x.TweetID);



        }
    }
}
