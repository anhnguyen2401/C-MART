using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmart.BUS
{
    class C01_LoginBUS
    {
        string userName;
        Account acc;
        CMART1Entities1 db = new CMART1Entities1();
        public C01_LoginBUS(string Username)
        {
            this.userName = Username;
        }

        public Account FindAcc()
        {
            db = new CMART1Entities1();
            try
            {
                acc = db.Accounts.Single(x => x.Username == userName);
                return acc;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string getPosition()
        {
            return acc.Auth;
        }
        public string getFullName()
        {
            return acc.Name;
        }
        public string getPassWord()
        {
            return acc.Password;
        }
        public string getIDAcc()
        {
            return acc.IDAcc;
        }
    }
}
