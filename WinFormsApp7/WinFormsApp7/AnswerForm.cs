using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class AnswerForm : Form

    {
        private Dictionary<Control, Rectangle> orignalControlBound = new();
        private Size originalFormSiaze;
        public AnswerForm()
        {
            InitializeComponent();
            string answer = @"int* twoSum(int* nums, int numsSize, int target, int* returnSize) {
    for (int i = 0; i < numsSize; ++i) 
    {    for (int j = i + 1; j < numsSize; ++j) 
        {    if (nums[i] + nums[j] == target) 
            {    int* ret = malloc(sizeof(int) * 2);
                ret[0] = i, ret[1] = j;
                *returnSize = 2;
                return ret;
            }
        }
    }
    *returnSize = 0;
    return NULL;
  }";

            textBox1.Text = answer;
        }
    }
    
}
