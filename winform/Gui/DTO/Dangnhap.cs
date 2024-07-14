using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dangnhap
    {


        public int id { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Phanquyen { get; set; }
        public string Matma { get; set; }

        public Dangnhap() { }
        public Dangnhap(int id, string Username, string Pass, string Email, string Phanquyen, string Matma)
        {
            this.id = id;
            this.Username = Username;
            this.Pass = Pass;
            this.Email = Email;
            this.Phanquyen = Phanquyen;
            this.Matma = Matma;
        }
    }
}
