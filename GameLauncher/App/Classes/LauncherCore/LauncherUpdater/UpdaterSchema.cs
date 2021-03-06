using Newtonsoft.Json;
using System.Collections.Generic;

namespace GameLauncher.App.Classes.LauncherCore.LauncherUpdater
{
    public class Update
    {
        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }
    }

    public class CheckVersion
    {
        [JsonProperty("client_version")]
        public string ClientVersion { get; set; }

        [JsonProperty("latest_version")]
        public string LatestVersion { get; set; }

        [JsonProperty("update_exists")]
        public bool UpdateExists { get; set; }
        
        [JsonProperty("update")]
        public Update Update { get; set; }
    }

    public class UpdateCheckResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("payload")]
        public CheckVersion Payload { get; set; }
    }

    public class GitHubRelease
    {
        [JsonProperty("tag_name")]
        public string TagName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("assets")]
        public List<AssetModel> Assets { get; set; }

        public class AssetModel
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("browser_download_url")]
            public string Url { get; set; }
        }
    }
}
