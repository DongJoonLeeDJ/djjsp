package dto;
public class TestBean {
	private String name;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
		System.out.println("JavaBean:name => " + name);
	}
}
/*
 * [파일명 - 2ea] / [경로] jhy0409\5 JSP\javabean0319\WebContent\beanTestForm.jsp
 * beanTestForm.jsp beanTestPro.jsp
 * 
 * TestBean.java jhy0409\5 JSP\javabean0319\src\javabean0319\TestBean.java
 */