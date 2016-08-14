using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; } // using string because when displayed on page they are strings...
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}