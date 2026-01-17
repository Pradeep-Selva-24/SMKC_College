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
                             ImagePath = "/img/management/EducationalChairman.jpeg",
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
                             ImagePath = "/img/management/EducationalSecretary.jpeg",
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
                             ImagePath = "/img/management/CollegeSecretary.jpeg",
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
                             ImagePath = "/img/management/Principal.jpeg",
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
                             ImagePath = "/img/management/VicePrincipal.jpeg",
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
                             ImagePath = "/img/management/AcademicAdvisor.jpeg",
                             DisplayOrder = 6,
                         },
            lstManagementContent =
            [
                new ManagementContent
                {
                    Content = "Founder P. Balasubrahmaniam’s legacy and vision have been carefully nurtured, and his dream of transforming Sree Muthukumaraswamy College into a high-quality educational institution has been successfully realized",
                },
                new ManagementContent
                {
                    Content = "North Chennai has long faced challenges such as a low standard of living and a high proportion of underprivileged children. Recognizing this reality, our Founder sowed the seeds of this institution with the noble aim of providing quality education to this region. Today, the institution has grown into one of the finest educational establishments in North Chennai, offering 15 academic programmes, including research degrees, and catering to over 1,800 students.",
                },
                new ManagementContent
                {
                    Content = "I firmly believe that, in line with the Founder’s vision, the institution continues to provide quality education and empowers students to achieve their goals and stand tall in society. Self-reliance is essential for every student, and it can be attained only through education. With this conviction, our dedicated teaching fraternity strives tirelessly to impart knowledge, skills, and values to our students.",
                },
                new ManagementContent
                {
                    Content = "Over the past 27 years, we have built a strong team of committed and competent faculty members who work diligently to turn students’ dreams into reality. The emphasis we place on education, career guidance, and placement support, along with the care we extend to every student, will have a profound impact on future generations. Dear students, both boys and girls, you are the greatest treasure before us. Explore your potential and find your rightful place in the world.",
                },
            ]
        }
    ];
}
