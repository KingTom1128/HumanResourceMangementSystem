using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2019B
{
    public class CommonHelper
    {
        public static void SuccessReply(string s)
        {
            MessageBox.Show(s, "成功信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void FailedReply(string s)
        {
            MessageBox.Show(s, "失败信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte[] bytesMD5 = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            foreach(byte b in bytesMD5)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
