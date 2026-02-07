function LoaderShow() {
    $('.clsPreloaderArea').show();
}
function LoaderHide() {
    $('.clsPreloaderArea').fadeOut();
}
function GetDefaultData() {
    LoaderShow()
    $.ajax({
        url: defaultDataUrl,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            BuildMenu(data["menu"])
            BuildSetting(data["setting"])
            LoaderHide()
        },
        error: function (err) {
            console.error("Failed to load menu", err);
            LoaderHide()
        }
    });
}

function BuildMenu(data) {
    $("#navbarSupportedContent .nav-item .nav-link").hide();
    $(".clsMenu-Home").show();
    $.each(data, function (i, y) {
        if (y["menuName"] == "About") {
            $(".clsMenu-About").show()
        }
        else if (y["menuName"] == "Vision & Mission") {
            $(".clsMenu-VisionMission").show()
        }
        else if (y["menuName"] == "Management Message") {
            $(".clsMenu-ManagementMessage").show()
        }
        else if (y["menuName"] == "History & Profile") {
            $(".clsMenu-History").show()
        }
        else if (y["menuName"] == "Accreditation / Affiliation") {
            $(".clsMenu-Accreditation").show()
        }
        else if (y["menuName"] == "Academics") {
            $(".clsMenu-Academics").show()
        }
        else if (y["menuName"] == "Programmes Offered") {
            $(".clsMenu-ProgrammesOffered").show()
        }
        else if (y["menuName"] == "Departments") {
            $(".clsMenu-Departments").show()
        }
        else if (y["menuName"] == "Academic Calendar") {
            $(".clsMenu-AcademicCalendar").show()
        }
        else if (y["menuName"] == "Placement") {
            $(".clsMenu-Placement").show()
        }
        else if (y["menuName"] == "Admissions") {
            $(".clsMenu-Admissions").show()
        }
        else if (y["menuName"] == "Admission Procedure") {
            $(".clsMenu-Admission").show()
        }
        else if (y["menuName"] == "Courses & Eligibility") {
            $(".clsMenu-Courses").show()
        }
        else if (y["menuName"] == "Fee Structure") {
            $(".clsMenu-FeeStructure").show()
        }
        else if (y["menuName"] == "Apply Online / Prospectus") {
            $(".clsMenu-Prospectus").show()
        }
        else if (y["menuName"] == "Campus Life") {
            $(".clsMenu-CampusLife").show()
        }
        else if (y["menuName"] == "Clubs & Activities") {
            $(".clsMenu-Clubs").show()
        }
        else if (y["menuName"] == "Events & Gallery") {
            $(".clsMenu-EventsGallery").show()
        }
        else if (y["menuName"] == "Student Support") {
            $(".clsMenu-StudentSupport").show()
        }
        else if (y["menuName"] == "Alumni") {
            $(".clsMenu-Alumni").show()
        }
        else if (y["menuName"] == "Quality Assurance") {
            $(".clsMenu-QualityAssurance").show()
        }
        else if (y["menuName"] == "IQAC Committee") {
            $(".clsMenu-IQAC").show()
        }
        else if (y["menuName"] == "AQAR Reports") {
            $(".clsMenu-AQAR").show()
        }
        else if (y["menuName"] == "NAC") {
            $(".clsMenu-NAC").show()
        }
        else if (y["menuName"] == "NIRF") {
            $(".clsMenu-NIRF").show()
        }
    });
}

function BuildSetting(data) {
    $(".clsApplication, .clsRunningText, .clsAcademicCalendar, .clsExaminations, .clsResults, .clsCoursesEligibility, .Fee Structure").hide()
    $.each(data, function (i, y) {
        if (y["key"] == "Application") {
            $(".clsApplication").show()
            $(".clsApplication").attr("href", y["value"])
        }
        else if (y["key"] == "Running Text") {
            $(".clsRunningText").show()
            $(".clsRunningText").val(y["value"])
        }
        else if (y["key"] == "Academic Calendar") {
            $(".clsAcademicCalendar").show()
            $(".clsAcademicCalendar").attr("href", y["value"])
        }
        else if (y["key"] == "Examinations") {
            $(".clsExaminations").show()
            $(".clsExaminations").attr("href", y["value"])
        }
        else if (y["key"] == "Results") {
            $(".clsResults").show()
            $(".clsResults").attr("href", y["value"])
        }
        else if (y["key"] == "Courses Eligibility") {
            $(".clsCoursesEligibility").show()
            $(".clsCoursesEligibility").attr("href", y["value"])
        }
        else if (y["key"] == "Fee Structure") {
            $(".clsFeeStructure").show()
            $(".clsFeeStructure").attr("href", y["value"])
        }
    });
}