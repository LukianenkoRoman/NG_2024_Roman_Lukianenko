using AutoMapper;
using Epic5_Task1.BLL.Models.GetEntityModels;
using DataLayer.Entities;

namespace Epic5_Task1.BLL.Mapping
{
    public class AutomapperBLL : Profile
    {
        public AutomapperBLL() 
        {
            CreateMap<Category, CategoryModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.description,
                    opt => opt.MapFrom(src => src.description)).ReverseMap();

            CreateMap<Client, ClientModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.phone,
                    opt => opt.MapFrom(src => src.phone)).ReverseMap();

            CreateMap<Employer, EmployerModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.phone,
                    opt => opt.MapFrom(src => src.phone))
                .ForMember(
                    dest => dest.position,
                    opt => opt.MapFrom(src => src.position))
                .ForMember(
                    dest => dest.selery,
                    opt => opt.MapFrom(src => src.selery))
                .ForMember(
                    dest => dest.storageId,
                    opt => opt.MapFrom(src => src.storageId)).ReverseMap();

            CreateMap<Item, ItemModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.senderId,
                    opt => opt.MapFrom(src => src.senderId))
                .ForMember(
                    dest => dest.reciverId,
                    opt => opt.MapFrom(src => src.reciverId))
                .ForMember(
                    dest => dest.weight,
                    opt => opt.MapFrom(src => src.weight))
                .ForMember(
                    dest => dest.description,
                    opt => opt.MapFrom(src => src.description))
                .ForMember(
                    dest => dest.storageId,
                    opt => opt.MapFrom(src => src.storageId)).ReverseMap();

            CreateMap<Manager, ManagerModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name)).ReverseMap();

            CreateMap<Storage, StorageModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(
                    dest => dest.adress,
                    opt => opt.MapFrom(src => src.adress))
                .ForMember(
                    dest => dest.no,
                    opt => opt.MapFrom(src => src.no))
                .ForMember(
                    dest => dest.directorId,
                    opt => opt.MapFrom(src => src.directorId)).ReverseMap();
        }
    }
}
