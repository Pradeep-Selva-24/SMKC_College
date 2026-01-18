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
                Department = "B.Sc(Computer Science)",
                Category = "UG",
                ImagePath = "/img/courses/courses-1.png",
                Description = "The Department of Computer Science at Sree Muthukumaraswamy College aims to equip students with a strong foundation in computing principles and modern technological practices. The department emphasizes technical excellence, problem-solving abilities, ethical responsibility, and innovation through interactive teaching methods, hands-on programming, and real-world project exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 1
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "BCA",
                Category = "UG",
                ImagePath = "/img/courses/courses-2.png",
                Description = "The Department of Computer Applications at Sree Muthukumaraswamy College aims to provide students with a strong foundation in computer applications and modern software technologies. The department emphasizes technical competence, problem-solving skills, ethical practices, and innovation through interactive learning, hands-on programming, and industry-oriented project exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 2
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "BBA",
                Category = "UG",
                ImagePath = "/img/courses/courses-3.png",
                Description = "The Department of Business Administration at Sree Muthukumaraswamy College aims to develop students with a strong foundation in management principles and contemporary business practices. The department emphasizes leadership qualities, strategic thinking, ethical values, and entrepreneurial skills through innovative teaching methods, case-based learning, and practical industry exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 3
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Com (General)",
                Category = "UG",
                ImagePath = "/img/courses/courses-4.png",
                Description = "The Department of Commerce at Sree Muthukumaraswamy College aims to provide students with a comprehensive understanding of commerce, business operations, and financial practices. The department emphasizes professional competence, ethical values, analytical thinking, and entrepreneurial skills through innovative teaching methods, practical learning, and real-world industry exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 4
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Com (Accounting & Finance)",
                Category = "UG",
                ImagePath = "/img/courses/courses-5.png",
                Description = "The Department of Commerce (Accounting & Finance) at Sree Muthukumaraswamy College aims to provide students with a strong foundation in accounting principles, financial management, and regulatory practices. The department emphasizes analytical skills, professional integrity, ethical responsibility, and financial decision-making through innovative teaching methods, practical training, and real-world industry exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 5
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Com (Bank Management)",
                Category = "UG",
                ImagePath = "/img/courses/courses-6.png",
                Description = "The Department of Commerce (Bank Management) at Sree Muthukumaraswamy College aims to equip students with comprehensive knowledge of banking operations, financial systems, and risk management practices. The department emphasizes professional competence, ethical standards, analytical thinking, and customer-focused services through innovative teaching methods, practical training, and real-world banking exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 6
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Com (Corporate Secretaryship)",
                Category = "UG",
                ImagePath = "/img/courses/courses-7.png",
                Description = "The Department of Commerce (Corporate Secretaryship) at Sree Muthukumaraswamy College aims to develop students with in-depth knowledge of corporate governance, company law, and secretarial practices. The department emphasizes professional ethics, legal compliance, managerial skills, and effective communication through innovative teaching methods, practical training, and real-world corporate exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 7
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Com (Computer Application)",
                Category = "UG",
                ImagePath = "/img/courses/courses-8.png",
                Description = "The Department of Commerce (Computer Application) at Sree Muthukumaraswamy College aims to integrate core commerce knowledge with modern computing and digital business tools. The department emphasizes technical proficiency, analytical thinking, ethical practices, and innovation through interactive learning, hands-on application development, and real-world business technology exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 8
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Sc (Software Applications)",
                Category = "UG",
                ImagePath = "/img/courses/courses-9.png",
                Description = "The Department of Software Applications at Sree Muthukumaraswamy College aims to equip students with a strong foundation in software development, system design, and modern computing technologies. The department emphasizes technical excellence, problem-solving abilities, ethical responsibility, and innovation through interactive learning, hands-on programming, and real-world project and industry exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 9
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Com (Information System Management)",
                Category = "UG",
                ImagePath = "/img/courses/courses-10.png",
                Description = "The Department of Commerce (Information System Management) at Sree Muthukumaraswamy College aims to integrate business knowledge with information systems and digital management practices. The department emphasizes analytical thinking, technological competence, ethical values, and strategic decision-making through innovative teaching methods, hands-on system applications, and real-world business technology exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 10
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Com (Marketing Management)",
                Category = "UG",
                ImagePath = "/img/courses/courses-11.png",
                Description = "The Department of Commerce (Marketing Management) at Sree Muthukumaraswamy College aims to develop students with a strong foundation in marketing principles, consumer behavior, and strategic brand management. The department emphasizes creativity, analytical thinking, ethical practices, and market-driven decision-making through innovative teaching methods, case-based learning, and real-world industry exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 11
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "B.Sc (Criminology & Criminal Justice Science)",
                Category = "UG",
                ImagePath = "/img/courses/courses-12.png",
                Description = "The Department of Criminology and Criminal Justice Science at Sree Muthukumaraswamy College aims to provide students with a comprehensive understanding of crime, law enforcement, and the criminal justice system. The department emphasizes analytical thinking, ethical responsibility, social awareness, and professional competence through innovative teaching methods, field-based learning, and real-world exposure to criminal justice practices.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 12
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "M.Com (General)",
                Category = "PG",
                ImagePath = "/img/courses/courses-13.png",
                Description = "The Department of Commerce at Sree Muthukumaraswamy College aims to provide postgraduate students with advanced knowledge in commerce, finance, and business research. The department emphasizes analytical thinking, professional excellence, ethical leadership, and strategic decision-making through research-oriented learning, case-based studies, and real-world industry and academic exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 13
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "M.Sc(Computer Science)",
                Category = "PG",
                ImagePath = "/img/courses/courses-14.png",
                Description = "The Department of Computer Science at Sree Muthukumaraswamy College aims to provide postgraduate students with advanced knowledge in computing, software engineering, and emerging technologies. The department emphasizes research aptitude, technical excellence, ethical responsibility, and innovation through advanced coursework, project-based learning, and real-world industry and academic exposure.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 14
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
                Department = "Ph.D. (Commerce)",
                Category = "Ph.D",
                ImagePath = "/img/courses/courses-15.png",
                Description = "The Department of Commerce at Sree Muthukumaraswamy College aims to foster advanced research and scholarly excellence in the field of commerce and business studies. The department emphasizes critical inquiry, ethical research practices, innovation, and knowledge creation through rigorous academic guidance, interdisciplinary collaboration, and meaningful contributions to industry and society.",
                StudentCount = 200,
                SyllabusPath = "",
                Order = 15
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. S. Suganthi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty1.jpg",
                    Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Dr. G. Raja Priya",
                    Designation = "PG & Research Department of Commerce",
                    ImagePath = "/img/departments/commerce/faculty/faculty2.jpg",
                    Order = 2
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. S. P. Sasirani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty3.jpg",
                    Order = 3
                },
                new DepartmentsMembers
                {
                    Name = "Mrs. K. S. Uma Maheshwari",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty4.jpg",
                    Order = 4
                },
                new DepartmentsMembers
                {
                    Name = "Dr. D. Bhavani",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty5.jpg",
                    Order = 5
                },
                new DepartmentsMembers
                {
                    Name = "Dr. N. Selvi",
                    Designation = "Head & Associate Professor",
                    ImagePath = "/img/departments/commerce/faculty/faculty6.jpg",
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
        }
    ];



}
