using College.Entities;

namespace College.Constant;

public static class PageMediaConstant
{
    public static readonly List<PageMedia> lstPageMedia =
    [

        #region Banner Image
        new PageMedia
        {
            Category = "Banner_Image",
            ImagePath = "/img/banner/banner_1.png",
            Heading = "<h2>Welcome to</h2><h2>Sree Muthukumaraswamy College</h2>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 1,
        },

        #endregion

        #region Campus Life
        new PageMedia
        {
            Category = "Campus_Life",
            ImagePath = "/img/campuslife/campuslife_1.jpeg",
            Heading = "<h3>Student Activities & Events<br>Experience SMKC Culture</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 1,
        },
        new PageMedia
        {
            Category = "Campus_Life",
            ImagePath = "/img/campuslife/campuslife_2.jpeg",
            Heading = "<h3>Clubs, Societies & Communities<br>Connect • Collaborate • Grow</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 2,
        },
        new PageMedia
        {
            Category = "Campus_Life",
            ImagePath = "/img/campuslife/campuslife_3.jpeg",
            Heading = "<h3>Modern Campus Facilities<br>A Space Built For Learning</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 3,
        },
        new PageMedia
        {
            Category = "Campus_Life",
            ImagePath = "/img/campuslife/campuslife_4.jpeg",
            Heading = "<h3>Hostel & Residential Life<br>A Home Away From Home</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 4,
        },

        #endregion

        #region Sports
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-1.jpg",
            Heading = "<h3>Making a meaningful difference in patients’ lives.</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 1,
        },
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-2.jpg",
            Heading = "<h3>When Life Depends on Medical Technology</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 2,
        },
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-3.jpg",
            Heading = "<h3>Happiness begins with good health</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 3,
        },
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-4.jpg",
            Heading = "<h3>When Life Depends on Medical Technology</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 4,
        },
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-5.jpg",
            Heading = "<h3>When Life Depends on Medical Technology</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 5,
        },
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-6.jpg",
            Heading = "<h3>When Life Depends on Medical Technology</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 6,
        },
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-7.jpg",
            Heading = "<h3>When Life Depends on Medical Technology</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 7,
        },
        new PageMedia
        {
            Category = "Sports",
            ImagePath = "/img/sports/sports-8.jpg",
            Heading = "<h3>When Life Depends on Medical Technology</h3>",
            ShortContent = null,
            Date = null,
            DisplayOrder = 8,
        },

        #endregion

        #region Alumni
        new PageMedia
        {
            Category = "Alumni",
            ImagePath = "/img/alumni/alumni_1.jpg",
            Heading = "Annual Alumni Meet 2023",
            ShortContent = null,
            Date = null,
            DisplayOrder = 1,
        },

        #endregion

        #region Events
        new PageMedia
        {
            Category = "Events",
            ImagePath = "/img/events/events-1.jpg",
            Heading = "Planning And Facilitating Effective Meetings",
            ShortContent = null,
            Date = new DateTime(2025, 3, 28),
            DisplayOrder = 1,
        },
        new PageMedia
        {
            Category = "Events",
            ImagePath = "/img/events/events-2.jpg",
            Heading = "Regular WordPress Meetup In New Jersey, USA",
            ShortContent = null,
            Date = new DateTime(2025, 3, 29),
            DisplayOrder = 2,
        },
        new PageMedia
        {
            Category = "Events",
            ImagePath = "/img/events/events-3.jpg",
            Heading = "Monday Night Concert In Lake View,Mountain City",
            ShortContent = null,
            Date = new DateTime(2025, 3, 30),
            DisplayOrder = 3,
        },
        new PageMedia
        {
            Category = "Events",
            ImagePath = "/img/events/events-4.jpg",
            Heading = "University Admissions Could Face Emergency Controls",
            ShortContent = null,
            Date = new DateTime(2025, 4, 1),
            DisplayOrder = 4,
        },
        new PageMedia
        {
            Category = "Events",
            ImagePath = "/img/events/events-5.jpg",
            Heading = "The Complete Digital Marketing Course - 12 Courses In 1",
            ShortContent = null,
            Date = new DateTime(2025, 4, 2),
            DisplayOrder = 5,
        },
        new PageMedia
        {
            Category = "Events",
            ImagePath = "/img/events/events-6.jpg",
            Heading = "The Python Mega Course: Build 10 Real World Applications",
            ShortContent = null,
            Date = new DateTime(2025, 4, 3),
            DisplayOrder = 6,
        },

        #endregion

        #region Latest News
        new PageMedia
        {
            Category = "Latest_News",
            ImagePath = "/img/latestnews/latestnews-1.png",
            Heading = "OVIYA SARADHA S",
            ShortContent = @"<strong>Register Number:</strong> 212204161<br>
                             <strong>Overall Percentage:</strong> 91.39%<br>
                             <strong>Result:</strong> First Class — Exemplary",
            Date = new DateTime(2025, 4, 11),
            DisplayOrder = 1,
        },
        new PageMedia
        {
            Category = "Latest_News",
            ImagePath = "/img/latestnews/latestnews-2.png",
            Heading = "Free Eye & General Health Camp",
            ShortContent = @"On behalf of our beloved late Founder, Thiru. P. Balasubramaniyam,<br>
                             Sree Muthukumaraswamy College organized a Free Eye &amp; General Health Camp<br>
                             to serve our community with care and compassion.",
            Date = new DateTime(2025, 4, 11),
            DisplayOrder = 2,
        },
        new PageMedia
        {
            Category = "Latest_News",
            ImagePath = "/img/latestnews/latestnews-3.png",
            Heading = "Cancer Awareness Rally",
            ShortContent = @"On 8th November 2025, we conducted a Cancer Awareness Rally<br>
                             to educate and empower our community towards a cancer-free future.",
            Date = new DateTime(2025, 11, 8),
            DisplayOrder = 3,
        },
        new PageMedia
        {
            Category = "Latest_News",
            ImagePath = "/img/latestnews/latestnews-4.png",
            Heading = "The Installation Ceremony of the Rotaract Club",
            ShortContent = @"The Installation Ceremony of the Rotaract Club of Sree Muthukumaraswamy College
                             for the academic year 2025–2026 was held on 7th November 2025 with great enthusiasm
                             and pride.",
            Date = new DateTime(2025, 4, 11),
            DisplayOrder = 4,
        },

        #endregion
    ];
}

