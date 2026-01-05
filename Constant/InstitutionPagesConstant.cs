using College.Entities;

namespace College.Constant;

public static class InstitutionPagesConstant
{
    public static readonly List<InstitutionPages> lstInstitutionPages =
    [
        #region Vision Mission
        new InstitutionPages
        {
            PageType = "Vision_Mission",
            Heading = "Vision",
            Content = "To be a centre of academic excellence that nurtures intellectual growth, innovation and ethical values, empowering students to become responsible global citizens.",
        },
        new InstitutionPages
        {
            PageType = "Vision_Mission",
            Heading = "Mission",
            Content = @"<ul>
                            <li>Provide quality higher education that combines academic rigor with practical learning.</li>
                            <li>Foster an environment of innovation, leadership and lifelong learning.</li>
                            <li>Promote inclusivity and equal opportunity for all students.</li>
                            <li>Encourage ethical values, social responsibility and respect for cultural diversity.</li>
                            <li>Strengthen industry-academia collaboration for employability and entrepreneurship.</li>
                        </ul>",
        },
        new InstitutionPages
        {
            PageType = "Vision_Mission",
            Heading = "Core Values",
            Content = @"<ul>
                            <li><strong>Integrity:</strong> Upholding honesty and transparency in all activities.</li>
                            <li><strong>Excellence:</strong> Striving for the highest standards in teaching and learning.</li>
                            <li><strong>Innovation:</strong> Encouraging creativity and critical thinking.</li>
                            <li><strong>Respect:</strong> Valuing diversity, equality and human dignity.</li>
                            <li><strong>Service:</strong> Committing to community engagement and sustainable development.</li>
                        </ul>",
        },

        #endregion

        #region Student Support
        new InstitutionPages
        {
            PageType = "Student_Support",
            Heading = "Counselling Cell",
            Content = "<p>The Counselling Cell aims to promote students’ mental health and emotional well-being. It provides guidance to help students overcome academic, personal and social challenges through confidential and supportive counselling sessions.</p><ul><li>Encourages positive mental health and self-awareness.</li><li>Offers personal, academic and career-related counselling.</li><li>Organizes stress management and motivation workshops.</li><li>Supports students in adapting to campus life and academics.</li></ul>",
        },
        new InstitutionPages
        {
            PageType = "Student_Support",
            Heading = "Career Cell",
            Content = @"<p>The Career Cell is dedicated to guiding students toward promising career paths. It bridges the gap between academic learning and professional requirements by providing training, placement assistance and industry exposure.</p>
                        <ul>
                            <li>Organizes career guidance sessions, workshops and seminars.</li>
                            <li>Coordinates campus placement drives and internship opportunities.</li>
                            <li>Conducts resume-building, interview skills and aptitude training programs.</li>
                            <li>Collaborates with industry partners for student development and recruitment.</li>
                        </ul>",
        },
        new InstitutionPages
        {
            PageType = "Student_Support",
            Heading = "Objectives",
            Content = @"<ul>
                            <li>To provide psychological and career guidance to students in need.</li>
                            <li>To prepare students for both higher studies and employment opportunities.</li>
                            <li>To develop leadership qualities, communication and interpersonal skills.</li>
                            <li>To empower students to make informed career decisions with confidence.</li>
                        </ul>",
        },

        #endregion
    ];
}
