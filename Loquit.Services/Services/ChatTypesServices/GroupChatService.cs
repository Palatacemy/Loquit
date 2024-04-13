using AutoMapper;
using Loquit.Data.Entities.ChatTypes;
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
    //service for group chats; inherits from IGroupChatService
    public class GroupChatService : IGroupChatService
    {
        private readonly ICrudRepository<GroupChat> _groupChatRepository;
        private readonly IMapper _mapper;
        public GroupChatService(ICrudRepository<GroupChat> groupChatRepository, IMapper mapper)
        {
            _groupChatRepository = groupChatRepository;
            _mapper = mapper;
        }

        //Add a group chat
        public async Task AddGroupChatAsync(GroupChatDTO model)
        {
            var groupChat = _mapper
                .Map<GroupChat>(model);

            await _groupChatRepository.AddAsync(groupChat);
        }

        //Delete a group chat by its id
        public async Task DeleteGroupChatByIdAsync(int id)
        {
            await _groupChatRepository.DeleteByIdAsync(id);
        }

        //Get a group chat by its id
        public async Task<GroupChatDTO> GetGroupChatByIdAsync(int id)
        {
            var groupChat = await _groupChatRepository.GetByIdAsync(id);
            return _mapper.Map<GroupChatDTO>(groupChat);
        }

        //Get a list of group chats
        public async Task<List<GroupChatDTO>> GetGroupChatsAsync()
        {
            var groupChats = (await _groupChatRepository.GetAllAsync())
                .ToList();
            return _mapper.Map<List<GroupChatDTO>>(groupChats);
        }

        //Update a group chat
        public async Task UpdateGroupChatAsync(GroupChatDTO model)
        {
            var groupChat = _mapper.Map<GroupChat>(model);
            await _groupChatRepository.UpdateAsync(groupChat);
        }
    }
}
