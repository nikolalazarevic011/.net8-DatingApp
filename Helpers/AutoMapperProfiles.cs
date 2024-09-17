using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace api.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(d => d.Age, o => o.MapFrom(s => s.DateOfBirth.CalculateAge()))
                .ForMember(d => d.PhotoUrl, o => o.MapFrom(s => s.Photos.FirstOrDefault(x => x.IsMain)!.Url)); //!  "!" 91. Configuring AutoMapper. min 2:40. telling compiler to disregard if it's null , cuz autammper will do it for us, we know it does that

            CreateMap<Photo, PhotoDto>();
            CreateMap<Message, MessageDto>()
                        .ForMember(d => d.SenderPhotoUrl,
                            o => o.MapFrom(s => s.Sender.Photos.FirstOrDefault(x => x.IsMain)!.Url))
                        .ForMember(d => d.RecipientPhotoUrl,
                            o => o.MapFrom(s => s.Recipient.Photos.FirstOrDefault(x => x.IsMain)!.Url));

        }
    }
}