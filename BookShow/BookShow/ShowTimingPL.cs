using BookShowDAL;
using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShow
{
    public class ShowTimingPL
    {
        public void ShowTimingMenuPL()
        {
            
            Console.WriteLine(
                "Enter 1 to Add ShowTiming \n" +
                "Enter 2 to Update ShowTiming \n" +
                "Enter 3 to Delete ShowTiming \n " +
                "Enter 4 to Show All ShowTiming \n" +
                "Enter  to Exit"
                );

            int enter = Convert.ToInt32(Console.ReadLine());
            ShowTimingPL ShowTimingPLObj = new ShowTimingPL();

            switch (enter)
            {
                case 1:
                    ShowTimingPLObj.AddShowTimingPL();
                    ShowTimingPLObj.ShowTimingMenuPL();
                    break;
                case 2:
                    ShowTimingPLObj.UpdateShowTimingPL();
                    ShowTimingPLObj.ShowTimingMenuPL();
                    break;
                case 3:
                    ShowTimingPLObj.DeleteShowTimingPL();
                    ShowTimingPLObj.ShowTimingMenuPL();
                    break;
                case 4:
                    ShowTimingPLObj.ShowAllShowTimingsPL();
                    ShowTimingPLObj.ShowTimingMenuPL();
                    break;
                default:
                    Console.WriteLine("Better Luck Next Time :)");
                    break;
            }
        }

        public void AddShowTimingPL()
        {
            ShowTimingOperationDAL ShowTimingOperationDALObj = new ShowTimingOperationDAL();
            ShowTiming ShowTimingObj = new ShowTiming();

            /*Console.WriteLine("Enter ShowTiming Id: ");
            ShowTimingObj.Id =Convert.ToInt32(Console.ReadLine());*/
            Console.WriteLine("Enter ShowTiming MovieId: ");
            ShowTimingObj.MovieId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ShowTiming TheatreId: ");
            ShowTimingObj.TheatreId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ShowTiming Time: ");
            ShowTimingObj.ShowTime = Convert.ToDateTime(Console.ReadLine());

            string msg = ShowTimingOperationDALObj.AddShowTimingDAL(ShowTimingObj);
            Console.WriteLine(msg);
        }

        public void UpdateShowTimingPL()
        {
            ShowTimingOperationDAL ShowTimingOperationDALObj = new ShowTimingOperationDAL();
            ShowTiming ShowTimingObj = new ShowTiming();

            Console.WriteLine("Enter ShowTiming Id: ");
            ShowTimingObj.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ShowTiming MovieId: ");
            ShowTimingObj.MovieId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ShowTiming TheatreId: ");
            ShowTimingObj.TheatreId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ShowTiming Time: ");
            ShowTimingObj.ShowTime = Convert.ToDateTime(Console.ReadLine());

            string msg = ShowTimingOperationDALObj.UpdateShowTimingDAL(ShowTimingObj);
            Console.WriteLine(msg);
        }

        public void DeleteShowTimingPL()
        {

            ShowTimingOperationDAL ShowTimingOperationDALObj = new ShowTimingOperationDAL();
            //ShowTiming ShowTimingObj = new ShowTiming();

            Console.WriteLine("Enter ShowTimingId: ");
            int ShowTimingId = Convert.ToInt32(Console.ReadLine());

            string msg = ShowTimingOperationDALObj.DeleteShowTimingDAL(ShowTimingId);
            Console.WriteLine(msg);
        }

        public void ShowAllShowTimingsPL()
        {
            ShowTimingOperationDAL ShowTimingOperationDALObj = new ShowTimingOperationDAL();
            List<ShowTiming> ShowTimingList = ShowTimingOperationDALObj.ShowAllShowTimingsDAL();

            foreach (var item in ShowTimingList)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.MovieId);
                Console.WriteLine("Description: " + item.TheatreId);
                Console.WriteLine("Type: " + item.ShowTime);
            }
        }


    }
}
