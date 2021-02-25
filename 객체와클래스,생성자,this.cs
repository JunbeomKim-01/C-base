using System;

//클래스
// 클래스 안에 선언된 변수들을 일컬어 멤버변수,필드라고 한다.

class Dog
{   
    public string  name;        //멤버변수
    public int age;              //멤버변수

    public void Eat(){          // 메소드
        Console.writeLine('냠냠');
     }
    
    public void Bark(){         //메소드
        Console.writeLine('멍멍');
    }
    
}
//객체: 사물과 같은 유형적인 것(자동차,컴퓨터)뿐만 아니라,개념이나 논리와 같은 
//무형적인 것들을 객체라고 한다
//프로그래밍에서의 객체는 클래스에 정의된 내용이 메모리에 생성된 것을 뜻한다.
//클래스로부터 객체를만드는 과정을 클래스의 인스턴스화
//어떤 클래스로부터 만들어진 객체를 그 클래스의 인스턴스
//클래스---(인스턴스화)--->인스턴스(객체)


//객체를 생성

namespace MainApp
{
    class Program
    {
        static void main(string[] args){
            DoG d; //클래스의 객체를 참조하기 위한 참조변수
            d= new DoG();//객체를 생성한귀,객체의 주소를 참조변수에 저장
            d.Bark();
        }
    }
    class DoG
    {
    public string  name;        //멤버변수
    public int age;              //멤버변수

    public void Eat(){          // 메소드
        Console.writeLine('냠냠');
     }
    
    public void Bark(){         //메소드
        Console.writeLine('멍멍');
    }
    }
}