using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Para
    {/// <summary>
    /// Практическая №5 перегрузка методов
    /// </summary>
        int[] _para;
        public int FirstNum { get=>_para[0]; set => _para[0]=value; }
        public int SecondNum { get => _para[1]; set => _para[1]=value; }
        public Para()
        {
            _para = new int[2];
            _para[0] = 0;
            _para[1] = 0;
        }
        public Para(int firstNum,int secondNum)
        {
            _para[0] = firstNum;
            _para[1] = secondNum;
        }
        public int [] ParaArray { get => _para; set => _para = value; }
        public bool CompareFirst(Para _secondpara)
        {
            if (this.FirstNum >= _secondpara.FirstNum) return true;
            else return false;
        }
        public bool CompareSecond(Para _secondpara)
        {
            if (this.SecondNum > _secondpara.SecondNum) return true;
            else return false;
        }
/// <summary>
/// Практическая №6 работа с операторами
/// </summary>
/// <param name="operator"></param>
/// <returns></returns>
        public static bool operator >=(Para first, Para second)
        {
            if (first.FirstNum >= second.FirstNum) return true;
            else return false;
        }
        public static bool operator <=(Para first, Para second)
        {
            if (first.FirstNum <= second.FirstNum) return true;
            else return false;
        }
        public static bool operator >(Para first, Para second)
        {
            if (first.SecondNum > second.SecondNum) return true;
            else return false;
        }
        public static bool operator <(Para first, Para second)
        {
            if (first.SecondNum < second.SecondNum) return true;
            else return false;
        }
        
    }
    class Faction : Para
    {
        int[] _fac;
        public Faction()
        {
            _fac = new int[2];
            _fac[0] = 0;
            _fac[1] = 0;

        }
        public Faction(Para _para)
        {
            _fac[0] = _para.FirstNum;
            _fac[1] = _para.SecondNum;

        }
        public Faction SumEd(Faction _second)
        {
            Faction faction = new Faction();
            faction.FirstNum = this.FirstNum + _second.FirstNum;
            faction.SecondNum = this.SecondNum + _second.SecondNum;
            if (faction.SecondNum > 100) { faction.SecondNum -= 100; faction.FirstNum += 1; }
            return faction;
        }
    }
}
