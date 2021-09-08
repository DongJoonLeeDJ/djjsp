package testInterface;

import java.util.ArrayList;

public class MyHRD {

	public static void main(String[] args) {
		
		
		Person p = new Person("이동준","890430");
		Insect i = new Insect("초록색 파리");
		Machine m = new Machine("컴퓨터", 100);
		
		p.Eat();
		p.Eat("사과");
		
		i.Eat();
		i.Eat("사과");

		Eating(p, "빵");
		Eating(i, "빵");
		
		ArrayList<Eatable> list = new ArrayList<Eatable>();
		list.add(p);
		list.add(i);
		
//		list.add(m);
		
		//list : Eatable이 구현되어 있는 것들이 있는 리스트
		//notify 함수는... 여기에 등록되어 있는(저장되어 있는) 객체들에게
		//Eat 명령을 일괄적으로 내렸다.
		notify(list, "경북산업직업전문학교 별관 식당 밥");
		
		
		
		//람다식
		//함수를 축약한 것
		//forEach : 콜백함수
		//list에 있는 각각의 item들에 대하여
		//그 item에 있는 함수들을 실행함
		//여기서 item은 list에 있는 요소를 뜻하며
		//다른 이름을 써도 무방함.
		list.forEach( item -> item.Eat());
		
		//위의 코드를 원래대로 표현하자면 아래와 같았다.
		for(Eatable item : list)
			item.Eat();
	
	
	}
	
	static void notify(ArrayList<Eatable> l, String Food)
	{
		for(Eatable item : l)
		{
			item.Eat();
			item.Eat(Food);
		}
			
	}
	
	//Eatable e
	//Eatable 인터페이스를 구현하는 모든 것들을 의미 함
	static void Eating(Eatable e, String Food)
	{
		e.Eat();
		e.Eat(Food);
		e.Test();
	}
}







