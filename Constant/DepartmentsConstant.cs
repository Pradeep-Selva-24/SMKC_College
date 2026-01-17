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
                Department = "Computer Science",
                Category = "UG",
                ImagePath = "~/img/departments/cs/banner.jpg",
                Description = "The Computer Science Department focuses on modern computing technologies, software development, and research-driven learning.",
                SyllabusPath = "~/syllabus/cs.pdf",
                Order = 1
            },

            lstDepartmentsMembers =
            [
                new DepartmentsMembers
                {
                    Name = "Dr. A. Kumar",
                    Designation = "Head of Department",
                    ImagePath = "~/img/departments/cs/hod.jpg",
                    I_Order = 1
                },
                new DepartmentsMembers
                {
                    Name = "Ms. R. Priya",
                    Designation = "Assistant Professor",
                    ImagePath = "~/img/departments/cs/faculty1.jpg",
                    I_Order = 2
                }
            ],

            lstDepartmentsDetails =
            [
                new DepartmentsDetails
                {
                    Category = "Overview",
                    ImagePath = "~/img/departments/cs/overview.jpg",
                    Heading = "Department Vision",
                    ShortContent = "To produce globally competent professionals in computing and innovation-driven research.",
                    DisplayOrder = 1
                },
                new DepartmentsDetails
                {
                    Category = "Facilities",
                    ImagePath = "~/img/departments/cs/lab.jpg",
                    Heading = "Computer Labs",
                    ShortContent = "State-of-the-art computing labs with high-speed internet and modern development tools.",
                    DisplayOrder = 2
                }
            ]
        },
    ];
}
