using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminModel> GetAllAdmin()
        {
            var config = new MapperConfiguration(c => { c.CreateMap<Admin, AdminModel>(); });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.AdminDataAccess();
            var data = mapper.Map<List<AdminModel>>(da.Get());
            return data;
        }


        public static AdminModel GetAdmin(int id)
        {
            var config = new MapperConfiguration(c => { c.CreateMap<Admin, AdminModel>(); });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.AdminDataAccess();
            var data = mapper.Map<AdminModel>(da.Get(id));
            return data;
        }

        public static void AddAdmin(AdminModel u)
        {
            var config = new MapperConfiguration(c => { c.CreateMap<UserModel, User>(); });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            DataAccessFactory.AdminDataAccess().Add(data);
        }

        public static void EditAdmin(AdminModel u)
        {
            var config = new MapperConfiguration(c => { c.CreateMap<UserModel, User>(); });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            object p = DataAccessFactory.AdminDataAccess().Edit(data);
        }

        public static void DeleteAdmin(int id)
        {
            DataAccessFactory.AdminDataAccess().Delete(id);
        }
    }
}