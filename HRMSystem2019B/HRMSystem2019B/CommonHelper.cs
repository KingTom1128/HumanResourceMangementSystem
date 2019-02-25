using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
