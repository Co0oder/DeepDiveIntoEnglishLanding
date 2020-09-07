using System.Collections.Generic;
using DeepDiveIntoEnglishLanding.Interfaces;
using DeepDiveIntoEnglishLanding.Models;

namespace DeepDiveIntoEnglishLanding.Repository
{
    public class GalleryRepo : IGallery
    {
        public GalleryRepo()
        {
            
        }
        public IEnumerable<Image> GetAllImages()
        {
            throw new System.NotImplementedException();
        }

        public Image GetImageById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Image> GetRangeImages(int from, int count)
        {
            throw new System.NotImplementedException();
        }
    }
}