using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls_Test
{
    class EventClass
    {


        //★ Main에서 event 호출 시, 자동 생성되는 함수의 반환타입,파라미터가 delegate 를 따라감★
        public delegate int _delint(string text);
        public delegate void _delvoid(string text);

        public event _delint _eventdelint;            // Main에 값 던져줄땐 event !!
        public event _delvoid _eventdelvoid;


        internal void eventTest1()
        {
            
            //_eventdelint("카페 헤이븐에 왔어용");    // delegate의 반환값이 int라는 점을 이용안한 ver. 값 던져주고 끝. 받는거 없다
            _eventdelvoid("카페에는 사람이 많아요");



            int Result = _eventdelint("카페 헤이븐에 왔어용");    //이렇게 하면 Main의 return값이 Result에 주어짐!!

            if(Result == 2021)    
            {
                _eventdelint("2021년 카페 헤이븐에 왔어용");
            }
        }



    }
}
