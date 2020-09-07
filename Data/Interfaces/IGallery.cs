using System.Collections.Generic;
using DeepDiveIntoEnglishLanding.Models;

namespace DeepDiveIntoEnglishLanding.Interfaces
{
    public interface IGallery
    {
        IEnumerable<Image> GetAllImages();
        IEnumerable<Image> GetRangeImages(int from, int count);
        Image GetImageById(int id);
    }
}