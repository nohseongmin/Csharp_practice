using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04HomeWork
{
    //Object 클래스를 상속한
    //Department 클래스 생성
    class Department : Object //자료형
    {
        public string Code; //인스턴스 필드
        public string Name;

        public override string ToString() //lbx가 호출하는 tostring() 메소드를 수정(이 자료형 안에서만)
        {
            return $"[{Code}] {Name}";
        }

    }
}
