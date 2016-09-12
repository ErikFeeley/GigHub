using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IGigRepository
    {
        Gig GetGig(int gigId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(string artistId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int gigId);
        void Add(Gig gig);
    }
}