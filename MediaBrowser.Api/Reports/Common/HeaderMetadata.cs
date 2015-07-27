using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaBrowser.Api.Reports
{
	public enum HeaderMetadata
	{
		None,
		Name,
		PremiereDate,
		DateAdded,
		ReleaseDate,
		Runtime,
		PlayCount,
		Season,
		SeasonNumber,
		Series,
		Network,
		Year,
		ParentalRating,
		CommunityRating,
		Trailers,
		Specials,
		GameSystem,
		Players,
		AlbumArtist,
		Album,
		Disc,
		Track,
		Audio,
		EmbeddedImage,
		Video,
		Resolution,
		Subtitles,
		Genres,
		Countries,
        Status,
		Tracks,
		EpisodeSeries,
		EpisodeSeason,
		AudioAlbumArtist,
		MusicArtist,
		AudioAlbum,
        Locked,
        Unidentified,
        ImagePrimary,
        ImageBackdrop,
        ImageLogo,

        //Activity logs
        Overview,
        ShortOverview,
        Type,
        Date,
        UserPrimaryImage,
        Severity,
        Item,
        User,
        UserId
	}
}
