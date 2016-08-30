using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaOrganizer
{
    public static class MediaFunctions
    {
        public static bool isMediaFile (string extension)
        {
            extension = extension.ToLower();
            bool result = false;

            switch (extension)
            {
                case ".jpg": result = true; break;
                case ".png": result = true; break;
                case ".mov": result = true; break;
                case ".mp4": result = true; break;
                case ".avi": result = true; break;
                case ".3gp": result = true; break;
                default: result = false; break;
            }

            return result;
        }
    }
}
