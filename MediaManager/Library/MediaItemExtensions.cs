﻿using System.Collections.Generic;

namespace MediaManager.Library
{
    public static class MediaItemExtensions
    {
        public static IDictionary<string, object> ToDictionary(this IMediaItem mediaItem)
        {
            var mediaItemDict = new Dictionary<string, object>();
            foreach (var item in mediaItem.GetType().GetProperties())
            {
                var value = item.GetValue(mediaItem, null);
                if (value != null)
                    mediaItemDict.Add(item.Name, value);
            }
            return mediaItemDict;
        }

        public static string GetTitle(this IMediaItem mediaItem)
        {
            if (!string.IsNullOrEmpty(mediaItem.DisplayTitle))
                return mediaItem.DisplayTitle;
            else if (!string.IsNullOrEmpty(mediaItem.Title))
                return mediaItem.Title;
            else
                return "";
        }

        public static string GetContentTitle(this IMediaItem mediaItem)
        {
            if (!string.IsNullOrEmpty(mediaItem.DisplaySubtitle))
                return mediaItem.DisplaySubtitle;
            else if (!string.IsNullOrEmpty(mediaItem.Artist))
                return mediaItem.Artist;
            else if (!string.IsNullOrEmpty(mediaItem.AlbumArtist))
                return mediaItem.AlbumArtist;
            else if (!string.IsNullOrEmpty(mediaItem.Album))
                return mediaItem.Album;
            else
                return "";
        }

        public static string GetSubText(this IMediaItem mediaItem)
        {
            if (!string.IsNullOrEmpty(mediaItem.Album))
                return mediaItem.Album;
            else if (!string.IsNullOrEmpty(mediaItem.Artist))
                return mediaItem.Artist;
            else if (!string.IsNullOrEmpty(mediaItem.AlbumArtist))
                return mediaItem.AlbumArtist;
            else
                return "";
        }

        public static string GetImageUri(this IMediaItem mediaItem)
        {
            if (!string.IsNullOrEmpty(mediaItem.ImageUri))
                return mediaItem.ImageUri;
            else if (!string.IsNullOrEmpty(mediaItem.AlbumImageUri))
                return mediaItem.AlbumImageUri;
            else
                return "";
        }

        public static object GetImage(this IMediaItem mediaItem)
        {
            if (mediaItem.Image != null)
                return mediaItem.Image;
            else if (mediaItem.AlbumImage != null)
                return mediaItem.AlbumImage;
            else
                return null;
        }
    }
}
