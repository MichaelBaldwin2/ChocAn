using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAn
{
    class ValidateMember
    {
        /**
         * validateMember() will validate user inputted member number
         * If the member number is found, return that MemberAccount,
         * else, return empty MemberAccount
         */

        public static MemberAccounts validateMember(int memNum)
        {
            List<MemberAccounts> me = DirectoryDB.ReadMember();
            int found = -1;
            MemberAccounts ma = new MemberAccounts();
            ma.setStatus(false);

            foreach(MemberAccounts account in me)
            {
                if (account.getNumber() == memNum)
                {
                    found = 0;
                    if(account.getStatus() == false)
                    {
                        MessageBox.Show("The member with member number " + memNum + " has been suspended","Suspended", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Valid member number", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ma = account;
                }
            }
            if(found == -1)
            {
                MessageBox.Show("Invalid member number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ma;
        }
    }
}
