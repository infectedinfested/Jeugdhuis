using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegdhuis_V3
{
    class UsersRepository
    {
        public List<Users> users;

        public void import()
        {
            var reader = new StreamReader(File.OpenRead("xml/VrijwilligersLijst.txt"));
            string[] test = File.ReadAllLines("xml/VrijwilligersLijst.txt");
            users = new List<Users>();
            foreach (var item in test.ToList())
            {
                try
                {
                    var values = item.Split(':');
                    users.Add(new Users(values[0], values[1], Boolean.Parse(values[2]), Boolean.Parse(values[3]), Boolean.Parse(values[4]), Boolean.Parse(values[5])));

                }
                catch (Exception)
                {
                }
                
            }
        }
        public void export()
        {
            string[] temp = new string[users.Count()+5];
            for (int i = 0; i < users.Count(); i++)
            {
                temp[i] = users[i].naam + ":" + users[i].passwoord + ":" + users[i].stock + ":true:false:" + users[i].admin;
            }
            File.WriteAllLines("xml/VrijwilligersLijst.txt", temp);
        }
        public List<Boolean> getUser(string naam , string passwoord)
        {
            foreach (var users in users)
            {
                if (naam.Equals(users.naam) && passwoord.Equals(users.passwoord))
                {
                    List<bool> test = new List<bool>();
                    test.Add(users.stock);
                    test.Add(users.tapper);
                    test.Add(users.kluis);
                    test.Add(users.admin);
                    return test;
                }
            }

            return null;
        }
    }
}
