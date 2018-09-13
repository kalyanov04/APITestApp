using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.User
{
    public class UserInfo
    {
        int id;
        string name;
        string username;
        string email;
        Address address;
        string phone;
        string website;
        Company company;

        public int Id { private get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public Address Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Website { get => website; set => website = value; }
        public Company Company { get => company; set => company = value; }

        public UserInfo SetId(int id)
        {
            this.Id = id;
            return this;
        }
        public UserInfo SetName(string name)
        {
            this.Name = name;
            return this;
        }
        public UserInfo SetUsername(string username)
        {
            this.Username = username;
            return this;
        }
        public UserInfo SetEmail(string email)
        {
            this.Email = email;
            return this;
        }
        public UserInfo SetAddress(Address address)
        {
            this.Address = address;
            return this;
        }
        public UserInfo SetPhone(string phone)
        {
            this.Phone = phone;
            return this;
        }
        public UserInfo SetWebsite(string website)
        {
            this.Website = website;
            return this;
        }
        public UserInfo SetCompany(Company company)
        {
            this.Company = company;
            return this;
        }
    }
}
