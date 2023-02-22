using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class PictureCoverFound
    {
        private readonly PictureServices _pictureServices;

        public PictureCoverFound(PictureServices pictureServices)
        {
            _pictureServices = pictureServices;
        }


        public Picture? GetPictureForCoverId(int? pictureId)
        {
            if (pictureId == null) return null;
            Picture? selectedPicture = _pictureServices.GetPictureForId(pictureId.Value);
            return selectedPicture;
        }
    }
}
