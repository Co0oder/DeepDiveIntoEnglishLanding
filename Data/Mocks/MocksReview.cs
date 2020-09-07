using System.Collections.Generic;
using DeepDiveIntoEnglishLanding.Interfaces;
using DeepDiveIntoEnglishLanding.Models;

namespace DeepDiveIntoEnglishLanding.Mocks
{
    public class MocksReview : IReviews
    {
        private readonly Review _defaultReview;
        private readonly string _defaultSorce;

        public MocksReview(string defaultSorce)
        {
            _defaultSorce = defaultSorce;    
            _defaultReview = new Review
            {
                ImageSource = _defaultSorce, 
                Reviewer = "Прізвище Ім'я", 
                Text = "Тут має бути відгук. Тут має бути відгук. " + 
                "Тут має бути відгук. Тут має бути відгук. " + 
                "Тут має бути відгук. Тут має бути відгук. " + 
                "Тут має бути відгук. Тут має бути відгук. " + 
                "Тут має бути відгук. Тут має бути відгук. " + 
                "Тут має бути відгук. Тут має бути відгук."
            };
        }
        public IEnumerable<Review> GetAllReviews()
        {
            for(int i = 0; i < 10; i++)
            {
                yield return _defaultReview;
            }
        }

        public IEnumerable<Review> GetRangeReviews(int from, int count)
        {
            for(int i = 0; i < count; i++)
            {
                yield return _defaultReview;
            }
        }

        public Review GetReviewById(int id)
        {
            return _defaultReview;
        }
    }
}