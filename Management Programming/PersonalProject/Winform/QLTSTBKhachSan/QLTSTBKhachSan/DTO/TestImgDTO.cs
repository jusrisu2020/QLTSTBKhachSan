using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class TestImgDTO
    {
        private int id;
        private string path;

        public int Id { get => id; set => id = value; }
        public string Path { get => path; set => path = value; }

        public TestImgDTO(int id, string path)
        {
            this.Id = id;
            this.Path = path;
        }

        public TestImgDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Path = row["paths"].ToString();
        }
    }
}
