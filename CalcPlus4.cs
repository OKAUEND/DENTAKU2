using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class CalcPlus4 : Form
    {
        public CalcPlus4()
        {
            InitializeComponent();
        }

        Numeric NumericData = new Numeric();

        private void CalcPlus4_Load(object sender, EventArgs e)
        {
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            NumericData.CalcSummation();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            NumericData.ModeChange(button.Tag.ToString());
        }

        //数字入力処理
        private void BtnFigure_Click(object sender, EventArgs e)
        {
            //ボタン情報取得
            Button button = (Button)sender;

            NumericData.DataRetention(button.Text.ToString());
            
        }
    }
}
