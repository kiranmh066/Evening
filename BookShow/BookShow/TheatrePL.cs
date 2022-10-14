using BookShowDAL;
using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShow
{
    public class TheatrePL
    {
        public void TheatreMenuPL()
        {
            Console.WriteLine(
                "Enter 1 to Add Theatre \n" +
                "Enter 2 to Update Theatre \n" +
                "Enter 3 to Delete Theatre \n " +
                "Enter 4 to Show All Theatre \n"+
                "Enter  to Exit"
                );

            int enter = Convert.ToInt32(Console.ReadLine());
            TheatrePL theatrePLObj = new TheatrePL();

            switch (enter)
            {
                case 1:
                    theatrePLObj.AddTheatrePL();
                    theatrePLObj.TheatreMenuPL();
                    break;
                case 2:
                    theatrePLObj.UpdateTheatrePL();
                    theatrePLObj.TheatreMenuPL();
                    break;
                case 3:
                    theatrePLObj.DeleteTheatrePL();
                    theatrePLObj.TheatreMenuPL();
                    break;
                case 4:
                    theatrePLObj.ShowAllTheatresPL();
                    theatrePLObj.TheatreMenuPL();
                    break;
                default:
                    Console.WriteLine("Better Luck Next Time :)");
                    break;
            }
        }
        public void AddTheatrePL()
        {
            TheatreOperationDAL TheatreOperationDALObj = new TheatreOperationDAL();
            Theatre theatreObj = new Theatre();

            Console.WriteLine("Enter TheatreName: ");
            theatreObj.Name = Console.ReadLine();
            Console.WriteLine("Enter Theatre Address: ");
            theatreObj.Address = Console.ReadLine();
            Console.WriteLine("Enter Theatre Comments: ");
            theatreObj.Comments = Console.ReadLine();

            string msg = TheatreOperationDALObj.AddTheatreDAL(theatreObj);
            Console.WriteLine(msg);
        }

        public void UpdateTheatrePL()
        {
            TheatreOperationDAL TheatreOperationDALObj = new TheatreOperationDAL();
            Theatre TheatreObj = new Theatre();

            Console.WriteLine("Enter Theatre Id: ");
            TheatreObj.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Theatre Name: ");
            TheatreObj.Name = Console.ReadLine();
            Console.WriteLine("Enter Theatre Address: ");
            TheatreObj.Address = Console.ReadLine();
            Console.WriteLine("Enter Theatre Comments: ");
            TheatreObj.Comments = Console.ReadLine();

            string msg = TheatreOperationDALObj.UpdateTheatreDAL(TheatreObj);
            Console.WriteLine(msg);
        }

        public void DeleteTheatrePL()
        {

            TheatreOperationDAL TheatreOperationDALObj = new TheatreOperationDAL();
            //Theatre TheatreObj = new Theatre();

            Console.WriteLine("Enter TheatreId: ");
            int TheatreId = Convert.ToInt32(Console.ReadLine());

            string msg = TheatreOperationDALObj.DeleteTheatreDAL(TheatreId);
            Console.WriteLine(msg);
        }


        public void ShowAllTheatresPL()
        {
            TheatreOperationDAL TheatreOperationDALObj = new TheatreOperationDAL();
            List<Theatre> TheatreList = TheatreOperationDALObj.ShowAllTheatresDAL();

            foreach (var item in TheatreList)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Description: " + item.Address);
                Console.WriteLine("Type: " + item.Comments);
            }
        }
    }
}
