using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Net;

namespace BLL.Services
{
    public class AStudentService
    {
        public static List<StudentDTO> Get()
        {
            var data = DataAccessFactory.AStudentData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<StudentDTO>>(data);
        }

        public static StudentDTO Get(int id)
        {
            var data = DataAccessFactory.AStudentData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<StudentDTO>(data);
        }

        public static object Post(StudentDTO c)
        {
            

            var email = c.Email;

            var exemail = DataAccessFactory.SearchData().Search(email);
            

            if (!exemail)
            {
                var confiq = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<StudentDTO, Student>();
                });

                var mapper = new Mapper(confiq);

                var data = mapper.Map<Student>(c);

                data.AdmissionDate = DateTime.Now;
                data.Status = "Active";

                /*if (c.ProfilePicture != null)
                {
                    string fileExtension = Path.GetExtension(c.ProfilePicture);
                    string newFileName = $"profile_{data.ID}{fileExtension}"; 
                    string filePath = Path.Combine("~/App_Data", newFileName);

                    if (File.Exists(c.ProfilePicture))
                    {
                        File.Copy(c.ProfilePicture, filePath, true);
                        data.ProfilePicture = newFileName;
                    }
                    else
                    {
                        return new { Message = "Profile picture file does not exist" };
                    }
                }*/

                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$";

                Regex regex = new Regex(pattern);

                if (regex.IsMatch(data.Password) ==true)
                {
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(data.Password, salt);
                    data.Password = hashedPassword;
                }
                else
                {
                    return new { Message = "At least one lowercase letter, one uppercase letter, one digit, one special character && Minimum length of 8 characters" };
                }

                var Class = (DataAccessFactory.ClassData().Get(data.ClassID)).ClassName;
                var Section = (DataAccessFactory.SectionData().Get(data.SectionID)).SectionName;

                var age = DateTime.Now.Year - data.DateOfBirth.Year;

                if (age >= 12)
                {
                    return DataAccessFactory.AStudentData().Post(data);
                }
                else
                {
                    return new { Message = "Age requirement not fullfil" };
                }

            }

            else
            {
                return new {Message = "Email Exist"};
            }

            
        }

        public static bool Update(StudentDTO c)
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
            });

            var mapper = new Mapper(confiq);

            var data = mapper.Map<Student>(c);

            var exdata = DataAccessFactory.AStudentData().Get(c.ID);

            data.AdmissionDate= exdata.AdmissionDate;

            var update = DataAccessFactory.AStudentData().Update(data);
            Debugger.Break();

            return update;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.AStudentData().Delete(id);
        }
    }
}
