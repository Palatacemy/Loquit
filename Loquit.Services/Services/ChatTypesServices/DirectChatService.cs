using AutoMapper;
using Loquit.Data.Entities.ChatTypes;
using Loquit.Data.Migrations;
using Loquit.Data.Repositories.Abstractions;
using Loquit.Services.Abstractions.ChatTypesAbstractions;
using Loquit.Services.DTOs.ChatTypesDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Services.ChatTypesServices
{
    //service for direct chats; inherits from IDirectChatService
    public class DirectChatService : IDirectChatService
    {
        private readonly ICrudRepository<DirectChat> _directChatRepository;
        private readonly IMapper _mapper;
        public DirectChatService(ICrudRepository<DirectChat> directChatRepository, IMapper mapper)
        {
            _directChatRepository = directChatRepository;
            _mapper = mapper;
        }

        //Add a direct chat
        public async Task AddDirectChatAsync(DirectChatDTO model)
        {
            var directChat = _mapper
                .Map<DirectChat>(model);

            await _directChatRepository.AddAsync(directChat);
        }

        //Delete a direct chat by its id
        public async Task DeleteDirectChatByIdAsync(int id) 
        {
            await _directChatRepository.DeleteByIdAsync(id); 
        }

        //Get a direct chat by its id
        public async Task<DirectChatDTO> GetDirectChatByIdAsync(int id)
        {
            var directChat = await _directChatRepository.GetByIdAsync(id);
            return _mapper.Map<DirectChatDTO>(directChat);
        }

        //Get a list of direct chats
        public async Task<List<DirectChatDTO>> GetDirectChatsAsync()
        {
            var directChats = (await _directChatRepository.GetAllAsync())
                .ToList();
            return _mapper.Map<List<DirectChatDTO>>(directChats);
        }

        //Update a direct chat
        public async Task UpdateDirectChatAsync(DirectChatDTO model)
        {
            var directChat = _mapper.Map<DirectChat>(model);
            await _directChatRepository.UpdateAsync(directChat);
        }
    }
}
