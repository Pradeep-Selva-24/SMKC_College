using College.DTO;
using College.Entities;

namespace College.Constant;

public static class DepartmentsConstant
{
    public static readonly List<DepartmentsDTO> lstDepartmentsDTO =
    [
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Business Administration",
                ImagePath = "/img/department/department1.png",
                Description = "The Department of Business Administration focuses on developing managerial skills, leadership qualities, and business acumen through academic excellence and practical exposure.",
                Order = 1
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "K. S. Uma Maheshwari",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Sarala R",
                    Designation = "Associate Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "G. Nathiya",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "R. Kalaivani",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                },

                new DepartmentsMembers
                {
                    Name = "Dr. M. Anitha Mary",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 5
                },

                new DepartmentsMembers
                {
                    Name = "R. Shanmuga Priya",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 6
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Commerce (Accounting and Finance)",
                ImagePath = "/img/department/department2.png",
                Description = "The department provides in-depth knowledge of accounting principles, financial management, taxation, and auditing to prepare students for professional careers.",
                Order = 2
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "S. Geethalakshmi",
                    Designation = "Associate Professor & Incharge",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "M. Devi Priya",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Rithika Vinai",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Commerce (Bank Management)",
                ImagePath = "/img/department/department3.png",
                Description = "This department equips students with comprehensive knowledge of banking operations, financial institutions, and modern banking practices.",
                Order = 3
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "S. P. Sasirani",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "B. Kavitha",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Dr. M. Sampathkumar",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "K. Nathiya",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Commerce (Computer Applications)",
                ImagePath = "/img/department/department4.png",
                Description = "The department integrates commerce education with computer applications to enhance analytical, technical, and business-oriented skills.",
                Order = 4
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "P. Vageshwari",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Commerce (Information Systems Management)",
                ImagePath = "/img/department/department5.png",
                Description = "The department focuses on information systems, business analytics, and management practices supported by modern technology.",
                Order = 5
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "R. Banupriya",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Jeniffer Begum J",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Rizwana Begum A. R",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Commerce (Marketing Management)",
                ImagePath = "/img/department/department6.png",
                Description = "The department emphasizes marketing strategies, consumer behavior, digital marketing, and practical industry exposure.",
                Order = 6
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Joshva J",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "S. Anitha",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Computer Applications",
                ImagePath = "/img/department/department7.png",
                Description = "The department provides strong foundations in software development, programming, and application-oriented computing skills.",
                Order = 7
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. Suganthi",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "R. Salomiya",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Gayathri R",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "Nivetha Mary C",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Corporate Secretaryship",
                ImagePath = "/img/department/department8.png",
                Description = "The department trains students in corporate laws, governance, company secretarial practices, and compliance management.",
                Order = 8
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Revathi",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Dr. R. Umamaheswari",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "D. Manju",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Criminology and Criminal Justice Science",
                ImagePath = "/img/department/department9.png",
                Description = "The department offers academic and practical insights into criminology, forensic science, and criminal justice administration.",
                Order = 9
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. K. Mythili",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "C. Anandhi",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "S. Karuppasamy Pandiyan",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "Ruban Kumar P",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Economics",
                ImagePath = "/img/department/department10.png",
                Description = "The department develops analytical and critical thinking skills through the study of economic theory, policy, and applied economics.",
                Order = 10
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "G. Deepanandhini",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Dr. V. Ananthababu",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of English",
                ImagePath = "/img/department/department11.png",
                Description = "The department enhances language proficiency, literary knowledge, and communication skills through diverse academic programs.",
                Order = 11
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Kasthuri Jyothi",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Dr. A. Yogalakshmi",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Sudarvizhi B",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "Prabhavathy R",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                },

                new DepartmentsMembers
                {
                    Name = "Y. Stellamary",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 5
                },

                new DepartmentsMembers
                {
                    Name = "Jannath Fathima M",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 6
                },

                new DepartmentsMembers
                {
                    Name = "E. Nivetha",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 7
                },

                new DepartmentsMembers
                {
                    Name = "Godwin Hernandez M",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 8
                },

                new DepartmentsMembers
                {
                    Name = "S. K. Karthick",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 9
                },

                new DepartmentsMembers
                {
                    Name = "Jayavenkatesh P",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 10
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Library Science",
                ImagePath = "/img/department/department12.png",
                Description = "The department supports academic excellence by providing knowledge in library management, information organization, and research services.",
                Order = 12
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Raja",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 1
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Mathematics",
                ImagePath = "/img/department/department13.png",
                Description = "The department focuses on mathematical theory, problem-solving, and logical reasoning essential for scientific and analytical studies.",
                Order = 13
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. R. Anandhy",
                    Designation = "Vice Principal, Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Kanmani N",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Arul Kumar G",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Physical Education",
                ImagePath = "/img/department/department14.png",
                Description = "The department promotes physical fitness, sportsmanship, and overall well-being through structured physical education programs.",
                Order = 14
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Nandhakumar S",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 1
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Software Applications",
                ImagePath = "/img/department/department15.png",
                Description = "The department emphasizes software development, application design, and modern computing technologies.",
                Order = 15
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "T. Merlin Jaba",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Kalaimani M",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Rasiga B",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "Department of Tamil",
                ImagePath = "/img/department/department16.png",
                Description = "The department preserves and promotes Tamil language, literature, culture, and heritage through academic excellence.",
                Order = 16
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. R. Kalpana Devi",
                    Designation = "Assistant Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "Dr. P. Jayasudha",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Dr. K. Annalakshmi",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "Dr. P. Kalavathi",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                },

                new DepartmentsMembers
                {
                    Name = "Dr. M. Manickam",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 5
                },

                new DepartmentsMembers
                {
                    Name = "Dr. Manikandan S",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 6
                },

                new DepartmentsMembers
                {
                    Name = "Balaji S",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 7
                },

                new DepartmentsMembers
                {
                    Name = "Sakthivel M",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 8
                },

                new DepartmentsMembers
                {
                    Name = "Sajila A J",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 9
                },

                new DepartmentsMembers
                {
                    Name = "Sudha M",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 10
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "PG Department of Computer Science",
                ImagePath = "/img/department/department17.png",
                Description = "The PG Department of Computer Science provides advanced knowledge in computing, research methodologies, and emerging technologies.",
                Order = 17
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "P. Archana Devi",
                    Designation = "Associate Professor & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "V. Rekha",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "Sandhiya K",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "Thangalakshmi S",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
        new DepartmentsDTO
        {
            DepartmentsMaster = new DepartmentsMaster
            {
                Department = "PG and Research Department of Commerce",
                ImagePath = "/img/department/department18.png",
                Description = "The department focuses on advanced commerce education and research, fostering analytical thinking and academic innovation.",
                Order = 18
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "Principal & Head",
                    ImagePath = "",
                    Order = 1
                },

                new DepartmentsMembers
                {
                    Name = "B. Jayarekha",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 2
                },

                new DepartmentsMembers
                {
                    Name = "J. B. Rosy Dyana",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 3
                },

                new DepartmentsMembers
                {
                    Name = "Dr. C. Manivannan",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 4
                },

                new DepartmentsMembers
                {
                    Name = "P. Jebarani",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 5
                },

                new DepartmentsMembers
                {
                    Name = "Sangamithirai G",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 6
                },

                new DepartmentsMembers
                {
                    Name = "Sridhar B",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 7
                },

                new DepartmentsMembers
                {
                    Name = "R. Dhanush",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 8
                },

                new DepartmentsMembers
                {
                    Name = "S. Keerthana",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 9
                },

                new DepartmentsMembers
                {
                    Name = "L. Grace Jenifer",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 10
                },

                new DepartmentsMembers
                {
                    Name = "M. Renuka",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 11
                },

                new DepartmentsMembers
                {
                    Name = "M. Logapriya",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 12
                },

                new DepartmentsMembers
                {
                    Name = "E. Mahalakshmi",
                    Designation = "Assistant Professor",
                    ImagePath = "",
                    Order = 13
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Events",
                    ImagePath = "/img/departments/commerce/events/events1.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Activities",
                    ImagePath = "/img/departments/commerce/activities/activities1.jpeg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },

                new DepartmentsDetails
                {
                    Category = "Gallery",
                    ImagePath = "/img/departments/commerce/gallery/gallery1.png",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
            ]
        },
    ];
}
