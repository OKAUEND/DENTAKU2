using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Numeric
    {
        //数値計算用
        decimal TotalValue;
        decimal RightTerm;

        //表示用
        string DisplayValue;

        //計算操作ログ

        //計算モード
        string NumericMode = string.Empty;
        int NumericTimes = 0;

        public void DataRetention(string InputFigure)
        {
            //2回目以降連続計算入力時
            if (NumericTimes != 0 || NumericMode.Length != 0)
            {
                if (RightTerm == 0)
                {
                    RightTerm = decimal.Parse(InputFigure);
                }
                else
                {
                    string Figure = RightTerm.ToString();
                    RightTerm = decimal.Parse(Figure + InputFigure);
                }
            }
            //初回入力時
            else
            {
                if (TotalValue == 0)
                {
                    TotalValue = decimal.Parse(InputFigure);
                }
                else
                {
                    string Figure = TotalValue.ToString();
                    TotalValue = decimal.Parse(Figure + InputFigure);
                }
            }

        }

        public void CalcSummation()
        {
            switch(NumericMode)
                {
                case "Add":
                    TotalValue = TotalValue + RightTerm;
                    break;

                case "Subtrac":
                    TotalValue = TotalValue - RightTerm;
                    break;

                case "Multipl":
                    TotalValue = TotalValue * RightTerm;
                    break;

                case "Division":
                    TotalValue = TotalValue / RightTerm;
                    break;
            }

            //初期化
            RightTerm = 0;
            NumericMode = string.Empty;
            
        }

        public void ModeChange(string Mode)
        {
            NumericMode = Mode;
            NumericTimes += 1;
        }

    }    
}
