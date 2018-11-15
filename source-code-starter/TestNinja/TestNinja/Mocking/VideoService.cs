using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        public string ReadVideoTitle(IFileReader fileReader)
        {
            // var str = File.ReadAllText("video.txt"); // this is the place where we are dealing with an external class/source which is "video.txt"
            var str = fileReader.Read("video.txt"); // this is still tightly coupled with the FileReader class because we are "newing" that class
            // str will be empty string when called usinf FakeFileReader becuse Read will return "" and thus videeo will be null as it cannot be serlilized.
                // so this was method1 to inject dependency
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            using (var context = new VideoContext())
            {
                var videos =
                    (from video in context.Videos
                     where !video.IsProcessed
                     select video).ToList();

                foreach (var v in videos)
                    videoIds.Add(v.Id);

                return String.Join(",", videoIds);
            }
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}