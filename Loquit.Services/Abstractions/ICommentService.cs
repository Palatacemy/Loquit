using Loquit.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Abstractions
{
    //interface for a Comment's service
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetCommentsAsync();
        Task<CommentDTO> GetCommentByIdAsync(int id);
        Task<List<CommentDTO>> GetCommentsWithTextAsync(string text);
        Task AddCommentAsync(CommentDTO comment);
        Task DeleteCommentByIdAsync(int id);
        Task UpdateCommentAsync(CommentDTO comment);
    }
}
