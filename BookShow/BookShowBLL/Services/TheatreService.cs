using BookShowDAL.Repost;
using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowBLL.Services
{
    public class TheatreService
    {
        ITheatreOpearationRepository _theatreOperationRepository;


        //Unable to resolve ====>>>> Object issues
        public TheatreService(ITheatreOpearationRepository theatreOperationRepository)
        {
            _theatreOperationRepository = theatreOperationRepository;
        }

        //Add Theatre
        public void AddTheatre(Theatre theatre)
        {
            _theatreOperationRepository.AddTheatre(theatre);
        }
        //Update Theatre
        public void UpdateTheatre(Theatre theatre)
        {
            _theatreOperationRepository.UpdateTheatre(theatre);
        }

        //Delete Theatre
        public void DeleteTheatre(int theatreId)
        {
            _theatreOperationRepository.DeleteTheatre(theatreId);
        }

        //Get TheatreByID
        public Theatre GetTheatreById(int theatreId)
        {
            return _theatreOperationRepository.GetTheatreById(theatreId);
        }

        //GetTheatres
        public IEnumerable<Theatre> GetTheatre()
        {
            return _theatreOperationRepository.GetTheatres();
        }
    }
}
