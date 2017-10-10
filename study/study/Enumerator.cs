using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    class Goods
    {
        string name;
        string type;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Goods(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public void Explain()
        {
            switch(type)
            {
                case "피규어":
                    Console.WriteLine("말그대로 피규어이다. 피규어에 따라 다르지만 대부분 비싸다.");
                    if (name.Contains("알터"))
                        Console.WriteLine("특히 이 제품은 알터 사에서 제작한 제품으로 많은 제품의 가격이 상당하다.");
                    break;
                case "아크릴 스탠드":
                    Console.WriteLine("아크릴 소재로 된 평면 스탠드이다.");
                    Console.WriteLine("아크릴때문에 대부분 그림을 제외한 부분이 투명하거나 반투명하다.");
                    break;
                case "티셔츠":
                    Console.WriteLine("평범하게(?) 입고다닐 수 있는 티셔츠이다.");
                    Console.WriteLine("자신이 파고있는 장르에 한치의 부끄럼도 없는 사람들은 밖에서도 당당하게 입고다닌다.");
                    Console.WriteLine("요즈음에는 일코를 하는 분들을 위한 티셔츠도 많이 제작되고있다.");
                    break;
            }
        }
    }


    class Holder : IEnumerable
    {
        Goods[] values = { new Goods("알터 1/7 데레마스 후타바 안즈 게으름뱅이 페어리", "피규어"), new Goods("데레마스 아크릴 스탠드", "아크릴 스탠드"), new Goods("일하면 진다 티셔츠", "티셔츠") };

        public IEnumerator GetEnumerator()
        {
            return new GoodsEnumerator(values);
        }

        public class GoodsEnumerator : IEnumerator
        {
            int pos = -1;
            int length = 0;
            object[] list;

            public GoodsEnumerator(Goods[] goods)
            {
                list = goods;
                length = goods.Length;
            }

            public object Current
            {
                get { return list[pos]; }
            }

            public bool MoveNext()
            {
                if (pos >= length - 1)
                {
                    return false;
                }

                pos++;
                return true;
            }

            public void Reset()
            {
                pos = -1;
            }
        }

        public static void Main()
        {
            Holder h = new Holder();
            Goods g = new Goods("a", "b");
            foreach(Goods n in h)
            {
                Console.WriteLine("제품명 : " + n.Name);
                n.Explain();
                Console.WriteLine("\n============\n");
            }
        }
    }
}
