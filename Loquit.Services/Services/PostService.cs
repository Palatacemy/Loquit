﻿using AutoMapper;
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
    public class PostService : IPostService
    {
        private readonly ICrudRepository<Post> _postRepository;
        private readonly IMapper _mapper;
        public PostService(ICrudRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task AddPostAsync(PostDTO model)
        {
            var post = _mapper
                .Map<Post>(model);

            await _postRepository.AddAsync(post);
        }

        public async Task DeletePostByIdAsync(int id)
        {
            await _postRepository.DeleteByIdAsync(id);
        }

        public async Task<PostDTO> GetPostByIdAsync(int id)
        {
            var post = await _postRepository.GetByIdAsync(id);
            return _mapper.Map<PostDTO>(post);
        }

        public async Task<List<PostDTO>> GetPostsAsync()
        {
            var posts = (await _postRepository.GetAllAsync())
                .ToList();
            return _mapper.Map<List<PostDTO>>(posts);
        }

        public async Task<List<PostDTO>> GetPostsWithTitleAsync(string title)
        {
            var posts = (await _postRepository.GetAsync(item => item.Title == title))
                .ToList();
            return _mapper.Map<List<PostDTO>>(posts);
        }

        public async Task UpdatePostAsync(PostDTO model)
        {
            var post = _mapper.Map<Post>(model);
            await _postRepository.UpdateAsync(post);
        }
    }
}