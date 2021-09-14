using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{    
    class member
    {
        private string name = null;
        private string gender = null;
        private string id = null;
        private string pwd = null;
        private string email = null;
        private string phone = null;
        public member()
        {

        }
        public member(string name, string gender, string id, string pwd, string email, string phone)
        {
            this.Name = name;
            this.Gender = gender;
            this.Id = id;
            this.Pwd = pwd;
            this.Email = email;
            this.Phone = phone;
        }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Id { get => id; set => id = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
