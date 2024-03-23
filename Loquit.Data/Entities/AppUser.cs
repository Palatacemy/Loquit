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
            Comments = new HashSet<Comment>();

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Description { get; set; }
        public string ProfilePictureUrl { get; set; }
        public ICollection<BaseChat>? Chats { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Post>? SavedPosts { get; set; }
        public ICollection<Post>? LikedPosts { get; set; }
        public ICollection<Post>? DislikedPosts { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public int? FriendsIds { get; set; }
        public int? BlacklistIds { get; set; }
    }
}
