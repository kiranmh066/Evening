using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowDAL.Repost
{
    public interface ITheatreOpearationRepository
    {
        void AddTheatre(Theatre theatre);

        void UpdateTheatre(Theatre theatre);

        void DeleteTheatre(int theatreId);

        Theatre GetTheatreById(int theatreId);

        IEnumerable<Theatre> GetTheatres();


       /* public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Comments { get; set; }*/
    }
}
