package testInterface;

public class Person implements Eatable{
	
	private String name;
	private String sNum;
	
	public Person(String name, String sNum) {
		super();
		this.name = name;
		this.sNum = sNum;
	}
	public String getName() {
		return name;
	}
	public String getsNum() {
		return sNum;
	}
	public void setsNum(String sNum) {
		this.sNum = sNum;
	}
	public void setName(String name) {
		this.name = name;
	}
	
	@Override
	public void Eat() {
		// TODO Auto-generated method stub
		System.out.println("냠냠 밥을 먹습니다.");
		
	}

	@Override
	public void Eat(String Food) {
		// TODO Auto-generated method stub
		System.out.println(this.name+"은 "+Food+"을/를 먹습니다.");
		
	}
	
	//Eatable에 기본으로 구현되어 있는 함수를 오버라이딩(=덮어쓰기) 한다.
	@Override
	public void Test() {
		// TODO Auto-generated method stub
		//Eatable.super.Test();
		System.out.println("Test는 또 하나의 개발이다. 음식이 시큼한 맛이 나면 절대 먹지 마세요.");
	}

}


