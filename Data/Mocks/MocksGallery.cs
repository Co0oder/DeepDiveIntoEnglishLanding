using System.Collections.Generic;
using DeepDiveIntoEnglishLanding.Interfaces;
using DeepDiveIntoEnglishLanding.Models;

namespace DeepDiveIntoEnglishLanding.Mocks
{
    public class MocksGallery : IGallery
    {
        private readonly string _defaultSorce;

        public MocksGallery(string defaultSorce)
        {
            _defaultSorce = defaultSorce;       
        }
        public IEnumerable<Image> GetAllImages()
        {
            for(int i = 0; i < 10; i++)
            {
                yield return new Image{Source = _defaultSorce};
            } 
        }

        public Image GetImageById(int id)
        {
            return new Image{Source = _defaultSorce};
        }

        public IEnumerable<Image> GetRangeImages(int from, int count)
        {
            for(int i = 0; i < count; i++)
            {
                yield return new Image{Source = _defaultSorce};
            } 
        }
    }
}