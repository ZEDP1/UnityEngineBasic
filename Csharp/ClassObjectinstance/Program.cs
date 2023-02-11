// using 키워드
// useing namespace이름 :
// 특정 namespace를 이 cs에서 사용하겠다 
using ClassObjectinstance;

// 값타입. 참조타입
// 값타입 : 값을 직접 메모리에 쓰고 읽는 형태. 일반적으로 스텍영역에 할당.
// 참조타입 : 데이터가 있는 메모리의 주소로 간접 쓰기/읽기를 하는 형태. 힙영역에 할당

// new 키워드
// 동작할당 키워드. 런타임에서 메모리를 동적할당할 때 사용
SwordMan swordman = new SwordMan();

// .연산자
// 멤버접근연산자
swordman.Name = "검사 1";
swordman.Attack();
swordman.Jump();

SwordMan swordMan2 = new SwordMan();
swordMan2.Name = "검사 2";
// 검사 1을 점프시키고 싶은데 어떻게하지? => 안됨 

Orc orc = new Orc();
Orc orc2 = new Orc();


orc.Name = "상급오크";
orc.Old = 210;
orc.Height = 60.3;
orc.Wegiht = 80.2;
orc.Gender = '여';
orc.SayMyName();
orc.SayMyinfo();
Console.WriteLine();
orc2.Name = "하급오크";
orc2.Old = 140;
orc2.Height = 72.0;
orc2.Wegiht = 24.4;
orc2.Gender = '남';
orc2.SayMyName();
orc2.SayMyinfo();
