using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ModeratorService
    {
        public static List<ModeratorModel> GetAllModerator()
        {
            var config = new MapperConfiguration(c => { c.CreateMap<Moderator, ModeratorModel>(); });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ModeratorDataAccess();
            var data = mapper.Map<List<ModeratorModel>>(da.Get());
            return data;
        }


        public static ModeratorModel GetModerator(int id)
        {
            var config = new MapperConfiguration(c => { c.CreateMap<Moderator, ModeratorModel>(); });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ModeratorDataAccess();
            var data = mapper.Map<ModeratorModel>(da.Get(id));
            return data;
        }


        public static void AddModerator(ModeratorModel u)
        {
            var config = new MapperConfiguration(c => { c.CreateMap<ModeratorModel, Moderator>(); });
            var mapper = new Mapper(config);
            var data = mapper.Map<Moderator>(u);
            DataAccessFactory.ModeratorDataAccess().Add(data);
        }

        public static void EditModerator(ModeratorModel u)
        {
            var config = new MapperConfiguration(c => { c.CreateMap<ModeratorModel, Moderator>(); });
            var mapper = new Mapper(config);
            var data = mapper.Map<Moderator>(u);
            DataAccessFactory.ModeratorDataAccess().Edit(data);
        }

        public static void DeleteModerator(int id)
        {
            DataAccessFactory.ModeratorDataAccess().Delete(id);
        }
    }
}