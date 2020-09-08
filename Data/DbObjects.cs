using System.Linq;
using DeepDiveIntoEnglishLanding.Mocks;

namespace DeepDiveIntoEnglishLanding.Data
{
    public class DbObjects
    {
        static public void Initial(AppDbContext content)
        {
            if (!content.Images.Any())
            {
                content.Images.AddRange(new MocksGallery().GetAllImages());
            }
            if (!content.Reviews.Any())
            {
                content.Reviews.AddRange(new MocksReview().GetRangeReviews(0, 3));
            }
            content.SaveChanges();
        }
    }
}