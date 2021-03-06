﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_postgres_oauth_boiler.Models
{
    public class OAuthData
    {
        public class GoogleToken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string id_token { get; set; }
            public string refresh_token { get; set; }
        }

        public class OAuthTOken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public string scope { get; set; }
        }

        public class RedditToken : OAuthTOken { }
        public class GithubToken : OAuthTOken { }



        // <auto-generated />
        //
        // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
        //
        //    using QuickType;
        //
        //    var welcome = Welcome.FromJson(jsonString);



        public class RedditUserInfo
        {
            [JsonProperty("is_employee")]
            public bool IsEmployee { get; set; }

            [JsonProperty("seen_layout_switch")]
            public bool SeenLayoutSwitch { get; set; }

            [JsonProperty("has_visited_new_profile")]
            public bool HasVisitedNewProfile { get; set; }

            [JsonProperty("pref_no_profanity")]
            public bool PrefNoProfanity { get; set; }

            [JsonProperty("has_external_account")]
            public bool HasExternalAccount { get; set; }

            [JsonProperty("pref_geopopular")]
            public string PrefGeopopular { get; set; }

            [JsonProperty("seen_redesign_modal")]
            public bool SeenRedesignModal { get; set; }

            [JsonProperty("pref_show_trending")]
            public bool PrefShowTrending { get; set; }

            [JsonProperty("is_sponsor")]
            public bool IsSponsor { get; set; }

            [JsonProperty("gold_expiration")]
            public object GoldExpiration { get; set; }

            [JsonProperty("has_gold_subscription")]
            public bool HasGoldSubscription { get; set; }

            [JsonProperty("num_friends")]
            public long NumFriends { get; set; }

            [JsonProperty("has_android_subscription")]
            public bool HasAndroidSubscription { get; set; }

            [JsonProperty("verified")]
            public bool Verified { get; set; }

            [JsonProperty("pref_autoplay")]
            public bool PrefAutoplay { get; set; }

            [JsonProperty("coins")]
            public long Coins { get; set; }

            [JsonProperty("has_paypal_subscription")]
            public bool HasPaypalSubscription { get; set; }

            [JsonProperty("has_subscribed_to_premium")]
            public bool HasSubscribedToPremium { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("has_stripe_subscription")]
            public bool HasStripeSubscription { get; set; }

            [JsonProperty("seen_premium_adblock_modal")]
            public bool SeenPremiumAdblockModal { get; set; }

            [JsonProperty("can_create_subreddit")]
            public bool CanCreateSubreddit { get; set; }

            [JsonProperty("over_18")]
            public bool Over18 { get; set; }

            [JsonProperty("is_gold")]
            public bool IsGold { get; set; }

            [JsonProperty("is_mod")]
            public bool IsMod { get; set; }

            [JsonProperty("suspension_expiration_utc")]
            public object SuspensionExpirationUtc { get; set; }

            [JsonProperty("has_verified_email")]
            public bool HasVerifiedEmail { get; set; }

            [JsonProperty("is_suspended")]
            public bool IsSuspended { get; set; }

            [JsonProperty("pref_video_autoplay")]
            public bool PrefVideoAutoplay { get; set; }

            [JsonProperty("can_edit_name")]
            public bool CanEditName { get; set; }

            [JsonProperty("in_redesign_beta")]
            public bool InRedesignBeta { get; set; }

            [JsonProperty("icon_img")]
            public Uri IconImg { get; set; }

            [JsonProperty("pref_nightmode")]
            public bool PrefNightmode { get; set; }

            [JsonProperty("oauth_client_id")]
            public string OauthClientId { get; set; }

            [JsonProperty("hide_from_robots")]
            public bool HideFromRobots { get; set; }

            [JsonProperty("link_karma")]
            public long LinkKarma { get; set; }

            [JsonProperty("force_password_reset")]
            public bool ForcePasswordReset { get; set; }

            [JsonProperty("seen_give_award_tooltip")]
            public bool SeenGiveAwardTooltip { get; set; }

            [JsonProperty("inbox_count")]
            public long InboxCount { get; set; }

            [JsonProperty("pref_top_karma_subreddits")]
            public bool PrefTopKarmaSubreddits { get; set; }

            [JsonProperty("pref_show_snoovatar")]
            public bool PrefShowSnoovatar { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("pref_clickgadget")]
            public long PrefClickgadget { get; set; }

            [JsonProperty("created")]
            public long Created { get; set; }

            [JsonProperty("gold_creddits")]
            public long GoldCreddits { get; set; }

            [JsonProperty("created_utc")]
            public long CreatedUtc { get; set; }

            [JsonProperty("has_ios_subscription")]
            public bool HasIosSubscription { get; set; }

            [JsonProperty("pref_show_twitter")]
            public bool PrefShowTwitter { get; set; }

            [JsonProperty("in_beta")]
            public bool InBeta { get; set; }

            [JsonProperty("comment_karma")]
            public long CommentKarma { get; set; }

            [JsonProperty("has_subscribed")]
            public bool HasSubscribed { get; set; }

            [JsonProperty("seen_subreddit_chat_ftux")]
            public bool SeenSubredditChatFtux { get; set; }
        }
    }

    public partial class GithubUserInfo
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public object Company { get; set; }

        [JsonProperty("blog")]
        public Uri Blog { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hireable")]
        public bool Hireable { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("public_repos")]
        public long PublicRepos { get; set; }

        [JsonProperty("public_gists")]
        public long PublicGists { get; set; }

        [JsonProperty("followers")]
        public long Followers { get; set; }

        [JsonProperty("following")]
        public long Following { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

}
