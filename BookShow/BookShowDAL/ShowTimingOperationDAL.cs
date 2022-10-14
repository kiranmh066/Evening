using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShowDAL
{
    public class ShowTimingOperationDAL
    {
        BookShowDbContext db = null;

        public ShowTimingOperationDAL(BookShowDbContext db)
        {
            this.db = db;
        }

        public string AddShowTimingDAL(ShowTiming ShowTimingObj)
        {
          /*  db = new BookShowDbContext();*/
            db.showTiming.Add(ShowTimingObj);
            db.SaveChanges();

            return "Saved";
        }
        public string UpdateShowTimingDAL(ShowTiming ShowTimingObj)
        {

           /* db = new BookShowDbContext();*/
            db.Entry(ShowTimingObj).State = EntityState.Modified;
            db.SaveChanges();

            return "Updated";
        }
        public string DeleteShowTimingDAL(int ShowTimingId)
        {

           /* db = new BookShowDbContext();*/
            ShowTiming ShowTimingObj = db.showTiming.Find(ShowTimingId);
            db.Entry(ShowTimingObj).State = EntityState.Deleted;
            db.SaveChanges();

            return "Deleted";
        }
        public List<ShowTiming> ShowAllShowTimingsDAL()
        {

            /*db = new BookShowDbContext();*/
            List<ShowTiming> ShowTimingList = db.showTiming.ToList();

            return ShowTimingList;
        }
    }
}
