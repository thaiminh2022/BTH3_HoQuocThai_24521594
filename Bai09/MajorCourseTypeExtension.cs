namespace Bai09
{
    static class MajorCourseTypeExtension
    {
        public static string ToDisplayString(this MajorType t) {
            return t switch
            {
                MajorType.InformationTechnology => "Công nghệ Thông tin",
                MajorType.SystemThinking => "Hệ thống Thông tin",
                MajorType.ComputerScience => "Khoa học Máy tính",
                MajorType.SoftwareEngineering => "Kỹ thuật Phần mềm",
                MajorType.ComputerEngineering => "Kỹ thuật Máy tính",
                MajorType.ComputerNetworksAndCommunications => "Mạng máy tính và Truyền thông Dữ liệu",
                MajorType.InformationSecurity => "An toàn Thông tin",
                MajorType.ECommerce => "Thương mại Điện tử",
                MajorType.DataScience => "Khoa học Dữ liệu",
                MajorType.ArtificialIntelligence => "Trí tuệ Nhân tạo",
                MajorType.VLSIDesign => "Thiết kế Vi mạch",
                MajorType.MultiMedia => "Truyền thông Đa phương tiện",
                _ => throw new NotImplementedException(),
            };
        }

        public static string ToDisplayString(this RequireCourseType t)
        {
            return t switch
            {
                RequireCourseType.Calculus => "Giải tích",
                RequireCourseType.LinearAlgebra => "Đại số tuyến tính",
                RequireCourseType.DiscreteMathematics => "Toán rời rạc",
                RequireCourseType.ProbabilityAndStatistics => "Xác suất thống kê",

                RequireCourseType.IntroductionToProgramming => "Nhập môn Lập trình",
                RequireCourseType.DataStructuresAndAlgorithms => "Cấu trúc dữ liệu và giải thuật",
                RequireCourseType.ProgrammingTechniques => "Kỹ thuật Lập trình",

                RequireCourseType.IntroductionToComputerNetworks => "Nhập môn Mạng máy tính",
                RequireCourseType.ComputerArchitecture => "Kiến trúc máy tính",
                RequireCourseType.OperatingSystems => "Hệ điều hành",

                RequireCourseType.PhilosophyOfMarxismLeninism => "Triết học Mác - Lênin",
                RequireCourseType.PoliticalEconomyOfMarxismLeninism => "Kinh tế chính trị Mác - Lênin",
                RequireCourseType.ScientificSocialism => "Chủ nghĩa xã hội khoa học",
                RequireCourseType.HistoryOfCommunistPartyOfVietnam => "Lịch sử Đảng Cộng sản Việt Nam",
                RequireCourseType.HoChiMinhIdeology => "Tư tưởng Hồ Chí Minh",
                RequireCourseType.IntroductionToLaw => "Pháp luật đại cương",

                RequireCourseType.English1 => "Tiếng Anh 1",
                RequireCourseType.English2 => "Tiếng Anh 2",
                RequireCourseType.English3 => "Tiếng Anh 3",

                RequireCourseType.PhysicalEducation => "Giáo dục thể chất",
                RequireCourseType.NationalDefenseAndSecurityEducation => "Giáo dục Quốc phòng - An ninh",
                _ => throw new NotImplementedException(),
            };
        }
    }
}