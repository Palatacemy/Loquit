﻿using Loquit.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Data.Repositories.Abstractions
{
    public interface IPostRepository : ICrudRepository<Post>
    {
        public Task AddComment(Comment comment, List<Comment> Comments);
    }
}