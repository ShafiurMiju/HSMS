using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;

namespace BLL.Services
{
    public class NoteService
    {
        private static IMapper _mapper;

        static NoteService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Note, NoteDTO>();
                cfg.CreateMap<NoteDTO, Note>();
            });

            _mapper = config.CreateMapper();
        }

        public static List<NoteDTO> Get()
        {
            var data = DataAccessFactory.NoteData().Get();
            return _mapper.Map<List<NoteDTO>>(data);
        }

        public static NoteDTO Get(int id)
        {
            var data = DataAccessFactory.NoteData().Get(id);
            return _mapper.Map<NoteDTO>(data);
        }

        public static bool Post(NoteDTO noteDTO, Stream fileStream, string fileName)
        {
            var note = _mapper.Map<Note>(noteDTO);
            note.NoteFile = SaveFile(fileStream, fileName);
            return DataAccessFactory.NoteData().Post(note);
        }

        public static bool Update(NoteDTO noteDTO, Stream fileStream, string fileName)
        {
            var note = _mapper.Map<Note>(noteDTO);
            var existingNote = DataAccessFactory.NoteData().Get(note.ID);
            if (existingNote != null)
            {
                DeleteFile(existingNote.NoteFile);
                note.NoteFile = SaveFile(fileStream, fileName);
                return DataAccessFactory.NoteData().Update(note);
            }
            return false;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.NoteData().Get(id);
            if (data != null)
            {
                DeleteFile(data.NoteFile);
                return DataAccessFactory.NoteData().Delete(id);
            }
            return false;
        }

        private static string SaveFile(Stream fileStream, string fileName)
        {
            string filePath = Path.Combine("~App_Data", fileName);
            using (var file = File.Create(filePath))
            {
                fileStream.CopyTo(file);
            }
            return fileName;
        }

        private static void DeleteFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                string filePath = Path.Combine("~App_Data", fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }
    }
}
