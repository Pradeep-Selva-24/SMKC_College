using College.DTO;
using College.Entities;

namespace College.Constant;

public static class MenuConstant
{
    public static readonly List<MenuDTO> lstMenuDTO =
    [
        // HOME
        new MenuDTO
        {
            Menu = new MenuMaster
            {
                MenuName = "Home",
                MenuUrl = "/",
                Display = "Y",
                Order = 1
            }
        },

        // ABOUT
        new MenuDTO
        {
            Menu = new MenuMaster
            {
                MenuName = "About",
                MenuUrl = "#",
                Display = "Y",
                Order = 2
            },
            Children =
            [
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Vision & Mission",
                        MenuUrl = "/VisionMission/VisionMission",
                        Display = "Y",
                        Order = 1
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Management Message",
                        MenuUrl = "/ManagementMessage/ManagementMessage",
                        Display = "Y",
                        Order = 2
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "History & Profile",
                        MenuUrl = "/History/History",
                        Display = "Y",
                        Order = 3
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Accreditation / Affiliation",
                        MenuUrl = "/Accreditation/Accreditation",
                        Display = "Y",
                        Order = 4
                    }
                }
            ]
        },

        // ACADEMICS
        new MenuDTO
        {
            Menu = new MenuMaster
            {
                MenuName = "Academics",
                MenuUrl = "#",
                Display = "Y",
                Order = 3
            },
            Children =
            [
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Programmes Offered",
                        MenuUrl = "/ProgrammesOffered/ProgrammesOffered",
                        Display = "Y",
                        Order = 1
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Academic Calendar",
                        MenuUrl = "#",
                        Display = "Y",
                        Order = 2
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Placement",
                        MenuUrl = "/Placement/Placement",
                        Display = "Y",
                        Order = 3
                    }
                }
            ]
        },

        // ADMISSIONS
        new MenuDTO
        {
            Menu = new MenuMaster
            {
                MenuName = "Admissions",
                MenuUrl = "#",
                Display = "Y",
                Order = 4
            },
            Children =
            [
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Admission Procedure",
                        MenuUrl = "/AdmissionProcedure/AdmissionProcedure",
                        Display = "Y",
                        Order = 1
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Courses & Eligibility",
                        MenuUrl = "#",
                        Display = "Y",
                        Order = 2
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Fee Structure",
                        MenuUrl = "#",
                        Display = "Y",
                        Order = 3
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Apply Online / Prospectus",
                        MenuUrl = "#",
                        Display = "Y",
                        Order = 4
                    }
                }
            ]
        },

        // CAMPUS LIFE
        new MenuDTO
        {
            Menu = new MenuMaster
            {
                MenuName = "Campus Life",
                MenuUrl = "#",
                Display = "Y",
                Order = 5
            },
            Children =
            [
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Clubs & Activities",
                        MenuUrl = "/Clubs/Clubs",
                        Display = "Y",
                        Order = 1
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Events & Gallery",
                        MenuUrl = "/EventsGallery/EventsGallery",
                        Display = "Y",
                        Order = 2
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Student Support",
                        MenuUrl = "/StudentSupport/StudentSupport",
                        Display = "Y",
                        Order = 3
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "Alumni",
                        MenuUrl = "/Alumni/Alumni",
                        Display = "Y",
                        Order = 4
                    }
                }
            ]
        },

        // QUALITY ASSURANCE
        new MenuDTO
        {
            Menu = new MenuMaster
            {
                MenuName = "Quality Assurance",
                MenuUrl = "#",
                Display = "Y",
                Order = 6
            },
            Children =
            [
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "IQAC Committee",
                        MenuUrl = "/QualityAssurance/IQAC",
                        Display = "Y",
                        Order = 1
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "AQAR Reports",
                        MenuUrl = "/QualityAssurance/AQAR",
                        Display = "Y",
                        Order = 2
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "NAC",
                        MenuUrl = "/QualityAssurance/NAC",
                        Display = "Y",
                        Order = 3
                    }
                },
                new MenuDTO
                {
                    Menu = new MenuMaster
                    {
                        MenuName = "NIRF",
                        MenuUrl = "/QualityAssurance/NIRF",
                        Display = "Y",
                        Order = 4
                    }
                }
            ]
        }
    ];
}