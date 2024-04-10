using Loquit.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;

namespace Loquit.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Chats = new HashSet<BaseChat>();
            Posts = new HashSet<Post>();
            SavedPosts = new HashSet<Post>();
            LikedPosts = new HashSet<Post>();
            DislikedPosts = new HashSet<Post>();
            CategoryPreferences = [0.3, 0.3, 0.3, 0.3, 0.3, 0.3, 0.3, 0.3, 0.3];
            EvaluationPreferences = [0.3, 0.3, 0.3, 0.3, 0.3];
            AllowNsfw = false;
            ColorThemeId = 0;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Description { get; set; }
        public string ProfilePictureUrl { get; set; }
        public virtual ICollection<BaseChat>? Chats { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }
        public virtual ICollection<Post>? SavedPosts { get; set; }
        public virtual ICollection<Post>? LikedPosts { get; set; }
        public virtual ICollection<Post>? DislikedPosts { get; set; }
        public string? FriendsIds { get; set; }
        public string? BlacklistIds { get; set; }
        public double[] CategoryPreferences { get; set; }
        public double[] EvaluationPreferences { get; set; }
        public bool AllowNsfw { get; set; }
        public int ColorThemeId { get; set; }
        public virtual ICollection<string>? FriendRequestsSent { get; set; }
        public virtual ICollection<string>? FriendRequestsReceived { get; set; }
    }
}
