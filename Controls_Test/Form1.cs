using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_Test
{

    enum enClassMate
    {
        아이린,
        조이,
        웬디,
        슬기,
        예리,
        윈터,
        카리나,
        닝닝,
        지젤
    }

    enum enBoss
    {
        김주희,
        김주현,
        김재헌
    }


    public partial class Form1 : Form
    {

        // key에 enClassMate 와야함. value에 enBoss 와야함
        Dictionary<string, string> _dic = new Dictionary<string, string>();
        List<string> _list = new List<string>();

        public delegate int MydelAge();
        public delegate int MyDel(int a, int b);

        public Form1()
        {
            InitializeComponent();

        }


        public void CallBackFuncAge(MydelAge myAge,string Contry)
        {

            int age = myAge();   //반환값 int 매개변수 없는 delegate


            string strMyAge = string.Format("내 나이는 {0}살 이야! {1}나이로 성인이야!", age, Contry);

            listBox1.Items.Add(strMyAge);

        }


        //public delegate int MydelAge()와 연결 해서 사용할 함수들이 있는 class
        class Age
        {
            public int a = 20;      //★ public 안 붙었음 디폴트 private 
            public int b = 19;

            public int Korea_Age()
            {
                
               return 20;
            }

            public int Japan_Age()
            {
                return 19;
            }

        }
       


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (enClassMate oitem in Enum.GetValues(typeof(enClassMate)))
            {
                cboxMate.Items.Add(oitem);
            }

            foreach (enBoss oitem in Enum.GetValues(typeof(enBoss)))
            {
                cboxBoss.Items.Add(oitem);
            }

            // new 없어도 delegate 생성 가능(업뎃하고 생긴 기능)
            // 1)
            //MyDel _mydel;
            //_mydel = Sum;

            // 2) 
            //MyDel _mydel = Sum;

            MyDel _mydel = new MyDel(Sum);
            listBox1.Items.Add(_mydel(3,4));  //Sum함수에 출력해주는게 없으니까, 출력부분에 delegate값 넣는다


            //delegate를 사용하는 람다
            MyDel delRamda = (a, b) => a * b;

            int mulResult = delRamda(5, 5);     //return int 인거 활용(?)
            listBox1.Items.Add(mulResult);

            listBox1.Items.Add(delRamda(5, 5));   //return 신경 X  결과는 위와 같다
   


            Age age = new Age();   //class 생성

            age.a = 30;             //이거 변수에 직접 접근하는거 a변수 b변수가 public이 아니였다면 못함
            age.b = 40;

            int aa = age.a;         //이것도 a,b변수가 public이라서 가능한거. public없음 디폴트가 private
            int bb = age.b;

            listBox1.Items.Add(string.Format("class에 있는 변수에 접근했어요! {0}",aa));
            listBox1.Items.Add(string.Format("class에 있는 변수에 접근했어요! {0}", bb));

            listBox1.Items.Add(bb);

            //delegate 콜백메서드 (delegate , string)
            CallBackFuncAge(new MydelAge(age.Korea_Age),"한국");
            CallBackFuncAge(age.Japan_Age, "일본");               //버전 2.0부터 new로 선언을 안 해줘도 자동으로 된다


            eventFuc();

        }



        public void eventFuc()
        {
            EventClass eClass = new EventClass();

            eClass._eventdelint += EClass__eventdelint;      //event연결 
            eClass._eventdelvoid += EClass__eventdelvoid;

            eClass.eventTest1();



        }


        private int EClass__eventdelint(string text)
        {
           listBox1.Items.Add(text);
            return 2021;
        }

        private void EClass__eventdelvoid(string text)
        {
            listBox1.Items.Add(text);
        }



        public int Sum(int a, int b)
        {
            return a + b;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ListViewItem lviAdd = new ListViewItem(tboxName.Text);
            ListViewItem lviAdd = new ListViewItem();
            lviAdd.Text = tboxName.Text;                    //맨왼쪽 첫번째 항목 값 들어갈거


            //맨 왼쪽 첫번째 항목은 XX SubItems는 두번째 항목부터 들어감 
            lviAdd.SubItems.Add(tboxHobby.Text);
            lviAdd.SubItems.Add(tboxCity.Text);

            listView1.Items.Add(lviAdd);    //listView에 값 뿌려주기


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //선택항목 하나만 삭제
            //listView1.Items.RemoveAt(listView1.SelectedIndices[0]);


            foreach (ListViewItem lv in listView1.SelectedItems)      //여러개 삭제
            {
                listView1.Items.Remove(lv);

            }
        }




        private void btndgvAdd_Click(object sender, EventArgs e)
        {
            string name = "";

            switch (cboxBoss.Text)
            {
                case "김주희":
                    name = enBoss.김주희.ToString();
                    break;

                case "김주현":
                    name = enBoss.김주현.ToString();
                    break;

                case "김재헌":
                    name = enBoss.김재헌.ToString();
                    break;

                default:
                    break;
            }

            _list.Add("김햄스터");
            _list.Add("김거북이");

            foreach (string oitem in _list)
            {
                listView1.Items.Add(oitem);
            }



            try
            {
                _dic.Add(cboxMate.Text, name);
                dgv1.DataSource = _dic.ToArray();

            }
            catch (Exception)
            {
                MessageBox.Show("이미 투표한 사람 입니다");
            }



        }

        private void btnlbox_Click(object sender, EventArgs e)
        {
            //enClassMate.아이린
            enClassMate enIrene = enClassMate.아이린;         //enum
            int intIrene = (int)enClassMate.아이린;           //int로 형변환
            string strIrene = enClassMate.아이린.ToString();  //string으로 형변환



            //int를 받아서, enum으로 형변환 -> 해당 숫자의 '문자' 보여줌
            int FindIrene = 0;
            enClassMate enNumberIrene = (enClassMate)FindIrene;


            //Enum.Parse사용. enum으로 받기
            //string ParseJoy = "조이";
            //enClassMate ParseStrJoy = (enClassMate)Enum.Parse(typeof(enClassMate), ParseJoy);


            //Enum.Parse 사용. int로 받기 ★
            string ParseIrene = "아이린";
            int ParseStrIrene = (int)Enum.Parse(typeof(enClassMate), ParseIrene);


            //Enum.Parse 사용. stirng으로 받기
            //string ParseJoy2 = "조이";
            //string ParseStrJoy2 = Enum.Parse(typeof(enClassMate), ParseJoy2).ToString();


            listBox1.Items.Add(string.Format("enum으로 받아주기: {0}", enIrene));  //아이린
            listBox1.Items.Add(string.Format("int로 받아주기: {0}", intIrene));  //0
            listBox1.Items.Add(string.Format("string으로 받아주기: {0}", strIrene)); //아이린

            listBox1.Items.Add(string.Format("================="));

            listBox1.Items.Add(string.Format("int를 받아서 enum으로 형변환: {0}", FindIrene));  //아이린

            listBox1.Items.Add(string.Format("================="));

            //listBox1.Items.Add(string.Format("Enum.Parse사용. string받아서 enum으로 형변환: {0}", ParseStrJoy));     //조이
            listBox1.Items.Add(string.Format("Enum.Parse사용. string받아서 int로 형변환: {0}", ParseStrIrene));   //0
                                                                                                         //listBox1.Items.Add(string.Format("Enum.Parse사용. string받아서 stirng으로 형변환: {0}", ParseStrJoy2));  //조이

            //이거 써주면 위에 Items.Add로 값 보여준거 싹 다 사라지고 ↓ 결과만 보여짐
            //listBox1.DataSource = Enum.GetValues(typeof(enBoss));

            foreach (enBoss item in (enBoss[])Enum.GetValues(typeof(enBoss)))
            {
                listBox1.Items.Add(item);
            }

        }
    }

}