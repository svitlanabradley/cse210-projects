using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        // video 1
        Video video1 = new Video("How to Bake Chocolate Cake", "Chef Anna", 525);
        video1._comments.Add(new Comment { _name = "Emily", _text = "Tried this recipe and it turned out amazing!" });
        video1._comments.Add(new Comment { _name = "Jake" , _text = "Can I replace butter with oil?"});
        video1._comments.Add(new Comment { _name = "Sarah" , _text = "So easy to follow, thank you!"});
        video1._comments.Add(new Comment { _name = "Tom" , _text = "My kids loved it — will make it again!"});
        videos.Add(video1);

        // video 2
        Video video2 = new Video("Intro to Python Programming", "Alex", 625);
        video2._comments.Add(new Comment { _name = "Alex", _text = "Finally understood loops, thanks!" });
        video2._comments.Add(new Comment { _name = "Nia" , _text = "CLoved the pace of the tutorial."});
        video2._comments.Add(new Comment { _name = "Priya" , _text = "Clear and beginner-friendly."});
        video2._comments.Add(new Comment { _name = "Michael" , _text = "Can you explain recursion in the next video?"});
        videos.Add(video2);

        // video 3
        Video video3 = new Video("10-Minute Morning Yoga", "Olivia", 325);
        video3._comments.Add(new Comment { _name = "Jasmine", _text = "This helped me start my day with energy!" });
        video3._comments.Add(new Comment { _name = "Lucas" , _text = "Please post more short yoga routines."});
        video3._comments.Add(new Comment { _name = "Mia" , _text = "Easy for beginners — thank you!"});
        videos.Add(video3);

        // video 4
        Video video4 = new Video("Top 5 Travel Destinations in Europe", "Mia", 355);
        video4._comments.Add(new Comment { _name = "Ben", _text = "Now I want to visit Switzerland!" });
        video4._comments.Add(new Comment { _name = "Ana" , _text = "Love the video editing!"});
        video4._comments.Add(new Comment { _name = "David" , _text = "Great suggestions. Adding these to my bucket list."});
        video4._comments.Add(new Comment { _name = "Elina" , _text = "Could you do a budget travel version too?"});
        videos.Add(video4);


        foreach (Video video in videos)
        {
            video.GetVIdeoInformation();
        }
        
    }
}