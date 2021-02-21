using Assignment1.Data;
using Assignment1.Dtos;
using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.Managers
{
    public class HomeManager
    {
        public List<HomeDto> Get()
        {
            using (var context = new AssignmentContext())
            {
                var result = context.Set<NoteModel>().Where(a => a.IsDeleted == false).Select(a => new HomeDto
                {
                    Content = a.Content,
                    DateCre = a.DateCre,
                    DateMod = a.DateMod,
                    Title = a.Title,
                    Id = a.Id
                }).ToList();

                return result;
            }
        }

        public HomeDto GetDetails(int id)
        {
            using (var context = new AssignmentContext())
            {
                var noteItem = context.Set<NoteModel>().Find(id);
                return new HomeDto
                {
                    Id = noteItem.Id,
                    Title = noteItem.Title,
                    Content = noteItem.Content,
                    DateCre = noteItem.DateCre,
                    DateMod = noteItem.DateMod
                };
            }
        }

        public void AddNote(HomeDto model)
        {
            using (var context = new AssignmentContext())
            {
                context.Set<NoteModel>().Add(new NoteModel
                {
                    Title = model.Title,
                    Content = model.Content,
                    DateCre = DateTime.Now
                });

                context.SaveChanges();
            }
        }

        public void EditNote(HomeDto model)
        {
            using (var context = new AssignmentContext())
            {
                context.Set<NotePreviousVersion>().Add(new NotePreviousVersion
                {
                    NoteModelId = model.Id,
                    ModificationDate = DateTime.Now,
                    Version = Guid.NewGuid().ToString()
                });

                var note = context.Set<NoteModel>().Find(model.Id);

                note.Title = model.Title;
                note.Content = model.Content;
                note.DateMod = DateTime.Now;

                context.SaveChanges();
            }
        }

        public void RemoveNote(int id)
        {
            using (var context = new AssignmentContext())
            {
                var model = context.Set<NoteModel>().Find(id);

                model.IsDeleted = true;

                context.SaveChanges();
            }
        }
        public HomeDto GetEditDetails(int id)
        {
            using (var context = new AssignmentContext())
            {
                var noteItem = context.Set<NoteModel>().Find(id);
                return new HomeDto
                {

                    Title = noteItem.Title,
                    Content = noteItem.Content,
                    DateCre = noteItem.DateCre,

                };
            }
        }
    }
       
}