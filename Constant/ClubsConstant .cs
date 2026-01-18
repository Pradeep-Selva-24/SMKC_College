using College.DTO;
using College.Entities;

namespace College.Constant;

public static class ClubsConstant
{
    public static readonly List<ClubsDTO> lstClubsDTO =
    [
        // NSS - National Service Scheme
        new ClubsDTO
        {
            ClubsMaster = new ClubsMaster
                         {
                             Clubs = "NSS",
                             FullName = "National Service Scheme (NSS)",
                             Description  = @"The <strong>NSS Unit</strong> of <strong>Sree Muthukumaraswamy College</strong> promotes social responsibility and community service among students through various outreach programs and awareness drives.",
                             DisplayOrder = 1,
                         },
            lstClubsDetails =
            [
                // Events
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/nss/events/nss1.jpg",
                    Heading = "Blood Donation Camp",
                    ShortContent = "Students actively participated in a blood donation camp organized in collaboration with the local health department.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/nss/events/nss2.jpg",
                    Heading = "Tree Plantation Drive",
                    ShortContent = "An eco-initiative to plant 200+ saplings around the campus to promote a greener environment.",
                    DisplayOrder = 2
                },

                // Activities
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/nss/activities/nss1.jpg",
                    Heading = "Swachh Bharat Mission",
                    ShortContent = "NSS volunteers participated in a cleanliness drive under the national “Swachh Bharat” initiative.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/nss/activities/nss2.jpg",
                    Heading = "Health Awareness Rally",
                    ShortContent = "Students conducted a rally to spread awareness about personal hygiene and disease prevention.",
                    DisplayOrder = 2
                },

                // Gallery
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/nss/gallery/nss1.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/nss/gallery/nss2.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 2
                },
            ]
        },

        // NCC - National Cadet Corps
        new ClubsDTO
        {
            ClubsMaster = new ClubsMaster
            {
                Clubs = "NCC",
                FullName = "National Cadet Corps (NCC)",
                Description = @"The <strong>NCC Unit</strong> of <strong>Sree Muthukumaraswamy College</strong> aims to develop discipline, leadership, patriotism, and a sense of social responsibility among students through military training, community service, and national integration activities.",
                DisplayOrder = 2,
            },
            lstClubsDetails =
            [
                // Events
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/ncc/events/ncc1.jpg",
                    Heading = "Independence Day Parade",
                    ShortContent = "NCC cadets actively participated in the Independence Day parade, showcasing discipline and patriotic spirit.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/ncc/events/ncc2.jpg",
                    Heading = "Annual Training Camp",
                    ShortContent = "Cadets underwent rigorous training sessions focusing on leadership, teamwork, and physical fitness.",
                    DisplayOrder = 2
                },
        
                // Activities
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/ncc/activities/ncc1.jpg",
                    Heading = "Drill Practice",
                    ShortContent = "Regular drill sessions conducted to enhance discipline, coordination, and command-following skills among cadets.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/ncc/activities/ncc2.jpg",
                    Heading = "Community Service Drive",
                    ShortContent = "NCC volunteers participated in social service activities such as road safety awareness and public cleanliness drives.",
                    DisplayOrder = 2
                },
        
                // Gallery
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/ncc/gallery/ncc1.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/ncc/gallery/ncc2.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 2
                },
            ]
        },

        // YRC - Youth Red Cross
        new ClubsDTO
        {
            ClubsMaster = new ClubsMaster
            {
                Clubs = "YRC",
                FullName = "Youth Red Cross (YRC)",
                Description = @"The <strong>Youth Red Cross</strong> of <strong>Sree Muthukumaraswamy College</strong> encourages students to serve humanity by promoting health, hygiene, and humanitarian values through awareness programs, first-aid training, and community welfare activities.",
                DisplayOrder = 3,
            },
            lstClubsDetails =
            [
                // Events
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/yrc/events/yrc1.jpg",
                    Heading = "First Aid Training Camp",
                    ShortContent = "Students received hands-on training in basic first aid and emergency response to handle real-life situations.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/yrc/events/yrc2.jpg",
                    Heading = "Blood Donation Awareness Program",
                    ShortContent = "An awareness session conducted to educate students on the importance of voluntary blood donation.",
                    DisplayOrder = 2
                },
        
                // Activities
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/yrc/activities/yrc1.jpg",
                    Heading = "Health & Hygiene Drive",
                    ShortContent = "Volunteers conducted campus and community-level initiatives to promote personal hygiene and healthy living.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/yrc/activities/yrc2.jpg",
                    Heading = "Community Welfare Visit",
                    ShortContent = "Students visited nearby communities and old age homes to provide support and spread awareness on basic health practices.",
                    DisplayOrder = 2
                },
        
                // Gallery
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/yrc/gallery/yrc1.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/yrc/gallery/yrc2.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 2
                },
            ]
        },
        
        // RRC - Red Ribbon Club
        new ClubsDTO
        {
            ClubsMaster = new ClubsMaster
            {
                Clubs = "RRC",
                FullName = "Red Ribbon Club (RRC)",
                Description = @"The <strong>Red Ribbon Club</strong> of <strong>Sree Muthukumaraswamy College</strong> focuses on creating awareness about HIV/AIDS, healthy lifestyles, and social responsibility among students through campaigns, workshops, and peer education programs.",
                DisplayOrder = 4,
            },
            lstClubsDetails =
            [
                // Events
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/rrc/events/rrc1.jpg",
                    Heading = "World AIDS Day Awareness Program",
                    ShortContent = "Students organized an awareness program highlighting the importance of HIV/AIDS prevention and social inclusion.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/clubs/rrc/events/rrc2.jpg",
                    Heading = "Health & Wellness Seminar",
                    ShortContent = "A seminar conducted to promote healthy habits, mental well-being, and responsible lifestyle choices among students.",
                    DisplayOrder = 2
                },
        
                // Activities
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/rrc/activities/rrc1.jpg",
                    Heading = "Peer Education Program",
                    ShortContent = "Trained student volunteers educated their peers on HIV prevention, stigma reduction, and healthy living practices.",
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/clubs/rrc/activities/rrc2.jpg",
                    Heading = "Awareness Rally",
                    ShortContent = "Students conducted a rally to spread awareness about HIV/AIDS prevention and the importance of social responsibility.",
                    DisplayOrder = 2
                },
        
                // Gallery
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/rrc/gallery/rrc1.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 1
                },
                new ClubsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/clubs/rrc/gallery/rrc2.jpg",
                    Heading = string.Empty,
                    ShortContent = string.Empty,
                    DisplayOrder = 2
                },
            ]
        },

    ];
}
