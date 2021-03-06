﻿using System;
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

        //計算操作ログ

        //計算モード
        string NumericMode = string.Empty;
        int NumericTimes = 0;

        //データ保持用のリストを宣言
        private List<LogDate> NumericList = new List<LogDate>();

        //データ入力操作
        public string DataRetention(string InputFigure)
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
            return TotalValue.ToString();
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

            //計算回数をインクリメント
            NumericTimes += 1;

        }

        public string ModeChange(string Mode)
        {
            //計算モードを更新
            NumericMode = Mode;
            return TotalValue.ToString() + (LogicSymbols());

        }

        private string LogicSymbols()
        {
            string LogicString = string.Empty;
            switch (NumericMode)
            {
                case "Add":
                    LogicString = "＋";
                    break;

                case "Subtrac":
                    LogicString = "－";
                    break;

                case "Multipl":
                    LogicString = "✕";
                    break;

                case "Division":
                    LogicString = "÷";
                    break;
            }

            return LogicString;
        }

    }

    class LogDate
    {
        int NumericTimes { get; set; }
        decimal NowTotalValue { get; set; }
        decimal BeforTotalValue { get; set; }
        decimal InputValue { get; set; }
        string InputLog { get; set; }
        string CalcMode { get; set; }

        public string ShowHistory()
        {
            return $"{this.InputValue}";
        }
    }
}
