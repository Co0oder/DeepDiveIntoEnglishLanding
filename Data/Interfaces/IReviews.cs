using System.Collections.Generic;
using DeepDiveIntoEnglishLanding.Models;

namespace DeepDiveIntoEnglishLanding.Interfaces
{
    public interface IReviews
    {
        IEnumerable<Review> GetAllReviews();
        IEnumerable<Review> GetRangeReviews(int from, int count);
        Review GetReviewById(int id);
    }
}