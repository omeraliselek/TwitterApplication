using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApplication.Core.Map;
using TwitterApplication.Model.Option;

namespace TwitterApplication.Map.Option
{
   public class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.User");

            Property(x => x.UserName).HasMaxLength(60).IsOptional();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.FirstName).HasMaxLength(50).IsOptional();
            Property(x => x.LastName).HasMaxLength(50).IsOptional();
            Property(x => x.Phone).HasMaxLength(11).IsRequired();
            Property(x => x.Email).HasMaxLength(90).IsOptional();
            Property(x => x.UserImage).IsOptional();
            Property(x => x.XSmallUserImage).IsOptional();
            Property(x => x.CruptedUserImage).IsOptional();
            Property(x => x.following).IsOptional();
            Property(x => x.followers).IsOptional();
            Property(x => x.Biography).HasMaxLength(170).IsOptional();

            HasMany(x => x.Comments)//Birden fazla Yorum olacaktır.
               .WithRequired(x => x.AppUser)//Bir Yorumun bir Üyesi olur.
               .HasForeignKey(x => x.AppUserID);

            HasMany(x => x.Likes)//Birden fazla Yorum olacaktır.
              .WithRequired(x => x.AppUser)//Bir Yorumun bir Üyesi olur.
              .HasForeignKey(x => x.AppUserID);

            HasMany(x => x.Tweets)//Birden fazla Yorum olacaktır.
             .WithRequired(x => x.AppUser)//Bir Yorumun bir Üyesi olur.
             .HasForeignKey(x => x.AppUserID);
        }
    }
    }

    

        
        


