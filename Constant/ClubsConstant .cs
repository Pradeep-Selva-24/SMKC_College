using College.DTO;
using College.Entities;

namespace College.Constant;

public static class ClubsConstant
{
    public static readonly List<ClubsDTO> lstClubsDTO =
    [
        new ClubsDTO
        {
            ClubsMaster = new ClubsMaster
                         {
                             Clubs = "NSS",
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

    ];
}
