package com.answer.question;


//문제

//CustomForm처럼 동작하게 하는 서블릿을 만들되
//Custom 클래스에 데이터 저장하고, 그 데이터를 꺼내서 쓰는 방식으로 해보세요.
//아래 조건처럼, 영어 내용들은 다 한글로 바뀌어야 함
public class Custom {
	//취미배열
	private String[] Hobbys;
	
	//전공
	private String Major;
	
	//성별
	private String Gender;
	
	public Custom(String[] hobbys, String major, String gender) {
		super();
		Hobbys = hobbys;
		Major = major;
		Gender = gender;
	}

	public String[] getHobbys() {
		//return Hobbys;
		for(int i = 0; i< this.Hobbys.length; i++)
		{
			switch (this.Hobbys[i]) {
			case "cook":
				this.Hobbys[i] = "요리";
				break;
			case "run":
				this.Hobbys[i] = "달리기";
				break;
			case "swim":
				this.Hobbys[i] = "수영";
				break;
			case "game":
				this.Hobbys[i] = "게임";
				break;
			case "read":
				this.Hobbys[i] = "독서";
				break;

			default:
				break;
			}
		}
		return this.Hobbys;
	}

	public void setHobbys(String[] hobbys) {
		this.Hobbys = hobbys;
	}

	public String getMajor() {
		//return Major;
		switch (Major) {
		case "kor":
			return "국어";
		case "eng":
			return "영어";
		case "math":
			return "수학";
		case "computer":
			return "컴퓨터";
		default :
			return "그 외";
		}

	}

	public void setMajor(String major) {
		this.Major = major;
	}

	public String getGender() {
		//return Gender;
		switch (Gender) {
		case "man":
			return "남자";
		case "woman":
			return "여자";
		default :
			return "사람";
		}
	}

	public void setGender(String gender) {
		this.Gender = gender;
	}
	
	
	
	//취미랑 전공 성별 모두 한글로 나오게 해야 함
	//단 HTML부분은 손대지 말 것
}
