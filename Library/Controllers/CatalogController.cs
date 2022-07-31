using Library.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class CatalogController : Controller
    {

        private readonly ILibraryAsset _libraryAsset;

        public CatalogController(ILibraryAsset libraryAsset)
        {
            _libraryAsset = libraryAsset;
        }

        public IActionResult Index()
        {
            var assetModels = _libraryAsset.GetAll();

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirector = _libraryAsset.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _libraryAsset.GetDeweyIndex(result.Id),
                    Title = result.Title,
                    Type = _libraryAsset.GetType(result.Id)
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };

            return View(model);
        }
    }
}
