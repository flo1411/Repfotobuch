using System;
using System.Collections.Generic;

namespace fotobuch2.Core.Services
{
    public interface IGalleryService
    {
        IEnumerable<string> GetImagePaths();
    }
}
