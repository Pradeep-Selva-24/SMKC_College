using College.DTO;
using College.Entities;

namespace College.Constant;

public static class ManagementConstant
{

    public static readonly List<ManagementDTO> lstManagementDTO =
    [
        new ManagementDTO
        {
            Management = new Management
                         {
                             Name = "A.P.Ashok Kumar",
                             Designation = "S.M.D.Educational Society Chairman",
                             ImagePath = "~/img/management/EducationalChairman.jpeg",
                             DisplayOrder = 1,
                         },
            lstManagementContent =
            [
                new ManagementContent
                {
                    Content = "Welcome to Sree Muthukumaraswamy College, an institution dedicated to quality education and character building.Our goal is to provide a nurturing environment where students grow academically and personally.",
                },
                new ManagementContent
                {
                    Content = "We are committed to offering innovative programs that meet the evolving needs of society. With the support of our experienced faculty and staff, we strive to shape responsible and confident individuals.",
                },
                new ManagementContent
                {
                    Content = "The college continues to uphold its legacy of excellence through continuous improvement and student-centric initiatives. I encourage all students to make full use of the opportunities provided and pursue their goals with determination.",
                },
            ]
        },

        new ManagementDTO
        {
            Management = new Management
                         {
                             Name = "R. Lakshmanaswamy",
                             Designation = "S.M.D.Educational Society Secretary",
                             ImagePath = "~/img/management/EducationalSecretary.jpeg",
                             DisplayOrder = 2,
                         },
            lstManagementContent =
            [
                new ManagementContent
                {
                    Content = "Sree Muthukumaraswamy College remains committed to quality, value-driven education, fostering an ecosystem of learning, integrity and growth.",
                },
                new ManagementContent
                {
                    Content = "We uplift academic rigour, cultural vibrance and ethical leadership, empowering you to excel. With dedicated faculty, we drive progress.",
                },
                new ManagementContent
                {
                    Content = "Wishing you a fruitful, inspiring academic journey.",
                },
            ]
        },

        new ManagementDTO
        {
            Management = new Management
                         {
                             Name = "A. N. Suresh Kumar",
                             Designation = "College Secretary",
                             ImagePath = "~/img/management/CollegeSecretary.jpeg",
                             DisplayOrder = 3,
                         },
            lstManagementContent =
            [
                new ManagementContent
                {
                    Content = "Sree Muthukumaraswamy College remains committed to delivering quality education that shapes responsible and capable individuals. As College Secretary, I strive to ensure smooth administration and effective support for all academic and developmental activities.",
                },
                new ManagementContent
                {
                    Content = "Our focus is on providing opportunities that encourage learning, leadership and holistic growth. With the cooperation of our dedicated faculty and staff, the college continues to progress towards greater excellence.",
                },
                new ManagementContent
                {
                    Content = "I encourage every student to make the best use of the resources and pursue their goals with confidence and determination",
                },
            ]
        },

        new ManagementDTO
        {
            Management = new Management
                         {
                             Name = "Dr. G. Raja Priya",
                             Designation = "Principal",
                             ImagePath = "~/img/management/Principal.jpeg",
                             DisplayOrder = 4,
                         },
            lstManagementContent =
            [
                new ManagementContent
                {
                    Content = "Welcome to Sree Muthukumaraswamy College, an institution committed to academic excellence and holistic development. Our college strives to empower students with knowledge, skills and values that prepare them for a dynamic world.",
                },
                new ManagementContent
                {
                    Content = "We foster an environment that encourages innovation, discipline and continuous learning. Our dedicated faculty and supportive staff work together to nurture the potential of every student.",
                },
                new ManagementContent
                {
                    Content = "We remain focused on creating opportunities that enhance both academic and personal growth. I warmly invite you to explore our vibrant campus community and engage in our journey toward excellence.",
                },
            ]
        },

        new ManagementDTO
        {
            Management = new Management
                         {
                             Name = "Dr. R. Anandhy",
                             Designation = "Vice Principal",
                             ImagePath = "~/img/management/VicePrincipal.jpeg",
                             DisplayOrder = 5,
                         },
            lstManagementContent =
            [
                new ManagementContent
                {
                    Content = "Is my pleasure to welcome you to our college, an institution dedicated to quality education and the overall development of students. We aim to create a positive learning environment that encourages knowledge, discipline, creativity and ethical values. Our focus is not only on academic excellence but also on shaping responsible and confident individuals.",
                },
                new ManagementContent
                {
                    Content = "With the support of dedicated faculty and a student-friendly campus, we strive to provide opportunities for skill development, research and co-curricular activities. We are committed to guiding our students to face future challenges successfully and to contribute meaningfully to society. Together, let us work towards continuous growth and excellence.",
                },
            ]
        },

        new ManagementDTO
        {
            Management = new Management
                         {
                             Name = "Dr. V. Selvanathan",
                             Designation = "Academic Advisor",
                             ImagePath = "~/img/management/AcademicAdvisor.jpeg",
                             DisplayOrder = 6,
                         },
            lstManagementContent =
            [
                new ManagementContent
                {
                    Content = "As the Academic Advisor, my foremost responsibility is to support and guide students in achieving their academic and personal goals. Our institution is committed to providing a learner-centric environment where students are encouraged to explore their interests, build strong academic foundations and develop essential skills for their future careers. Through proper guidance, structured academic planning and continuous mentoring, we aim to help every student realize their true potential.",
                },
                new ManagementContent
                {
                    Content = "I encourage students to actively engage in their learning process, seek guidance whenever required and make the best use of the academic and co-curricular opportunities provided by the college. With dedication, discipline and the right support system, success becomes a shared journey. I wish all our students a meaningful, enriching and successful academic experience.",
                },
            ]
        }
    ];
}
