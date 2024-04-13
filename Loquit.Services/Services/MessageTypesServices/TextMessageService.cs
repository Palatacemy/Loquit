using AutoMapper;
using Loquit.Data.Entities.MessageTypes;
using Loquit.Data.Repositories.Abstractions;
using Loquit.Services.Abstractions.MessageTypesAbstractions;
using Loquit.Services.DTOs.MessageTypesDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loquit.Services.Services.MessageTypesServices
{
    //service for text messages; inherits from ITextMessageService
    public class TextMessageService : ITextMessageService
    {
        private readonly ICrudRepository<TextMessage> _textMessageRepository;
        private readonly IMapper _mapper;
        public TextMessageService(ICrudRepository<TextMessage> textMessageRepository, IMapper mapper)
        {
            _textMessageRepository = textMessageRepository;
            _mapper = mapper;
        }

        //Add a text message
        public async Task AddTextMessageAsync(TextMessageDTO model)
        {
            var textMessage = _mapper
                .Map<TextMessage>(model);

            await _textMessageRepository.AddAsync(textMessage);
        }

        //Delete a text message by its id
        public async Task DeleteTextMessageByIdAsync(int id)
        {
            await _textMessageRepository.DeleteByIdAsync(id);
        }

        //Get a text message by its id
        public async Task<TextMessageDTO> GetTextMessageByIdAsync(int id)
        {
            var textMessage = await _textMessageRepository.GetByIdAsync(id);
            return _mapper.Map<TextMessageDTO>(textMessage);
        }

        //Get a list of text messages
        public async Task<List<TextMessageDTO>> GetTextMessagesAsync()
        {
            var textMessages = (await _textMessageRepository.GetAllAsync())
                .ToList();
            return _mapper.Map<List<TextMessageDTO>>(textMessages);
        }

        //Update a text message
        public async Task UpdateTextMessageAsync(TextMessageDTO model)
        {
            var textMessage = _mapper.Map<TextMessage>(model);
            await _textMessageRepository.UpdateAsync(textMessage);
        }
    }
}
