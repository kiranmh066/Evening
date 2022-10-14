using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShowDAL
{
    public class TheatreOperationDAL
    {
        BookShowDbContext db = null;

        public TheatreOperationDAL(BookShowDbContext db)
        {
            this.db = db;
        }

        public string AddTheatreDAL(Theatre theatreObj)
        {
            /*db = new BookShowDbContext();*/
            db.theatre.Add(theatreObj);
            db.SaveChanges();

            return "Saved";
        }
        public string UpdateTheatreDAL(Theatre theatreObj)
        {

            /*db = new BookShowDbContext();*/
            db.Entry(theatreObj).State = EntityState.Modified;
            db.SaveChanges();

            return "Updated";
        }
        public string DeleteTheatreDAL(int TheatreId)
        {

            /*db = new BookShowDbContext();*/
            Theatre TheatreObj = db.theatre.Find(TheatreId);
            db.Entry(TheatreObj).State = EntityState.Deleted;
            db.SaveChanges();

            return "Deleted";
        }
        public List<Theatre> ShowAllTheatresDAL()
        {

            /*db = new BookShowDbContext();*/
            List<Theatre> TheatreList = db.theatre.ToList();

            return TheatreList;
        }
    }
}
