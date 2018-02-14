using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApp.Entities
{

  //public class UserMention
  //{

  //  [JsonProperty("screen_name")]
  //  public string ScreenName { get; set; }

  //  [JsonProperty("name")]
  //  public string Name { get; set; }

  //  [JsonProperty("id")]
  //  public object Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Url
  //{

  //  [JsonProperty("url")]
  //  public string url { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Thumb
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Small
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Medium2
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Large
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Sizes
  //{

  //  [JsonProperty("thumb")]
  //  public Thumb Thumb { get; set; }

  //  [JsonProperty("small")]
  //  public Small Small { get; set; }

  //  [JsonProperty("medium")]
  //  public Medium2 Medium { get; set; }

  //  [JsonProperty("large")]
  //  public Large Large { get; set; }
  //}

  //public class Medium
  //{

  //  [JsonProperty("id")]
  //  public long Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }

  //  [JsonProperty("media_url")]
  //  public string MediaUrl { get; set; }

  //  [JsonProperty("media_url_https")]
  //  public string MediaUrlHttps { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("sizes")]
  //  public Sizes Sizes { get; set; }

  //  [JsonProperty("source_status_id")]
  //  public long SourceStatusId { get; set; }

  //  [JsonProperty("source_status_id_str")]
  //  public string SourceStatusIdStr { get; set; }

  //  [JsonProperty("source_user_id")]
  //  public long SourceUserId { get; set; }

  //  [JsonProperty("source_user_id_str")]
  //  public string SourceUserIdStr { get; set; }
  //}

  //public class Entities
  //{

  //  [JsonProperty("hashtags")]
  //  public IList<object> Hashtags { get; set; }

  //  [JsonProperty("symbols")]
  //  public IList<object> Symbols { get; set; }

  //  [JsonProperty("user_mentions")]
  //  public IList<UserMention> UserMentions { get; set; }

  //  [JsonProperty("urls")]
  //  public IList<Url> Urls { get; set; }

  //  [JsonProperty("media")]
  //  public IList<Medium> Media { get; set; }
  //}

  //public class Metadata
  //{

  //  [JsonProperty("result_type")]
  //  public string ResultType { get; set; }

  //  [JsonProperty("iso_language_code")]
  //  public string IsoLanguageCode { get; set; }
  //}

  //public class Url2
  //{

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Description
  //{

  //  [JsonProperty("urls")]
  //  public IList<Url2> Urls { get; set; }
  //}

  //public class Url4
  //{

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Url3
  //{

  //  [JsonProperty("urls")]
  //  public IList<Url4> Urls { get; set; }
  //}

  //public class Entities2
  //{

  //  [JsonProperty("description")]
  //  public Description Description { get; set; }

  //  [JsonProperty("url")]
  //  public Url3 Url { get; set; }
  //}

  public class User
  {

    [JsonProperty("id")]
    public object Id { get; set; }

    [JsonProperty("id_str")]
    public string IdStr { get; set; }

    //[JsonProperty("name")]
    //public string Name { get; set; }

    [JsonProperty("screen_name")]
    public string ScreenName { get; set; }

    //[JsonProperty("location")]
    //public string Location { get; set; }

    //[JsonProperty("description")]
    //public string Description { get; set; }

    //[JsonProperty("url")]
    //public string Url { get; set; }

    //[JsonProperty("entities")]
    //public Entities2 Entities { get; set; }

    //[JsonProperty("protected")]
    //public bool Protected { get; set; }

    //[JsonProperty("followers_count")]
    //public long FollowersCount { get; set; }

    //[JsonProperty("friends_count")]
    //public long FriendsCount { get; set; }

    //[JsonProperty("listed_count")]
    //public long ListedCount { get; set; }

    //[JsonProperty("created_at")]
    //public string CreatedAt { get; set; }

    //[JsonProperty("favourites_count")]
    //public long FavouritesCount { get; set; }

    //[JsonProperty("utc_offset")]
    //public long? UtcOffset { get; set; }

    //[JsonProperty("time_zone")]
    //public string TimeZone { get; set; }

    //[JsonProperty("geo_enabled")]
    //public bool GeoEnabled { get; set; }

    //[JsonProperty("verified")]
    //public bool Verified { get; set; }

    //[JsonProperty("statuses_count")]
    //public long StatusesCount { get; set; }

    //[JsonProperty("lang")]
    //public string Lang { get; set; }

    //[JsonProperty("contributors_enabled")]
    //public bool ContributorsEnabled { get; set; }

    //[JsonProperty("is_translator")]
    //public bool IsTranslator { get; set; }

    //[JsonProperty("is_translation_enabled")]
    //public bool IsTranslationEnabled { get; set; }

    //[JsonProperty("profile_background_color")]
    //public string ProfileBackgroundColor { get; set; }

    //[JsonProperty("profile_background_image_url")]
    //public string ProfileBackgroundImageUrl { get; set; }

    //[JsonProperty("profile_background_image_url_https")]
    //public string ProfileBackgroundImageUrlHttps { get; set; }

    //[JsonProperty("profile_background_tile")]
    //public bool ProfileBackgroundTile { get; set; }

    [JsonProperty("profile_image_url")]
    public string ProfileImageUrl { get; set; }

    //[JsonProperty("profile_image_url_https")]
    //public string ProfileImageUrlHttps { get; set; }

    //[JsonProperty("profile_link_color")]
    //public string ProfileLinkColor { get; set; }

    //[JsonProperty("profile_sidebar_border_color")]
    //public string ProfileSidebarBorderColor { get; set; }

    //[JsonProperty("profile_sidebar_fill_color")]
    //public string ProfileSidebarFillColor { get; set; }

    //[JsonProperty("profile_text_color")]
    //public string ProfileTextColor { get; set; }

    //[JsonProperty("profile_use_background_image")]
    //public bool ProfileUseBackgroundImage { get; set; }

    //[JsonProperty("has_extended_profile")]
    //public bool HasExtendedProfile { get; set; }

    //[JsonProperty("default_profile")]
    //public bool DefaultProfile { get; set; }

    //[JsonProperty("default_profile_image")]
    //public bool DefaultProfileImage { get; set; }

    //[JsonProperty("following")]
    //public object Following { get; set; }

    //[JsonProperty("follow_request_sent")]
    //public object FollowRequestSent { get; set; }

    //[JsonProperty("notifications")]
    //public object Notifications { get; set; }

    //[JsonProperty("translator_type")]
    //public string TranslatorType { get; set; }

    //[JsonProperty("profile_banner_url")]
    //public string ProfileBannerUrl { get; set; }
  }

  //public class Geo
  //{

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("coordinates")]
  //  public IList<double> Coordinates { get; set; }
  //}

  //public class Coordinates
  //{

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("coordinates")]
  //  public IList<double> coordinates { get; set; }
  //}

  //public class BoundingBox
  //{

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("coordinates")]
  //  public IList<IList<IList<double>>> Coordinates { get; set; }
  //}

  //public class Attributes
  //{
  //}

  //public class Place
  //{

  //  [JsonProperty("id")]
  //  public string Id { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("place_type")]
  //  public string PlaceType { get; set; }

  //  [JsonProperty("name")]
  //  public string Name { get; set; }

  //  [JsonProperty("full_name")]
  //  public string FullName { get; set; }

  //  [JsonProperty("country_code")]
  //  public string CountryCode { get; set; }

  //  [JsonProperty("country")]
  //  public string Country { get; set; }

  //  [JsonProperty("contained_within")]
  //  public IList<object> ContainedWithin { get; set; }

  //  [JsonProperty("bounding_box")]
  //  public BoundingBox BoundingBox { get; set; }

  //  [JsonProperty("attributes")]
  //  public Attributes Attributes { get; set; }
  //}

  //public class UserMention2
  //{

  //  [JsonProperty("screen_name")]
  //  public string ScreenName { get; set; }

  //  [JsonProperty("name")]
  //  public string Name { get; set; }

  //  [JsonProperty("id")]
  //  public long Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Url5
  //{

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Thumb2
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Small2
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Medium4
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Large2
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Sizes2
  //{

  //  [JsonProperty("thumb")]
  //  public Thumb2 Thumb { get; set; }

  //  [JsonProperty("small")]
  //  public Small2 Small { get; set; }

  //  [JsonProperty("medium")]
  //  public Medium4 Medium { get; set; }

  //  [JsonProperty("large")]
  //  public Large2 Large { get; set; }
  //}

  //public class Medium3
  //{

  //  [JsonProperty("id")]
  //  public long Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }

  //  [JsonProperty("media_url")]
  //  public string MediaUrl { get; set; }

  //  [JsonProperty("media_url_https")]
  //  public string MediaUrlHttps { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("sizes")]
  //  public Sizes2 Sizes { get; set; }
  //}

  //public class Entities3
  //{

  //  [JsonProperty("hashtags")]
  //  public IList<object> Hashtags { get; set; }

  //  [JsonProperty("symbols")]
  //  public IList<object> Symbols { get; set; }

  //  [JsonProperty("user_mentions")]
  //  public IList<UserMention2> UserMentions { get; set; }

  //  [JsonProperty("urls")]
  //  public IList<Url5> Urls { get; set; }

  //  [JsonProperty("media")]
  //  public IList<Medium3> Media { get; set; }
  //}

  //public class Metadata2
  //{

  //  [JsonProperty("result_type")]
  //  public string ResultType { get; set; }

  //  [JsonProperty("iso_language_code")]
  //  public string IsoLanguageCode { get; set; }
  //}

  //public class Url7
  //{

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Url6
  //{

  //  [JsonProperty("urls")]
  //  public IList<Url7> Urls { get; set; }
  //}

  //public class Url8
  //{

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Description2
  //{

  //  [JsonProperty("urls")]
  //  public IList<Url8> Urls { get; set; }
  //}

  //public class Entities4
  //{

  //  [JsonProperty("url")]
  //  public Url6 Url { get; set; }

  //  [JsonProperty("description")]
  //  public Description2 Description { get; set; }
  //}

  //public class User2
  //{

  //  [JsonProperty("id")]
  //  public object Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("name")]
  //  public string Name { get; set; }

  //  [JsonProperty("screen_name")]
  //  public string ScreenName { get; set; }

  //  [JsonProperty("location")]
  //  public string Location { get; set; }

  //  [JsonProperty("description")]
  //  public string Description { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("entities")]
  //  public Entities4 Entities { get; set; }

  //  [JsonProperty("protected")]
  //  public bool Protected { get; set; }

  //  [JsonProperty("followers_count")]
  //  public long FollowersCount { get; set; }

  //  [JsonProperty("friends_count")]
  //  public long FriendsCount { get; set; }

  //  [JsonProperty("listed_count")]
  //  public long ListedCount { get; set; }

  //  [JsonProperty("created_at")]
  //  public string CreatedAt { get; set; }

  //  [JsonProperty("favourites_count")]
  //  public long FavouritesCount { get; set; }

  //  [JsonProperty("utc_offset")]
  //  public long? UtcOffset { get; set; }

  //  [JsonProperty("time_zone")]
  //  public string TimeZone { get; set; }

  //  [JsonProperty("geo_enabled")]
  //  public bool GeoEnabled { get; set; }

  //  [JsonProperty("verified")]
  //  public bool Verified { get; set; }

  //  [JsonProperty("statuses_count")]
  //  public long StatusesCount { get; set; }

  //  [JsonProperty("lang")]
  //  public string Lang { get; set; }

  //  [JsonProperty("contributors_enabled")]
  //  public bool ContributorsEnabled { get; set; }

  //  [JsonProperty("is_translator")]
  //  public bool IsTranslator { get; set; }

  //  [JsonProperty("is_translation_enabled")]
  //  public bool IsTranslationEnabled { get; set; }

  //  [JsonProperty("profile_background_color")]
  //  public string ProfileBackgroundColor { get; set; }

  //  [JsonProperty("profile_background_image_url")]
  //  public string ProfileBackgroundImageUrl { get; set; }

  //  [JsonProperty("profile_background_image_url_https")]
  //  public string ProfileBackgroundImageUrlHttps { get; set; }

  //  [JsonProperty("profile_background_tile")]
  //  public bool ProfileBackgroundTile { get; set; }

  //  [JsonProperty("profile_image_url")]
  //  public string ProfileImageUrl { get; set; }

  //  [JsonProperty("profile_image_url_https")]
  //  public string ProfileImageUrlHttps { get; set; }

  //  [JsonProperty("profile_banner_url")]
  //  public string ProfileBannerUrl { get; set; }

  //  [JsonProperty("profile_link_color")]
  //  public string ProfileLinkColor { get; set; }

  //  [JsonProperty("profile_sidebar_border_color")]
  //  public string ProfileSidebarBorderColor { get; set; }

  //  [JsonProperty("profile_sidebar_fill_color")]
  //  public string ProfileSidebarFillColor { get; set; }

  //  [JsonProperty("profile_text_color")]
  //  public string ProfileTextColor { get; set; }

  //  [JsonProperty("profile_use_background_image")]
  //  public bool ProfileUseBackgroundImage { get; set; }

  //  [JsonProperty("has_extended_profile")]
  //  public bool HasExtendedProfile { get; set; }

  //  [JsonProperty("default_profile")]
  //  public bool DefaultProfile { get; set; }

  //  [JsonProperty("default_profile_image")]
  //  public bool DefaultProfileImage { get; set; }

  //  [JsonProperty("following")]
  //  public object Following { get; set; }

  //  [JsonProperty("follow_request_sent")]
  //  public object FollowRequestSent { get; set; }

  //  [JsonProperty("notifications")]
  //  public object Notifications { get; set; }

  //  [JsonProperty("translator_type")]
  //  public string TranslatorType { get; set; }
  //}

  //public class BoundingBox2
  //{

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("coordinates")]
  //  public IList<IList<IList<double>>> Coordinates { get; set; }
  //}

  //public class Attributes2
  //{
  //}

  //public class Place2
  //{

  //  [JsonProperty("id")]
  //  public string Id { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("place_type")]
  //  public string PlaceType { get; set; }

  //  [JsonProperty("name")]
  //  public string Name { get; set; }

  //  [JsonProperty("full_name")]
  //  public string FullName { get; set; }

  //  [JsonProperty("country_code")]
  //  public string CountryCode { get; set; }

  //  [JsonProperty("country")]
  //  public string Country { get; set; }

  //  [JsonProperty("contained_within")]
  //  public IList<object> ContainedWithin { get; set; }

  //  [JsonProperty("bounding_box")]
  //  public BoundingBox2 BoundingBox { get; set; }

  //  [JsonProperty("attributes")]
  //  public Attributes2 Attributes { get; set; }
  //}

  //public class Thumb3
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Small3
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Medium6
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Large3
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Sizes3
  //{

  //  [JsonProperty("thumb")]
  //  public Thumb3 Thumb { get; set; }

  //  [JsonProperty("small")]
  //  public Small3 Small { get; set; }

  //  [JsonProperty("medium")]
  //  public Medium6 Medium { get; set; }

  //  [JsonProperty("large")]
  //  public Large3 Large { get; set; }
  //}

  //public class Variant
  //{

  //  [JsonProperty("bitrate")]
  //  public long Bitrate { get; set; }

  //  [JsonProperty("content_type")]
  //  public string ContentType { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }
  //}

  //public class VideoInfo
  //{

  //  [JsonProperty("aspect_ratio")]
  //  public IList<long> AspectRatio { get; set; }

  //  [JsonProperty("duration_millis")]
  //  public long DurationMillis { get; set; }

  //  [JsonProperty("variants")]
  //  public IList<Variant> Variants { get; set; }
  //}

  //public class AdditionalMediaInfo
  //{

  //  [JsonProperty("monetizable")]
  //  public bool Monetizable { get; set; }
  //}

  //public class Medium5
  //{

  //  [JsonProperty("id")]
  //  public long Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }

  //  [JsonProperty("media_url")]
  //  public string MediaUrl { get; set; }

  //  [JsonProperty("media_url_https")]
  //  public string MediaUrlHttps { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("sizes")]
  //  public Sizes3 Sizes { get; set; }

  //  [JsonProperty("video_info")]
  //  public VideoInfo VideoInfo { get; set; }

  //  [JsonProperty("additional_media_info")]
  //  public AdditionalMediaInfo AdditionalMediaInfo { get; set; }
  //}

  //public class ExtendedEntities
  //{

  //  [JsonProperty("media")]
  //  public IList<Medium5> Media { get; set; }
  //}

  //public class RetweetedStatus
  //{

  //  [JsonProperty("created_at")]
  //  public string CreatedAt { get; set; }

  //  [JsonProperty("id")]
  //  public object Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("text")]
  //  public string Text { get; set; }

  //  [JsonProperty("truncated")]
  //  public bool Truncated { get; set; }

  //  [JsonProperty("entities")]
  //  public Entities3 Entities { get; set; }

  //  [JsonProperty("metadata")]
  //  public Metadata2 Metadata { get; set; }

  //  [JsonProperty("source")]
  //  public string Source { get; set; }

  //  [JsonProperty("in_reply_to_status_id")]
  //  public object InReplyToStatusId { get; set; }

  //  [JsonProperty("in_reply_to_status_id_str")]
  //  public object InReplyToStatusIdStr { get; set; }

  //  [JsonProperty("in_reply_to_user_id")]
  //  public object InReplyToUserId { get; set; }

  //  [JsonProperty("in_reply_to_user_id_str")]
  //  public object InReplyToUserIdStr { get; set; }

  //  [JsonProperty("in_reply_to_screen_name")]
  //  public object InReplyToScreenName { get; set; }

  //  [JsonProperty("user")]
  //  public User2 User { get; set; }

  //  [JsonProperty("geo")]
  //  public object Geo { get; set; }

  //  [JsonProperty("coordinates")]
  //  public object Coordinates { get; set; }

  //  [JsonProperty("place")]
  //  public Place2 Place { get; set; }

  //  [JsonProperty("contributors")]
  //  public object Contributors { get; set; }

  //  [JsonProperty("is_quote_status")]
  //  public bool IsQuoteStatus { get; set; }

  //  [JsonProperty("retweet_count")]
  //  public long RetweetCount { get; set; }

  //  [JsonProperty("favorite_count")]
  //  public long FavoriteCount { get; set; }

  //  [JsonProperty("favorited")]
  //  public bool Favorited { get; set; }

  //  [JsonProperty("retweeted")]
  //  public bool Retweeted { get; set; }

  //  [JsonProperty("possibly_sensitive")]
  //  public bool PossiblySensitive { get; set; }

  //  [JsonProperty("lang")]
  //  public string Lang { get; set; }

  //  [JsonProperty("extended_entities")]
  //  public ExtendedEntities ExtendedEntities { get; set; }
  //}

  //public class Thumb4
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Small4
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Medium8
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Large4
  //{

  //  [JsonProperty("w")]
  //  public long W { get; set; }

  //  [JsonProperty("h")]
  //  public long H { get; set; }

  //  [JsonProperty("resize")]
  //  public string Resize { get; set; }
  //}

  //public class Sizes4
  //{

  //  [JsonProperty("thumb")]
  //  public Thumb4 Thumb { get; set; }

  //  [JsonProperty("small")]
  //  public Small4 Small { get; set; }

  //  [JsonProperty("medium")]
  //  public Medium8 Medium { get; set; }

  //  [JsonProperty("large")]
  //  public Large4 Large { get; set; }
  //}

  //public class Variant2
  //{

  //  [JsonProperty("bitrate")]
  //  public long Bitrate { get; set; }

  //  [JsonProperty("content_type")]
  //  public string ContentType { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }
  //}

  //public class VideoInfo2
  //{

  //  [JsonProperty("aspect_ratio")]
  //  public IList<long> AspectRatio { get; set; }

  //  [JsonProperty("duration_millis")]
  //  public long DurationMillis { get; set; }

  //  [JsonProperty("variants")]
  //  public IList<Variant2> Variants { get; set; }
  //}

  //public class Url10
  //{

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }
  //}

  //public class Url9
  //{

  //  [JsonProperty("urls")]
  //  public IList<Url10> Urls { get; set; }
  //}

  //public class Description3
  //{

  //  [JsonProperty("urls")]
  //  public IList<object> Urls { get; set; }
  //}

  //public class Entities5
  //{

  //  [JsonProperty("url")]
  //  public Url9 Url { get; set; }

  //  [JsonProperty("description")]
  //  public Description3 Description { get; set; }
  //}

  //public class SourceUser
  //{

    //[JsonProperty("id")]
    //public long Id { get; set; }

    //[JsonProperty("id_str")]
    //public string IdStr { get; set; }

    //[JsonProperty("name")]
    //public string Name { get; set; }

    //[JsonProperty("screen_name")]
    //public string ScreenName { get; set; }

    //[JsonProperty("location")]
    //public string Location { get; set; }

    //[JsonProperty("description")]
    //public string Description { get; set; }

    //[JsonProperty("url")]
    //public string Url { get; set; }

    //[JsonProperty("entities")]
    //public Entities5 Entities { get; set; }

    //[JsonProperty("protected")]
    //public bool Protected { get; set; }

    //[JsonProperty("followers_count")]
    //public long FollowersCount { get; set; }

    //[JsonProperty("friends_count")]
    //public long FriendsCount { get; set; }

    //[JsonProperty("listed_count")]
    //public long ListedCount { get; set; }

    //[JsonProperty("created_at")]
    //public string CreatedAt { get; set; }

    //[JsonProperty("favourites_count")]
    //public long FavouritesCount { get; set; }

    //[JsonProperty("utc_offset")]
    //public long UtcOffset { get; set; }

    //[JsonProperty("time_zone")]
    //public string TimeZone { get; set; }

    //[JsonProperty("geo_enabled")]
    //public bool GeoEnabled { get; set; }

    //[JsonProperty("verified")]
    //public bool Verified { get; set; }

    //[JsonProperty("statuses_count")]
    //public long StatusesCount { get; set; }

    //[JsonProperty("lang")]
    //public string Lang { get; set; }

    //[JsonProperty("contributors_enabled")]
    //public bool ContributorsEnabled { get; set; }

    //[JsonProperty("is_translator")]
    //public bool IsTranslator { get; set; }

    //[JsonProperty("is_translation_enabled")]
    //public bool IsTranslationEnabled { get; set; }

  //  [JsonProperty("profile_background_color")]
  //  public string ProfileBackgroundColor { get; set; }

  //  [JsonProperty("profile_background_image_url")]
  //  public string ProfileBackgroundImageUrl { get; set; }

  //  [JsonProperty("profile_background_image_url_https")]
  //  public string ProfileBackgroundImageUrlHttps { get; set; }

  //  [JsonProperty("profile_background_tile")]
  //  public bool ProfileBackgroundTile { get; set; }

  //  [JsonProperty("profile_image_url")]
  //  public string ProfileImageUrl { get; set; }

  //  [JsonProperty("profile_image_url_https")]
  //  public string ProfileImageUrlHttps { get; set; }

  //  [JsonProperty("profile_banner_url")]
  //  public string ProfileBannerUrl { get; set; }

  //  [JsonProperty("profile_link_color")]
  //  public string ProfileLinkColor { get; set; }

  //  [JsonProperty("profile_sidebar_border_color")]
  //  public string ProfileSidebarBorderColor { get; set; }

  //  [JsonProperty("profile_sidebar_fill_color")]
  //  public string ProfileSidebarFillColor { get; set; }

  //  [JsonProperty("profile_text_color")]
  //  public string ProfileTextColor { get; set; }

  //  [JsonProperty("profile_use_background_image")]
  //  public bool ProfileUseBackgroundImage { get; set; }

  //  [JsonProperty("has_extended_profile")]
  //  public bool HasExtendedProfile { get; set; }

  //  [JsonProperty("default_profile")]
  //  public bool DefaultProfile { get; set; }

  //  [JsonProperty("default_profile_image")]
  //  public bool DefaultProfileImage { get; set; }

  //  [JsonProperty("following")]
  //  public object Following { get; set; }

  //  [JsonProperty("follow_request_sent")]
  //  public object FollowRequestSent { get; set; }

  //  [JsonProperty("notifications")]
  //  public object Notifications { get; set; }

  //  [JsonProperty("translator_type")]
  //  public string TranslatorType { get; set; }
  //}

  //public class AdditionalMediaInfo2
  //{

  //  [JsonProperty("monetizable")]
  //  public bool Monetizable { get; set; }

  //  [JsonProperty("source_user")]
  //  public SourceUser SourceUser { get; set; }
  //}

  //public class Medium7
  //{

  //  [JsonProperty("id")]
  //  public long Id { get; set; }

  //  [JsonProperty("id_str")]
  //  public string IdStr { get; set; }

  //  [JsonProperty("indices")]
  //  public IList<long> Indices { get; set; }

  //  [JsonProperty("media_url")]
  //  public string MediaUrl { get; set; }

  //  [JsonProperty("media_url_https")]
  //  public string MediaUrlHttps { get; set; }

  //  [JsonProperty("url")]
  //  public string Url { get; set; }

  //  [JsonProperty("display_url")]
  //  public string DisplayUrl { get; set; }

  //  [JsonProperty("expanded_url")]
  //  public string ExpandedUrl { get; set; }

  //  [JsonProperty("type")]
  //  public string Type { get; set; }

  //  [JsonProperty("sizes")]
  //  public Sizes4 Sizes { get; set; }

  //  [JsonProperty("source_status_id")]
  //  public long SourceStatusId { get; set; }

  //  [JsonProperty("source_status_id_str")]
  //  public string SourceStatusIdStr { get; set; }

  //  [JsonProperty("source_user_id")]
  //  public long SourceUserId { get; set; }

  //  [JsonProperty("source_user_id_str")]
  //  public string SourceUserIdStr { get; set; }

  //  [JsonProperty("video_info")]
  //  public VideoInfo2 VideoInfo { get; set; }

  //  [JsonProperty("additional_media_info")]
  //  public AdditionalMediaInfo2 AdditionalMediaInfo { get; set; }
  //}

  //public class ExtendedEntities2
  //{

  //  [JsonProperty("media")]
  //  public IList<Medium7> Media { get; set; }
  //}

  public class Status
  {

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("id")]
    public object Id { get; set; }

    [JsonProperty("id_str")]
    public string IdStr { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    //[JsonProperty("truncated")]
    //public bool Truncated { get; set; }

    //[JsonProperty("entities")]
    //public Entities Entities { get; set; }

    //[JsonProperty("metadata")]
    //public Metadata Metadata { get; set; }

    //[JsonProperty("source")]
    //public string Source { get; set; }

    //[JsonProperty("in_reply_to_status_id")]
    //public long? InReplyToStatusId { get; set; }

    //[JsonProperty("in_reply_to_status_id_str")]
    //public string InReplyToStatusIdStr { get; set; }

    //[JsonProperty("in_reply_to_user_id")]
    //public long? InReplyToUserId { get; set; }

    //[JsonProperty("in_reply_to_user_id_str")]
    //public string InReplyToUserIdStr { get; set; }

    //[JsonProperty("in_reply_to_screen_name")]
    //public string InReplyToScreenName { get; set; }

    [JsonProperty("user")]
    public User User { get; set; }

    //[JsonProperty("geo")]
    //public Geo Geo { get; set; }

    //[JsonProperty("coordinates")]
    //public Coordinates Coordinates { get; set; }

    //[JsonProperty("place")]
    //public Place Place { get; set; }

    //[JsonProperty("contributors")]
    //public object Contributors { get; set; }

    //[JsonProperty("retweeted_status")]
    //public RetweetedStatus RetweetedStatus { get; set; }

    //[JsonProperty("is_quote_status")]
    //public bool IsQuoteStatus { get; set; }

    //[JsonProperty("retweet_count")]
    //public long RetweetCount { get; set; }

    //[JsonProperty("favorite_count")]
    //public long FavoriteCount { get; set; }

    //[JsonProperty("favorited")]
    //public bool Favorited { get; set; }

    //[JsonProperty("retweeted")]
    //public bool Retweeted { get; set; }

    //[JsonProperty("possibly_sensitive")]
    //public bool PossiblySensitive { get; set; }

    //[JsonProperty("lang")]
    //public string Lang { get; set; }

    //[JsonProperty("extended_entities")]
    //public ExtendedEntities2 ExtendedEntities { get; set; }
  }

  public class SearchMetadata
  {

    [JsonProperty("completed_in")]
    public double CompletedIn { get; set; }

    [JsonProperty("max_id")]
    public long MaxId { get; set; }

    [JsonProperty("max_id_str")]
    public string MaxIdStr { get; set; }

    [JsonProperty("next_results")]
    public string NextResults { get; set; }

    [JsonProperty("query")]
    public string Query { get; set; }

    [JsonProperty("refresh_url")]
    public string RefreshUrl { get; set; }

    [JsonProperty("count")]
    public long Count { get; set; }

    [JsonProperty("since_id")]
    public long SinceId { get; set; }

    [JsonProperty("since_id_str")]
    public string SinceIdStr { get; set; }
  }

  public class TwitteSearchResult
  {
    [JsonProperty("statuses")]
    public IList<Status> Statuses { get; set; }

    [JsonProperty("search_metadata")]
    public SearchMetadata SearchMetadata { get; set; }

    public static TwitteSearchResult FormatModel(TwitteSearchResult tweets)
    {
      for (var j = 0; j < tweets.Statuses.Count; j++)
      {
        try
        {
          tweets.Statuses[j].CreatedAt = TwitterHelper.ConvertToDate(tweets.Statuses[j].CreatedAt).ToString("dd/MM/yyyy hh:mm:ss");
        }
        catch(Exception ex) { }
      }
      return tweets;
    }
  }

}