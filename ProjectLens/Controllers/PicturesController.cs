using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace el_proyecte_grande_sprint_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {

        private readonly ILogger<PicturesController> _logger;

        private IPictureStorage _pictureStorage;
        public PicturesController(ILogger<PicturesController> logger,
            IPictureStorage pictureStorage)
        {
            _logger = logger;
            _pictureStorage = pictureStorage;
        }


        [HttpGet]
        public IEnumerable<Picture> GetAllPictures()
        {
            var pictures = _pictureStorage.GetAllPictures();
            return pictures;
        }


    }
}
