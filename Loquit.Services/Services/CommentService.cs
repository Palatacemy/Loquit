using AutoMapper;
using Loquit.Data.Entities;
using Loquit.Data.Repositories.Abstractions;
using Loquit.Services.Abstractions;
using Loquit.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Services
{
    //service for comments; inherits from ICommentService
    public class CommentService : ICommentService
    {
        private readonly ICrudRepository<Comment> _commentRepository;
        private readonly IMapper _mapper;
        public CommentService(ICrudRepository<Comment> commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task AddCommentAsync(CommentDTO model)
        {
            var comment = _mapper
                .Map<Comment>(model);

            await _commentRepository.AddAsync(comment);
        }

        public async Task DeleteCommentByIdAsync(int id)
        {
            await _commentRepository.DeleteByIdAsync(id);
        }

        public async Task<CommentDTO> GetCommentByIdAsync(int id)
        {
            var comment = await _commentRepository.GetByIdAsync(id);
            return _mapper.Map<CommentDTO>(comment);
        }

        public async Task<List<CommentDTO>> GetCommentsAsync()
        {
            var comments = (await _commentRepository.GetAllAsync())
                .ToList();
            return _mapper.Map<List<CommentDTO>>(comments);
        }

        public async Task<List<CommentDTO>> GetCommentsWithTextAsync(string text)
        {
            var comments = (await _commentRepository.GetAsync(item => item.Text == text))
                .ToList();
            return _mapper.Map<List<CommentDTO>>(comments);
        }

        public async Task UpdateCommentAsync(CommentDTO model)
        {
            var comment = _mapper.Map<Comment>(model);
            await _commentRepository.UpdateAsync(comment);
        }
    }
}
