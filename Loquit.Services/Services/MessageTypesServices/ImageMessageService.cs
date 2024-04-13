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
    //service for image messages; inherits from IImageMessageService
    public class ImageMessageService : IImageMessageService
    {
        private readonly ICrudRepository<ImageMessage> _imageMessageRepository;
        private readonly IMapper _mapper;
        public ImageMessageService(ICrudRepository<ImageMessage> imageMessageRepository, IMapper mapper)
        {
            _imageMessageRepository = imageMessageRepository;
            _mapper = mapper;
        }

        //Add an image message
        public async Task AddImageMessageAsync(ImageMessageDTO model)
        {
            var imageMessage = _mapper
                .Map<ImageMessage>(model);

            await _imageMessageRepository.AddAsync(imageMessage);
        }

        //Delete an image message by its id
        public async Task DeleteImageMessageByIdAsync(int id)
        {
            await _imageMessageRepository.DeleteByIdAsync(id);
        }

        //Get an image message by its id
        public async Task<ImageMessageDTO> GetImageMessageByIdAsync(int id)
        {
            var imageMessage = await _imageMessageRepository.GetByIdAsync(id);
            return _mapper.Map<ImageMessageDTO>(imageMessage);
        }

        //Get a list of image messages
        public async Task<List<ImageMessageDTO>> GetImageMessagesAsync()
        {
            var imageMessages = (await _imageMessageRepository.GetAllAsync())
                .ToList();
            return _mapper.Map<List<ImageMessageDTO>>(imageMessages);
        }

        //Update an image message
        public async Task UpdateImageMessageAsync(ImageMessageDTO model)
        {
            var imageMessage = _mapper.Map<ImageMessage>(model);
            await _imageMessageRepository.UpdateAsync(imageMessage);
        }
    }
}
