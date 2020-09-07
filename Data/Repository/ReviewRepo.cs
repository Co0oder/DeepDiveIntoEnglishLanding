using System.Collections.Generic;
using DeepDiveIntoEnglishLanding.Interfaces;
using DeepDiveIntoEnglishLanding.Models;

namespace DeepDiveIntoEnglishLanding.Repository
{
    public class ReviewRepo : IReviews
    {
        public ReviewRepo()
        {
            
        }
        public IEnumerable<Review> GetAllReviews()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Review> GetRangeReviews(int from, int count)
        {
            throw new System.NotImplementedException();
        }

        public Review GetReviewById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}