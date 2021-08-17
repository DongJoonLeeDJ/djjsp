
public class Student {

	//인스턴스 변수
	private String name;
	private int age;
	private String hakbeon;
	
	//클래스 변수
	public static String GyoHoon;
	
	
	
	public Student(String name, int age, String hakbeon) {
		super();
		this.name = name;
		this.age = age;
		this.hakbeon = hakbeon;
	}
	
	//클래스 메소드
	public static void Sleep()
	{
		System.out.println("자바스크립트 시간에 자꾸 자바 한다. 잠온다.");
	}
	
	//인스턴스 메소드
	//인스턴스 별로(=객체별로 다른 행동을 함)
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getHakbeon() {
		return hakbeon;
	}
	public void setHakbeon(String hakbeon) {
		this.hakbeon = hakbeon;
	}
	
	
}
