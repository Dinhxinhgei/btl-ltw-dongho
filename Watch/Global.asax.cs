﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Watch
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //user mặc định
            Application["Users"] = new List<User>();
            List<User> Users = (List<User>)Application["Users"];
            Users.Add(new User("user1", "user1@gmail.com", "user1", "user1"));
            Users.Add(new User("user2", "user2@gmail.com", "user2", "user2"));
            Users.Add(new User("user3", "user3@gmail.com", "user3", "user3"));
            Users.Add(new User("user4", "user4@gmail.com", "user4", "user4"));
            //tk admin mặc định
            Application["Admin"] = new List<User>();
            List<User> admin = (List<User>)Application["Admin"];
            admin.Add(new User("admin", "admin@gmail.com", "admin", "admin"));

            //sp mặc định
            Application["ProductList"] = new List<SanPham>();
            List<SanPham> ProductList = new List<SanPham>();
            //recommend DW 1-4
            ProductList.Add(new SanPham() { Id = 1, Images = "img/iconic link emerald.png", Name = "DW CLASSIC READING", Price = 4500000, Color = "Gold", Detail = "Classic Reading có dây đeo bằng da dập vân croc màu đen, mặt số màu đen và vỏ siêu mỏng 6mm. Cho dù bạn đang tham dự một sự kiện trang trọng, chơi tennis hay tận hưởng một ngày nắng đẹp tại câu lạc bộ đồng quê, chiếc đồng hồ này là một sự lựa chọn tuyệt vời và sẽ bổ sung cho mọi bộ trang phục của bạn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 2, Images = "img/iconic link amber.png", Name = "DW ICONIC LINK AMBER", Price = 5500000, Color = "Gold", Detail = "Iconic Link Amber có mặt số màu nâu nhạt với lớp hoàn thiện bằng tia nắng. Một màu sắc rực rỡ liên quan đến sự ấm áp, năng lượng và táo bạo. Được chế tác bằng thép không gỉ đánh bóng, có sẵn lớp mạ vàng hồng tinh tế. Một chiếc đồng hồ bắt mắt mang đến nét độc đáo cho vẻ ngoài của bạn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 3, Images = "img/Iconic link arctic.png", Name = "DW ICONIC LINK ARCTIC", Price = 6500000, Color = "Gold", Detail = "Iconic Link Arctic với mặt đồng hồ xanh dương sẫm. Màu sắc của bầu trời mênh mông và mặt biển băng điềm đạm tĩnh lặng. Kết hợp hoàn hảo cùng sắc bạc cho tổng thể hoàn chỉnh. Một điểm nhấn mang tính biểu tượng cho phong cách của bạn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 4, Images = "img/dw classic reading.png", Name = "DW ICONIC LINK EMERALD", Price = 3500000, Color = "Gold", Detail = "Đồng hồ Iconic Link Emerald với mặt đồng hồ xanh lá ấn tượng. Được tỉ mỉ trên những chi tiết bạc và vàng hồng đầy tinh tế. Một thiết kế ấn tượng với mặt đồng hồ màu lục, sự lôi cuốn giúp bạn nổi bật phong cách và thu hút mọi ánh nhìn." ,Type="Men"});
            //recommend HL 5-8
            ProductList.Add(new SanPham() { Id = 5, Images = "img/hublot bigbang blue.png", Name = "HUBLOT BIGBANG BLUE KING DIAMOND", Price = 350000000, Color = "Blue", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 6, Images = "img/hublot bigbang one click king gold diamonds.png", Name = "HUBLOT BIGBANG ONECLICK KING GOLD", Price = 450000000, Color = "Gold", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 7, Images = "img/hublot classic fusion black titanium diamonds.jpg", Name = "HUBLOT BIGBANG FUSION BLACK TITANIUM", Price = 550000000, Color = "Black", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 8, Images = "img/hublot-classic-fusion-orlinski-king-gold.png", Name = "HUBLOT CLASSIC FUSION AEROFUSION", Price = 550000000, Color = "Gold", Detail = "Đồng hồ nam Casio MTP-1381L-9AVDF với kiểu dáng thời trang dành cho nam, kim chỉ và vạch số to rõ nổi bật trên mặt đồng hồ tròn to nam tính, phối cùng với dây đeo bằng da nâu lịch lãm." ,Type="Men"});
            //List DW Nam 10-25
            ProductList.Add(new SanPham() { Id = 10, Images = "img/dw classic reading.png", Name = "DW CLASSIC READING", Price = 4500000, Color = "Black", Detail = "Classic Reading có dây đeo bằng da dập vân croc màu đen, mặt số màu đen và vỏ siêu mỏng 6mm. Cho dù bạn đang tham dự một sự kiện trang trọng, chơi tennis hay tận hưởng một ngày nắng đẹp tại câu lạc bộ đồng quê, chiếc đồng hồ này là một sự lựa chọn tuyệt vời và sẽ bổ sung cho mọi bộ trang phục của bạn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 11, Images = "img/Iconic-link-automatic.jpg", Name = "DW ICONIC LINK AUTOMATIC", Price = 5500000, Color = "Silver", Detail = "The Iconic Link Automatic là mẫu đồng hồ với cải tiến tối ưu nhất của chúng tôi cho đến nay với bộ chuyển động tự lên dây cót chuyển động trên cổ tay của bạn. Mặt đồng hồ dạ quang có kim và vạch chỉ phút phát sáng trong bóng tối, với màn hình hiển thị ngày trên mặt đồng hồ và có khả năng chống nước tới 100m. Tinh thể sapphire chống xước ở mặt trước cùng mặt sau hiển thị rõ nét động cơ máy tự động bên trong, sự lựa chọn đồng hồ tối ưu nhất dành cho bạn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 12, Images = "img/dw classic sheffield.png", Name = "DW CLASSIC SHEFFIELD", Price = 4500000, Color = "Black", Detail = "Với chất liệu da sẫm màu hơn những nơi sâu nhất của đại dương, Classic Sheffield được thiết kế cẩn thận để có thể đứng vững trước thử thách của thời gian trong khi vẫn giữ được vẻ đẹp không tỳ vết của nó. Tác phẩm tối giản này chứng minh rằng đơn giản không có nghĩa là nhàm chán." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 13, Images = "img/Iconic-motion.jpg", Name = "DW ICONIC MOTION", Price = 4500000, Color = "Black", Detail = "Iconic Motion là mẫu đồng hồ với khả năng chống nước ưu việt nhất tới thời điểm này của chúng tôi. Với khả năng chống nước tới 10 ATM và dây đeo chất liệu cao su tổng hợp cao cấp FKM. Thiết kế nổi bật với những chi tiết vàng hồng và bạc tinh tế, đây chắc chắn sẽ là một điểm nhấn hoàn hảo cho một phong cách năng động và ấn tượng." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 14, Images = "img/iconic link amber.png", Name = "DW ICONIC LINK AMBER", Price = 5500000, Color = "Gold", Detail = "Iconic Link Amber có mặt số màu nâu nhạt với lớp hoàn thiện bằng tia nắng. Một màu sắc rực rỡ liên quan đến sự ấm áp, năng lượng và táo bạo. Được chế tác bằng thép không gỉ đánh bóng, có sẵn lớp mạ vàng hồng tinh tế. Một chiếc đồng hồ bắt mắt mang đến nét độc đáo cho vẻ ngoài của bạn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 15, Images = "img/Iconic link arctic.png", Name = "DW ICONIC LINK ARCTIC", Price = 6500000, Color = "Silver", Detail = "Iconic Link Arctic với mặt đồng hồ xanh dương sẫm. Màu sắc của bầu trời mênh mông và mặt biển băng điềm đạm tĩnh lặng. Kết hợp hoàn hảo cùng sắc bạc cho tổng thể hoàn chỉnh. Một điểm nhấn mang tính biểu tượng cho phong cách của bạn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 16, Images = "img/iconic link emerald.png", Name = "DW ICONIC LINK EMERALD", Price = 3500000, Color = "Gold", Detail = "Iconic Link Emerald với mặt đồng hồ xanh lá ấn tượng. Được tỉ mỉ trên những chi tiết bạc và vàng hồng đầy tinh tế. Một thiết kế ấn tượng với mặt đồng hồ màu lục, sự lôi cuốn giúp bạn nổi bật phong cách và thu hút mọi ánh nhìn." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 17, Images = "img/dw classic glasgow.png", Name = "DW CLASSIC GLASGOW", Price = 6500000, Color = "Silver", Detail = "Đây là một chiếc đồng hồ tuyệt đẹp tôn vinh tinh thần hải lý vượt thời gian và thanh lịch, ghi lại những gì tinh túy nhất của một mùa hè bên đại dương. Hoàn hảo cho những ai biết rằng phụ kiện phù hợp tạo nên sự khác biệt." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 18, Images = "img/dw classic st mawes.png", Name = "DW CLASSIC BLACK ST MAWES", Price = 6500000, Color = "Rose Gold", Detail = "Với dây đeo bằng da màu nâu sang trọng và mặt số đen thanh lịch, Classic St. Mawes chứng minh rằng sự hoàn hảo trong kỹ thuật không chỉ là khả năng mà còn là hiện thực." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 19, Images = "img/dw classic yolk.png", Name = "DW CLASSIC YOLK", Price = 4500000, Color = "Gold", Detail = "Với dây đeo bằng da cá sấu màu nâu sẫm tuyệt đẹp, mặt số màu trắng vỏ trứng và vỏ chỉ mỏng 6mm, thật khó để không yêu chiếc đồng hồ được chế tạo hoàn hảo này. Lấy cảm hứng từ thời gian đơn giản hơn, chiếc đồng hồ này được chế tạo để đứng vững trước thử thách của thời gian." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 20, Images = "img/dw classic oxford.png", Name = "DW CLASSIC OXFORD", Price = 6500000, Color = "Silver", Detail = "Chiếc đồng hồ cổ điển và đầy tính thẩm mỹ này được thiết kế rất chú trọng đến từng chi tiết. Màu sắc vui tươi của dây đeo NATO kết hợp tự nhiên với mặt số đơn giản và tối giản, dễ dàng tạo ra phụ kiện hoàn hảo." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 21, Images = "img/dw classic cambridge.png", Name = "DW CLASSIC CAMBRIDGE", Price = 6000000, Color = "Gold", Detail = "Lấy cảm hứng từ màu sắc tuyệt đẹp của một lá cờ cổ điển, ban nhạc NATO màu đỏ, trắng và xanh này tôn vinh thời trang Mỹ thời thượng vượt thời gian. Dây đeo vui tươi, khi được kết hợp với mặt số đơn giản và mỏng thanh lịch, mang đến cho bạn một chiếc đồng hồ có thể đeo ở cả cơ quan và sau giờ làm việc." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 22, Images = "img/dw classic glasgow.png", Name = "DW CLASSIC CANTERBURY", Price = 4500000, Color = "Silver", Detail = "Lấy cảm hứng từ màu sắc tuyệt đẹp của một lá cờ cổ điển, ban nhạc NATO màu đỏ, trắng và xanh này tôn vinh thời trang Mỹ thời thượng vượt thời gian. Dây đeo vui tươi, khi được kết hợp với mặt số đơn giản và mỏng thanh lịch, mang đến cho bạn một chiếc đồng hồ có thể đeo ở cả cơ quan và sau giờ làm việc." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 23, Images = "img/dw classic southampton.png", Name = "DW CLASSIC SOUTHAMPTON", Price = 5500000, Color = "Gold", Detail = "Vỏ siêu mỏng, mặt số màu trắng vỏ trứng và thiết kế tròn hoàn hảo. Khi bạn thêm dây đeo NATO màu hồng, trắng và xanh lam, bạn sẽ có được một chiếc đồng hồ vui nhộn, tối giản, sang trọng và thanh lịch - cùng một lúc." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 24, Images = "img/dw classic warwick.png", Name = "DW CLASSIC WARWICK", Price = 4500000, Color = "Gold", Detail = "Màu xanh lam, màu của bầu trời và biển cả, hòa quyện tự nhiên với màu xanh lá cây, màu tuyệt đẹp của thiên nhiên. Sự kết hợp màu sắc của dây đeo NATO, khi kết hợp với lớp hoàn thiện sang trọng của mặt số, mang đến cho bạn một chiếc đồng hồ thanh lịch, hoàn hảo cho cả trang phục hàng ngày và các sự kiện đặc biệt." ,Type="Men"});
            ProductList.Add(new SanPham() { Id = 25, Images = "img/dw classic bayswater.png", Name = "DW CLASSIC BAYSWATER", Price = 6500000, Color = "Silver", Detail = "Với các đặc điểm cổ điển như vỏ mỏng, các chi tiết bằng vàng hồng hoặc bạc và dây đeo NATO có màu xanh dương nửa đêm di sản của chúng tôi, Classic Bayswater là một chiếc đồng hồ đeo tay dễ dàng cả ngày lẫn đêm." ,Type="Men"});

            //List DW Nữ 30-45
            ProductList.Add(new SanPham() { Id = 30, Images = "img/DW-ClassicSuffolk.jpg", Name = "DW CLASSIC SUFFOLK", Price = 4500000, Color = "Rose Gold", Detail = "Với dây đeo màu đỏ mộc mạc được làm từ da thật, Classic Suffolk là sản phẩm chủ lực và chắc chắn sẽ thu hút ánh nhìn của mọi người bạn gặp. Với thiết kế mỏng, mặt đồng hồ màu trắng trứng và các chi tiết bằng vàng hồng hoặc thép không gỉ, chiếc đồng hồ tinh xảo này sẽ đứng trước thử thách của thời gian." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 31, Images = "img/dw classic pressed strerling.png", Name = "DW QUADRO PRESSED STERLING", Price = 7500000, Color = "Silver", Detail = "Quadro là mẫu đồng hồ mặt vuông đầu tiên của chúng tôi. Với mặt đồng hồ vuông trắng, đen và xanh lục kết hợp hoàn hảo với dây đeo lưới mesh strap và dây da kiểu mới trên tông màu chủ đạo quen thuộc vàng hồng và bạc. Một sự lựa chọn hào hảo bổ sung thêm chút nhấn nhá góc cạnh và sang trọng trên bộ trang phục hàng ngày của bạn." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 32, Images = "img/Iconic-motion-ruby.jpg", Name = "DW ICONIC MOTION RUBY", Price = 5500000, Color = "Rose Gold", Detail = "Iconic Motion là chiếc đồng hồ chống nước đầu tiên của chúng tôi, có đầu đồng hồ chống nước 10 ATM được nâng cấp và dây đeo hoàn toàn mới được làm từ cao su tổng hợp có tên FKM. Red Iconic Motion là một chiếc đồng hồ phiên bản đặc biệt được thiết kế riêng cho lễ hội năm mới của Trung Quốc. Đồng hồ có dây đeo FKM và mặt số có tông màu đỏ phù hợp." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 33, Images = "img/dw quadro pressed unitone.png", Name = "DW QUADRO PRESSED UNITONE", Price = 6500000, Color = "Rose Gold", Detail = "Quadro Unitone có dây đeo lưới bằng vàng hồng và mặt đồng hồ hình vuông kết hợp liền mạch.Được chế tác bằng thép không gỉ đánh bóng được thiết kế để tạo ra một tuyên bố tinh tế.Một chiếc đồng hồ thiết lập giai điệu cho bất kỳ dịp nào." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 34, Images = "img/iconic link amber.png", Name = "DW ICONIC LINK AMBER", Price = 5500000, Color = "Rose Gold", Detail = "Iconic Link Amber có mặt số màu nâu nhạt với lớp hoàn thiện bằng tia nắng. Một màu sắc rực rỡ liên quan đến sự ấm áp, năng lượng và táo bạo. Được chế tác bằng thép không gỉ đánh bóng, có sẵn lớp mạ vàng hồng tinh tế. Một chiếc đồng hồ bắt mắt mang đến nét độc đáo cho vẻ ngoài của bạn." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 35, Images = "img/dw petite unitone.png", Name = "DW PETITE UNITONE", Price = 6000000, Color = "Gold", Detail = "The Petite Unitone với sự kết hợp hoàn hảo hài hòa về màu sắc vàng hồng tinh tế trên cả mặt và dây đồng hồ. Chất liệu thanh thoát bền bỉ giúp bạn nổi bật phong cách và tạo nét thu hút vô cùng thanh lịch." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 36, Images = "img/iconic link emerald.png", Name = "DW ICONIC LINK EMERALD", Price = 6000000, Color = "Rose Gold", Detail = "Đồng hồ Iconic Link Emerald với mặt đồng hồ xanh lá ấn tượng. Được tỉ mỉ trên những chi tiết bạc và vàng hồng đầy tinh tế. Một thiết kế ấn tượng với mặt đồng hồ màu lục, sự lôi cuốn giúp bạn nổi bật phong cách và thu hút mọi ánh nhìn." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 37, Images = "img/quadro pressed suffolk.png", Name = "DWQUADRO PRESSED SUFFOLK", Price = 5500000, Color = "Rose Gold", Detail = "Quadro là chiếc đồng hồ mặt số vuông đầu tiên của chúng tôi, được chế tác bằng thép không gỉ đánh bóng và có lớp mạ vàng hồng tinh tế. Dây đồng hồ bằng da ép màu đỏ lá phong kết hợp hoàn hảo với các chi tiết màu trắng và vàng hồng cổ điển. Nâng tầm vẻ ngoài của bạn với một góc cạnh độc đáo." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 38, Images = "img/dw quadro pressed rouge.png", Name = "DW QUADRO PRESSED ROUGE", Price = 6500000, Color = "Rose Gold", Detail = "Quadro Rouge có mặt số làm bằng ngọc trai màu hồng lấp lánh. Một món đồ hàng ngày mang hơi thở thanh lịch. Được biết đến với ánh kim tuyệt đẹp và tính chất có một không hai, mặt số mới này làm cho mỗi chiếc đồng hồ trở nên độc đáo và khác biệt. Bổ sung với dây đeo bằng da ép họa tiết croc màu hồng nude, được chế tác bằng thép không gỉ và mạ vàng hồng tinh tế. Một chiếc đồng hồ hình vuông nhỏ nhắn với mặt số xà cừ độc đáo. Nó được kết hợp với dây da màu hồng nude để nâng tầm cho bất kỳ bộ trang phục nào. Tìm thêm đồng hồ vuông trong bộ sưu tập Quadro của chúng tôi." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 39, Images = "img/dw quadro pressed melrose.png", Name = "DW QUADRO PRESSED MELROSE", Price = 4500000, Color = "Rose Gold", Detail = "Quadro Pressed Melrose có mặt số làm bằng ngọc trai màu hồng lấp lánh. Một món đồ hàng ngày mang hơi thở thanh lịch. Được biết đến với ánh kim tuyệt đẹp và tính chất có một không hai, mặt số mới này làm cho mỗi chiếc đồng hồ trở nên độc đáo và khác biệt. Bổ sung với dây đeo dạng lưới ép sang trọng, được chế tác bằng thép không gỉ và mạ vàng hồng tinh tế. Đồng hồ mặt vuông trở thành một phụ kiện thanh lịch, đặc biệt là với dây đeo đồng hồ mỏng dạng lưới này. Đồng hồ này là một phần của bộ sưu tập Quadro của chúng tôi." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 40, Images = "img/dw petite melrose pearl.png", Name = "DW PETIRE MELROSE PEARL", Price = 6500000, Color = "Gold", Detail = "Petite Pearl có mặt số làm bằng ngọc trai màu hồng lấp lánh. Một chiếc đồng hồ hàng ngày mang hơi thở thanh lịch. Được biết đến với ánh kim tuyệt đẹp và tính chất có một không hai, mặt số mới này làm cho mỗi chiếc đồng hồ trở nên độc đáo và khác biệt. Bổ sung với dây đeo dạng lưới sang trọng, được chế tác bằng thép không gỉ và mạ vàng hồng tinh tế." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 41, Images = "img/dw petite coral.png", Name = "DW PETITE CORAL", Price = 5000000, Color = "Rose Gold", Detail = "Petite Coral có mặt số làm bằng ngọc trai màu hồng lấp lánh. Một món đồ hàng ngày mang hơi thở thanh lịch. Được biết đến với ánh kim tuyệt đẹp và tính chất có một không hai, mặt số mới này làm cho mỗi chiếc đồng hồ trở nên độc đáo và khác biệt. Bổ sung với dây đeo NATO màu hồng nude, được chế tác bằng thép không gỉ và mạ vàng hồng tinh tế." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 42, Images = "img/dw quadro studio.png", Name = "DW QUADRO STUDIO", Price = 5500000, Color = "Gold", Detail = "Quadro Studio sở hữu mặt số hình vuông màu trắng tinh tế và nhỏ nhắn, có thêm dây đeo Piano kiểu dáng hợp thời trang. Được chế tác bằng thép không gỉ đánh bóng và mạ vàng hồng tinh tế. Một tuyệt tác cổ điển với sức hút vượt thời gian." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 43, Images = "img/dw quadro studio silver.png", Name = "DW QUADRO STUDIO", Price = 5500000, Color = "Silver", Detail = "Quadro Studio sở hữu mặt số hình vuông màu trắng tinh tế và nhỏ nhắn, có thêm dây đeo Piano kiểu dáng hợp thời trang. Được chế tác bằng thép không gỉ đánh bóng và mạ vàng hồng tinh tế. Một tuyệt tác cổ điển với sức hút vượt thời gian. " ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 44, Images = "img/dw petite rosewater.png", Name = "DW PETITE ROSEWATER", Price = 6000000, Color = "Rose Gold", Detail = "Petite Rosewater sở hữu mặt số trắng và dây đồng hồ NATO hồng ngọt ngào quyến rũ. Chiếc đồng hồ này mang đến cho bạn phong cách nhẹ nhàng, bắt mắt, cùng màu sắc vô cùng lý tưởng cho mùa xuân này. Dây đồng hồ màu hồng tinh tế khi kết hợp với các chi tiết vàng hồng sang trọng Rosewater sẽ khiến bạn trở nên rực rỡ, tỏa sáng mà tinh khôi với mọi trang phục." ,Type="Women"});
            ProductList.Add(new SanPham() { Id = 45, Images = "img/dw petite dover.png", Name = "DW PETITE DOVER", Price = 3500000, Color = "Rose Gold", Detail = "Những vách đá trắng của Dover đã truyền cảm hứng cho Người Dover nhỏ bé của chúng tôi. Với mặt số màu trắng vỏ trứng, các chi tiết bằng vàng hồng và dây đeo toàn màu trắng, nó thể hiện được bản chất của mùa hè. Tạo một giao diện Cổ điển sẽ nổi bật mọi lúc mọi nơi." ,Type="Women"});

            //List HL Nam 50-57
            ProductList.Add(new SanPham() { Id = 50, Images = "img/hublot unico sang bleu II Titanium.png", Name = "HUBLOT UNICO SANG BLEU II TITANIUM", Price = 350000000, Color = "Silver", Detail = "Cùng với nghệ thuật đương đại Art of Fusion, Hublot đã có sự kết hợp tuyệt vời để tạo nên BIG BANG UNICO SANG BLEU II TITANIUM 45mm mang dấu ấn của nghệ thuật đương đại với mặt số bao gồm hệ thống hình học 5 tầng sắc nhọn xếp chồng gây ấn tượng mạnh với chất liệu Titanium cùng dây cao su đen cao cấp có họa tiết tương đồng với mặt số." ,Type="Men,Special"});
            ProductList.Add(new SanPham() { Id = 51, Images = "img/hublot-big-bang-sang-bleu-titanium-blue.png", Name = "HUBLOT BIGBANG SANG BLEU TITANIUM", Color = "Blue", Price = 350000000, Detail = "Lần đầu tiên được ra mắt năm 2017, đồng hồ Hublot Big Bang Sang Bleu Titanium Pave hấp dẫn ánh mắt của người đối diện với từng góc cạnh tinh tế của mặt số chiếc đồng hồ với hệ thống hình học sắc nhọn xếp chồng ăn ý đầy nghệ thuật và sự tỏa sáng rực rỡ của những viên kim cương gắn trên toàn bộ vỏ đồng hồ." ,Type="Men,Special"});
            ProductList.Add(new SanPham() { Id = 52, Images = "img/hublot-classic-fusion-blue-titanium.png", Name = "HUBLOT CLASSIC FUSION BLUE TITANIUM", Color = "Blue", Price = 450000000, Detail = "Đồng hồ Hublot đang dần trở nên có chỗ đứng trong ngành công nghiệp chế tác đồng hồ cơ học. Bạn chỉ cần phải trả một mức giá rất vừa phải để có thể sở hữu một chiếc đồng hồ đẹp, sành điệu nhưng không kém phần sang trọng và năng động. Cũng chính bởi lý do ấy, Hublot ngày càng nổi tiếng và trở thành cái tên đáng gờm trong phân khúc đồng hồ cao cấp." ,Type="Men,Special"});
            ProductList.Add(new SanPham() { Id = 53, Images = "img/hublot-classic-fusion-orlinski-king-gold.png", Name = "HUBLOT CLASSIC FUSION ORLINSKI KING", Color = "Gold", Price = 450000000, Detail = "Tương tự với Sang Bleu, dòng Orlinski cũng là sự kết hợp của Hublot với một nghệ sĩ đương đại, có thiết kế hoàn toàn khác biệt. Tất nhiên, chúng ta vẫn sẽ có những chi tiết quen thuộc của thương hiệu Hublot. Để đi sâu hơn, ta hãy cùng phân tích từng chi tiết trên phiên bản này." ,Type="Men,Special"});
            ProductList.Add(new SanPham() { Id = 54, Images = "img/hublot classic fusion black titanium diamonds.jpg", Name = "HUBLOT CLASSIC FUSION BLACK TITANIUM", Color = "Black", Price = 550000000, Detail = "Chiếc đồng hồ sở hữu trên mình diện mạo đặc trưng với bộ vỏ từ titanium đẳng cấp, kết hợp cùng dây đeo tay cao su. Kích thước 42mm vừa phải, gọn gàng rất phù hợp với cổ tay đàn ông Việt Nam bởi thiết kế rất thông minh và chắc chắn, hoàn toàn phù hợp với những quý ông theo đuổi phong cách thời trang mạnh mẽ." ,Type="Men,Special"});
            ProductList.Add(new SanPham() { Id = 55, Images = "img/HUBLOT-SPIRIT-OF-BIG-BANG-TITANIUM.png", Name = "HUBLOT SPIRIT OF BIGBANG TITANIUM", Color = "Silver", Price = 500000000, Detail = "Sở hữu diện mạo tráng lệ với sức hút mãnh liệt chiếc đồng hồ Hublot Spirit Of Big Bang Titanium 42mm xứng đáng là một đại diện nổi bật nhất trong bộ sưu tập Hublot Spirit Of Big Bang." ,Type="Men,Special"});
            ProductList.Add(new SanPham() { Id = 56, Images = "img/hublot classic fusion aerofusion.png", Name = "HUBLOT CLASSIC FUSION AEROFUSION", Color = "Gold", Price =600000000, Detail = "Kiến tạo những cỗ máy thời gian mang đậm vẻ đẹp của nghệ thuật đương đại, thương hiệu Hublot đã xây dựng thành công bộ sưu tập đồng hồ Classic Fusion mang đậm phong cách thanh lịch, hiện đại và thời thượng. Là một thành viên của bộ sưu tập vang danh đó, chiếc Hublot Classic Fusion Aerofusion 45 525.NX.0170.LR đã mê hoặc nhiều tín đồ đồng hồ ngay từ khi mới ra mắt." ,Type="Men,Special"});
            ProductList.Add(new SanPham() { Id = 57, Images = "img/hublot classic fusion quartzz.png", Name = "HUBLOT CLASSIC FUSION QUARTZ", Color = "Gold", Price = 650000000, Detail = "Hublot Classic Fusion Quartz Gold 581.OX.1180.RX có mặt tại Gia Bảo Luxury trong lớp vỏ vàng hồng 18k có kích thước 33mm. Sở hữu thiết kế “kinh điển” nhất của thương hiệu Hublot, chiếc đồng hồ này không chỉ toát lên vẻ đẹp sang trọng, đẳng cấp mà còn mang hơi thở của xu hướng thời trang hiện đại, đáp ứng thị hiếu và yêu cầu sử dụng của đông đảo khách hàng trên toàn thế giới" ,Type="Men,Special"});

            //List HL Nữ 60-67
            ProductList.Add(new SanPham() { Id = 60, Images = "img/hublot bigbag chronoghraph gold blue.jpg", Name = "HUBLOT BIGBANG CHRONOGHRAPH", Color = "Gold", Price =400000000, Detail = "Là bước đi đầy chiến lược trong thế kỷ XXI của nhà sản xuất Hublot, Big Bang nhanh chóng trở thành dòng đồng hồ được yêu thích nhất của hãng. Chiếm trọn cảm tính của fan hâm mộ với thiết kế biểu tượng, hài hòa trong tổng thể thiết kế, dòng đồng hồ Big Bang ngày nay được xem là mũi nhọn khiến Hublot phát triển nhanh chóng cho đến ngày nay." ,Type="Women,Special"});
            ProductList.Add(new SanPham() { Id = 61, Images = "img/hublot oneclick sapphire diamond blue.png", Name = "HUBLOT ONECLICK SAPPHIRE DIAMOND BLUE", Color = "Blue", Price = 750000000, Detail = "Đối với chiếc đồng hồ này, lớp vỏ sapphire của đồng hồ có màu xanh lam nhẹ nhàng. Viền bezel bằng thép không gỉ được đính 42 viên kim cương khoảng 1.00ct, mang đến một điểm nhấn lấp lánh trên cổ tay người đeo. Bên cạnh đó, thiết kế Big Bang trứ danh vẫn in đậm dấu ấn thiết kế khi xuất hiện cùng vành bezel là 6 ốc vít titanium hình trữ H." ,Type="Women,Special"});
            ProductList.Add(new SanPham() { Id = 62, Images = "img/hublot bigbang one click king gold diamonds.png", Name = "HUBLOT BIGBANG ONECLICK KING GOLD DIAMONDS", Color = "White", Price = 650000000, Detail = "Hublot Spirit Of Big Bang, chiếc đồng hồ này sở hữu một kích thước thuộc hàng khủng: 45mm cùng với chất liệu titanium siêu bền nhẹ và cứng cỗ máy này lại không quá nặng nhưng vẫn đầm tay. " ,Type="Women,Special"});
            ProductList.Add(new SanPham() { Id = 63, Images = "img/hublot bigbang blue.png", Name = "HUBLOT BIGBANG BLUE", Color = "Blue", Price = 450000000, Detail = "Hiện đại, trẻ trung là những gì giới mộ điệu đánh giá cao từng cỗ máy thời gian đến từ nhà sản xuất năng động Hublot. Sáng tạo, khác biệt trong chiến lược marketing, đi kèm chất lượng ổn định, ngày nay đồng hồ Hublot nhận được sự đón nhận nồng nhiệt của cả nam và nữ." ,Type="Women,Special"});
            ProductList.Add(new SanPham() { Id = 64, Images = "img/hublot unico sang bleu II Titanium.png", Name = "HUBLOT UNICO SANG BLEU II TITANIUM", Price = 350000000, Color = "Silver", Detail = "Cùng với nghệ thuật đương đại Art of Fusion, Hublot đã có sự kết hợp tuyệt vời để tạo nên BIG BANG UNICO SANG BLEU II TITANIUM 45mm mang dấu ấn của nghệ thuật đương đại với mặt số bao gồm hệ thống hình học 5 tầng sắc nhọn xếp chồng gây ấn tượng mạnh với chất liệu Titanium cùng dây cao su đen cao cấp có họa tiết tương đồng với mặt số." ,Type="Women,Special"});
            ProductList.Add(new SanPham() { Id = 65, Images = "img/hublot-classic-fusion-orlinski-king-gold.png", Name = "HUBLOT CLASSIC FUSION ORLINSKI KING", Color = "Gold", Price = 450000000, Detail = "Tương tự với Sang Bleu, dòng Orlinski cũng là sự kết hợp của Hublot với một nghệ sĩ đương đại, có thiết kế hoàn toàn khác biệt. Tất nhiên, chúng ta vẫn sẽ có những chi tiết quen thuộc của thương hiệu Hublot. Để đi sâu hơn, ta hãy cùng phân tích từng chi tiết trên phiên bản này." ,Type="Women,Special"});
            ProductList.Add(new SanPham() { Id = 66, Images = "img/hublot classic fusion aerofusion.png", Name = "HUBLOT CLASSIC FUSION AEROFUSION", Color = "Gold", Price =600000000, Detail = "Kiến tạo những cỗ máy thời gian mang đậm vẻ đẹp của nghệ thuật đương đại, thương hiệu Hublot đã xây dựng thành công bộ sưu tập đồng hồ Classic Fusion mang đậm phong cách thanh lịch, hiện đại và thời thượng. Là một thành viên của bộ sưu tập vang danh đó, chiếc Hublot Classic Fusion Aerofusion 45 525.NX.0170.LR đã mê hoặc nhiều tín đồ đồng hồ ngay từ khi mới ra mắt." ,Type="Women,Special"});
            ProductList.Add(new SanPham() { Id = 67, Images = "img/hublot oneclick sapphire diamond.png", Name = "HUBLOT ONECLICK SAPPHIRE DIAMOND", Color = "Silver", Price = 750000000, Detail = "Đối với chiếc đồng hồ này, lớp vỏ sapphire của đồng hồ có màu xanh lam nhẹ nhàng. Viền bezel bằng thép không gỉ được đính 42 viên kim cương khoảng 1.00ct, mang đến một điểm nhấn lấp lánh trên cổ tay người đeo. Bên cạnh đó, thiết kế Big Bang trứ danh vẫn in đậm dấu ấn thiết kế khi xuất hiện cùng vành bezel là 6 ốc vít titanium hình trữ H." ,Type="Women,Special"});

            //List DW nam mới 26-29 || List HL nam mới 70-73
            //List DW nữ mới 46-49 || List HL nữ mới 80-83
            Application["ProductList"] = ProductList;

            // Gio hang
            Application["CartList"] = new List<Cart>();
            

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["username"] = null;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}