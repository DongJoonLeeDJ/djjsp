package studyLamda;

@FunctionalInterface //함수형 인터페이스
//단순히 객체가 아니고 함수를 저장함
//이걸 선언하는 그 시점에 해당 함수를 구체화 함
public interface MyAddable {
	//함수 이름은 add 이고 매개변수는 2개 받고 반환형은 정수인 함수
	public int add(int x, int y);
}
