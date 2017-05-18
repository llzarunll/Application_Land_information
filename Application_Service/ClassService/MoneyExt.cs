using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS_Smart.Class
{
    public class MoneyExt
    {
        public string NumberToThaiWord(double InputNumber)
        {
            string result;
            if (InputNumber == 0)
            {
                result = "ศูนย์บาทถ้วน";
                return result;
            }

            string NewInputNumber;
            NewInputNumber = InputNumber.ToString("###0.00");
            if (Convert.ToDouble(NewInputNumber) >= 10000000000000)
            {
                result = "";
                return result;
            }

            string[] tmpNumber = new string[2];
            string FirstNumber;
            string LastNumber;

            tmpNumber = NewInputNumber.Split(Convert.ToChar("."));
            FirstNumber = tmpNumber[0];
            LastNumber = tmpNumber[1];

            int nLength = 0;
            nLength = Convert.ToInt32(FirstNumber.Length);

            int CNumber = 0;
            int CNumberBak = 0;
            string strNumber = "";
            string strPosition = "";
            string FinalWord = "";
            int CountPos = 0;

            for (int i = nLength; i >= 1; i--)
            {
                CNumberBak = CNumber;
                CNumber = Convert.ToInt32(FirstNumber.Substring(CountPos, 1));

                if (CNumber == 0 && i == 7)
                {
                    strPosition = "ล้าน";
                }
                else if (CNumber == 0)
                {
                    strPosition = "";
                }
                else
                {
                    strPosition = PositionToText(i);
                }

                if (CNumber == 2 && strPosition == "สิบ")
                {
                    strNumber = "ยี่";
                }
                else if (CNumber == 1 && strPosition == "สิบ")
                {
                    strNumber = "";
                }
                else if (CNumber == 1 && strPosition == "ล้าน" && nLength >= 8)
                {
                    if (CNumberBak == 0)
                    {
                        strNumber = "หนึ่ง";
                    }
                    else
                    {
                        strNumber = "เอ็ด";
                    }
                }
                else if (CNumber == 1 && strPosition == "" && nLength > 1)
                {
                    strNumber = "เอ็ด";
                }
                else
                {
                    strNumber = NumberToText(CNumber);
                }

                CountPos = CountPos + 1;
                FinalWord = FinalWord + strNumber + strPosition;
            }

            CountPos = 0;
            CNumberBak = 0;
            nLength = Convert.ToInt32(LastNumber.Length);

            string Stang = "";
            string FinalStang = "";
            if (Convert.ToDouble(LastNumber) > 0)
            {
                for (int i = nLength; i >= 1; i--)
                {
                    CNumberBak = CNumber;
                    CNumber = Convert.ToInt32(LastNumber.Substring(CountPos, 1));
                    if (CNumber == 1 && i == 2)
                    {
                        strPosition = "สิบ";
                    }
                    else if (CNumber == 0)
                    {
                        strPosition = "";
                    }
                    else
                    {
                        strPosition = PositionToText(i);
                    }

                    if (CNumber == 2 && strPosition == "สิบ")
                    {
                        Stang = "ยี่";
                    }
                    else if (CNumber == 1 && i == 2)
                    {
                        Stang = "";
                    }
                    else if (CNumber == 1 && strPosition == "" && nLength > 1)
                    {
                        if (CNumberBak == 0)
                        {
                            Stang = "หนึ่ง";
                        }
                        else
                        {
                            Stang = "เอ็ด";
                        }
                    }
                    else
                    {
                        Stang = NumberToText(CNumber);
                    }

                    CountPos = CountPos + 1;
                    FinalStang = FinalStang + Stang + strPosition;
                }

                FinalStang = FinalStang + "สตางค์";
            }
            else
            {
                FinalStang = "";
            }

            string SubUnit;
            if (FinalStang == "")
            {
                SubUnit = "บาทถ้วน";
            }
            else
            {
                if (Convert.ToDouble(FirstNumber) != 0)
                {
                    SubUnit = "บาท";
                }
                else
                {
                    SubUnit = "";
                }
            }

            result = FinalWord + SubUnit + FinalStang;
            return result;
        }

        private string NumberToText(int CurrentNum)
        {
            string _nText = "";

            switch (CurrentNum)
            {
                case 0: _nText = "";
                    break;
                case 1: _nText = "หนึ่ง";
                    break;
                case 2: _nText = "สอง";
                    break;
                case 3: _nText = "สาม";
                    break;
                case 4: _nText = "สี่";
                    break;
                case 5: _nText = "ห้า";
                    break;
                case 6: _nText = "หก";
                    break;
                case 7: _nText = "เจ็ด";
                    break;
                case 8: _nText = "แปด";
                    break;
                case 9: _nText = "เก้า";
                    break;
            }

            return _nText;
        }

        private string PositionToText(int CurrentPos)
        {
            string _nPos = "";

            switch (CurrentPos)
            {
                case 0: _nPos = "";
                    break;
                case 1: _nPos = "";
                    break;
                case 2: _nPos = "สิบ";
                    break;
                case 3: _nPos = "ร้อย";
                    break;
                case 4: _nPos = "พัน";
                    break;
                case 5: _nPos = "หมื่น";
                    break;
                case 6: _nPos = "แสน";
                    break;
                case 7: _nPos = "ล้าน";
                    break;
                case 8: _nPos = "สิบ";
                    break;
                case 9: _nPos = "ร้อย";
                    break;
                case 10: _nPos = "พัน";
                    break;
                case 11: _nPos = "หมื่น";
                    break;
                case 12: _nPos = "แสน";
                    break;
                case 13: _nPos = "ล้าน";
                    break;
            }

            return _nPos;
        }
    }
}
