using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ServiceAdmin
{
    public class SNoteService
    {
        public static List<NoteDTO> Get()
        {
            var data = DataAccessFactory.NoteData().Get();

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Note, NoteDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<List<NoteDTO>>(data);
        }

        public static NoteDTO Get(int id)
        {
            var data = DataAccessFactory.NoteData().Get(id);

            var confiq = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Note, NoteDTO>();
            });

            var mapper = new Mapper(confiq);

            return mapper.Map<NoteDTO>(data);
        }

    }
}