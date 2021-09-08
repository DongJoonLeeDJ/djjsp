package testInterface;

public class Insect implements Eatable{

	private String name;
	
	public Insect(String name) {
		super();
		this.name = name;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	@Override
	public void Eat() {
		// TODO Auto-generated method stub
		System.out.println("쾁쾁쾁");
	}

	@Override
	public void Eat(String Food) {
		// TODO Auto-generated method stub
		System.out.println(Food+"에서 핀 곰팡이를 먹습니다.");
		
	}
	
	

}
