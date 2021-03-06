using Implementation;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserTables = ModelsLibrary.MainViews.User;
namespace Implementation.Tables.MainViews.User.ModelsBuilder
{
    public class UserSignIn: IEntityTypeConfiguration<UserTables.UserSignIn>
    {
        public void Configure(EntityTypeBuilder<UserTables.UserSignIn> builder)
        { }
    }
}