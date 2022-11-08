using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShippingHelper.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHelper.Core.Configurations
{
    public class CitiesSeedConfiguration : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            builder.HasData(
                new Cities
                {
                    Id = 1,
                    Name= "Hồ Chí Minh",
                },
                new Cities
                {
                    Id = 2,
                    Name= "Hà Nội",
                },
                new Cities
                {
                    Id = 3,
                    Name= "Đà Nẵng",
                },
                new Cities
                {
                    Id = 4,
                    Name= "Bình Dương",
                },
                new Cities
                {
                    Id = 5,
                    Name= "Đồng Nai",
                },
                new Cities
                {
                    Id = 6,
                    Name= "Khánh Hòa",
                },
                new Cities
                {
                    Id = 7,
                    Name= "Hải Phòng",
                },
                new Cities
                {
                    Id = 8,
                    Name= "Long An",
                },
                new Cities
                {
                    Id = 9,
                    Name= "Quảng Nam",
                },
                new Cities
                {
                    Id = 10,
                    Name= "Bà Rịa Vũng Tàu",
                },
                new Cities
                {
                    Id = 11,
                    Name= "Đắk Lắk",
                },
                new Cities
                {
                    Id = 12,
                    Name= "Cần Thơ",
                },
                new Cities
                {
                    Id = 13,
                    Name= "Bình Thuận",
                },
                new Cities
                {
                    Id = 14,
                    Name= "Lâm Đồng",
                },
                new Cities
                {
                    Id = 15,
                    Name= "Thừa Thiên Huế",
                },
                new Cities
                {
                    Id = 16,
                    Name= "Kiên Giang",
                },
                new Cities
                {
                    Id = 17,
                    Name= "Bắc Ninh",
                },
                new Cities
                {
                    Id = 18,
                    Name= "Quảng Ninh",
                },
                new Cities
                {
                    Id = 19,
                    Name= "Thanh Hóa",
                },
                new Cities
                {
                    Id = 20,
                    Name= "Nghệ An",
                },
                new Cities
                {
                    Id = 21,
                    Name= "Hải Dương",
                },
                new Cities
                {
                    Id = 22,
                    Name= "Gia Lai",
                },
                new Cities
                {
                    Id = 23,
                    Name= "Bình Phước",
                },
                new Cities
                {
                    Id = 24,
                    Name= "Hưng Yên",
                },
                new Cities
                {
                    Id = 25,
                    Name= "Bình Định",
                },
                new Cities
                {
                    Id = 26,
                    Name= "Tiền Giang",
                },
                new Cities
                {
                    Id = 27,
                    Name= "Thái Bình",
                },
                new Cities
                {
                    Id = 28,
                    Name= "Bắc Giang",
                },
                new Cities
                {
                    Id = 29,
                    Name= "Hòa Bình",
                },
                new Cities
                {
                    Id = 30,
                    Name= "An Giang",
                },
                new Cities
                {
                    Id = 31,
                    Name= "Vĩnh Phúc",
                },
                new Cities
                {
                    Id = 32,
                    Name= "Tây Ninh",
                },
                new Cities
                {
                    Id = 33,
                    Name= "Thái Nguyên",
                },
                new Cities
                {
                    Id = 34,
                    Name= "Lào Cai",
                },
                new Cities
                {
                    Id = 35,
                    Name= "Nam Định",
                },
                new Cities
                {
                    Id = 36,
                    Name= "Quảng Ngãi",
                },
                new Cities
                {
                    Id = 37,
                    Name= "Bến Tre",
                },
                new Cities
                {
                    Id = 38,
                    Name= "Đắk Nông",
                },
                new Cities
                {
                    Id = 39,
                    Name= "Cà Mau",
                },
                new Cities
                {
                    Id = 40,
                    Name= "Vĩnh Long",
                },
                new Cities
                {
                    Id = 41,
                    Name= "Ninh Bình",
                },
                new Cities
                {
                    Id = 42,
                    Name= "Phú Thọ",
                },
                new Cities
                {
                    Id = 43,
                    Name= "Ninh Thuận",
                },
                new Cities
                {
                    Id = 44,
                    Name= "Phú Yên",
                },
                new Cities
                {
                    Id = 45,
                    Name= "Hà Nam",
                },
                new Cities
                {
                    Id = 46,
                    Name= "Hà Tĩnh",
                },
                new Cities
                {
                    Id = 47,
                    Name= "Đồng Tháp",
                },
                new Cities
                {
                    Id = 48,
                    Name= "Sóc Trăng",
                },
                new Cities
                {
                    Id = 49,
                    Name= "Kon Tum",
                },
                new Cities
                {
                    Id = 50,
                    Name= "Quảng Bình",
                },
                new Cities
                {
                    Id = 51,
                    Name= "Quảng Trị",
                },
                new Cities
                {
                    Id = 52,
                    Name= "Trà Vinh",
                },
                new Cities
                {
                    Id = 53,
                    Name= "Hậu Giang",
                },
                new Cities
                {
                    Id = 54,
                    Name= "Sơn La",
                },
                new Cities
                {
                    Id = 55,
                    Name= "Bạc Liêu",
                },
                new Cities
                {
                    Id = 56,
                    Name= "Yên Bái",
                },
                new Cities
                {
                    Id = 57,
                    Name= "Tuyên Quang",
                },
                new Cities
                {
                    Id = 58,
                    Name= "Điện Biên",
                },
                new Cities
                {
                    Id = 59,
                    Name= "Lai Châu",
                },
                new Cities
                {
                    Id = 60,
                    Name= "Lạng Sơn",
                },
                new Cities
                {
                    Id = 61,
                    Name= "Hà Giang",
                },
                new Cities
                {
                    Id = 62,
                    Name= "Bắc Kạn",
                },
                new Cities
                {
                    Id = 63,
                    Name= "Cao Bằng",
                }
            );
        }
    }
}
