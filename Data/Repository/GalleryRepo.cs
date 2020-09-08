using System.Collections.Generic;
using DeepDiveIntoEnglishLanding.Data;
using DeepDiveIntoEnglishLanding.Interfaces;
using DeepDiveIntoEnglishLanding.Models;
using System.Linq;

namespace DeepDiveIntoEnglishLanding.Repository
{
    public class GalleryRepo : IGallery
    {
        private readonly AppDbContext _context;

        public GalleryRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Image> GetAllImages()
        {
            return _context.Images;
        }

        public Image GetImageById(int id)
        {
            return _context.Images.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Image> GetRangeImages(int from, int count)
        {
            return _context.Images.Where(img => img.Id > from && img.Id < from + count);
        }
    }
}