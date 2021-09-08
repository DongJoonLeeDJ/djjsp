package testInterface;

//Eat이라는 함수와 Eat(String Food)라는 함수를
//구체적으로 구현하라는 명령, 규약, 규칙
//규칙은 여러개가 주렁주렁 달릴 수 있음
public interface Eatable {
	void Eat();
	void Eat(String Food);
	//Eat이랑은 다르게.. Test 함수는... 구현을 해놓으면 그걸 오버라이딩하고
	//구현해놓지 않으면 이 디폴트가 지정한 값을 쓴다.
	default void Test()
	{
		System.out.println("....");
	}
}
