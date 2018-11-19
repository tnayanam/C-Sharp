using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using TestNinja.UnitTests.Mocking;
using TestNinja.UnitTests.Mocking;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        private IFileReader _fileReader;
        private IVideoRepository _repository;

        //public VideoService()
        //{
        //    _fileReader = new FileReader();
        //}
        public VideoService(IFileReader fileReader = null, IVideoRepository repository = null)
        {
            _fileReader = fileReader ?? new FileReader();
            _repository = repository ?? new VideoRepository();
        }
        // in previous lecture we learned injecting dependency via method parameter.
        public string ReadVideoTitle()
        {
            // var str = File.ReadAllText("video.txt"); // this is the place where we are dealing with an external class/source which is "video.txt"
            var str = _fileReader.Read("video.txt"); // this is still tightly coupled with the FileReader class because we are "newing" that class
                                                     // str will be empty string when called usinf FakeFileReader becuse Read will return "" and thus videeo will be null as it cannot be serlilized.
                                                     // so this was method1 to inject dependency
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        // [] => ""
        // [{}, {}, {}] =>  "1,2,3"
        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            var videos = _repository.GetUnprocessedVideos();

            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
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

/*
 * Some of the depdendency injection frameworks are Niject, StructureMap, Spring.Net, Autofac, Unity
 */
