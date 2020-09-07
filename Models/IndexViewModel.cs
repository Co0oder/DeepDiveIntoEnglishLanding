using System.Collections.Generic;

namespace DeepDiveIntoEnglishLanding.Models
{
    public struct IndexViewModel
    {
        public IEnumerable<Image> Gallery { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}