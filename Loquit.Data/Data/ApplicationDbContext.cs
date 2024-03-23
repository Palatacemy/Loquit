using Loquit.Data.Entities;
using Loquit.Data.Entities.ChatTypes;
using Loquit.Data.Entities.MessageTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Loquit.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

            public DbSet<DirectChat> DirectChats { get; set; }
            public DbSet<GroupChat> GroupChats { get; set; }
            public DbSet<ImageMessage> ImageMessages { get; set; }
            public DbSet<TextMessage> TextMessages { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Comment> Comments { get; set; }
    }
}
