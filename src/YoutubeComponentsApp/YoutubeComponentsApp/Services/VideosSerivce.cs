using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeComponentsApp.Models;

namespace YoutubeComponentsApp.Services
{
    public interface IVideosSerivce
    {
        List<VideoDetails> GetVideos(); 
    }

    public class StaticVideosService : IVideosSerivce
    {
        public List<VideoDetails> GetVideos()
        {
            return new List<VideoDetails>
            {
                new VideoDetails
                {
                    Url = "https://www.youtube.com/embed/cyzn8v8dcB8",
                    Title = "Blazor WebAssembly CI/CD with Azure DevOps Pipelines [Blazor Topics] | AK Academy",
                    PublishedDate = new DateTime(2020, 4, 1)
                },
                 new VideoDetails
                {
                    Url = "https://www.youtube.com/embed/Xz68c8GBYz4",
                    Title = "Localization and Multi Languages UI in Blazor WebAssembly [Blazor Topics] | AK Academy",
                    PublishedDate = new DateTime(2020, 4, 13)
                },
                 new VideoDetails
                {
                    Url = "https://www.youtube.com/embed/tUV5OMsttZk",
                    Title = "SignalR & Real-Time in Blazor Webassembly & ASP.NET Core API [Blazor Topics] | AK Academy",
                    PublishedDate = new DateTime(2020, 2, 11)
                },
                 new VideoDetails
                {
                    Url = "https://www.youtube.com/embed/i6C6ospRrYI",
                    Title = "Uploading Files in Blazor Web Assembly & ASP.NET Core Web API [Blazor Topics] | AK Academy",
                    PublishedDate = new DateTime(2020, 3, 23)
                },
            };
        }
    }
}
