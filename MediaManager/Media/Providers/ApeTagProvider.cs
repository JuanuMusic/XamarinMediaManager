﻿using System.Threading.Tasks;
using MediaManager.Library;

namespace MediaManager.Media
{
    public class ApeTagProvider : IMediaItemMetadataProvider
    {
        public Task<IMediaItem> ProvideMetadata(IMediaItem mediaItem)
        {
            return null;
        }
    }
}
