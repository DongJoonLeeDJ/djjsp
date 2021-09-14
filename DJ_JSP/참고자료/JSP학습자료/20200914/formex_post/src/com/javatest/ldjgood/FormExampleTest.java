package com.javatest.ldjgood;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Arrays;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class FormExampleTest
 */
@WebServlet("/FormExampleTest")
public class FormExampleTest extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public FormExampleTest() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		
		System.out.println("do get");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		
		//한글 깨짐 처리
		request.setCharacterEncoding("utf-8");
		
		//파라메터 받는 부분(Form태그의 값 받는 부분)
		
		String vName = request.getParameter("name");
		String vId = request.getParameter("id");
		String vPw = request.getParameter("pw");
		
		String[] hobbys = request.getParameterValues("hobby");
		String major = request.getParameter("major");
		String gender = request.getParameter("gender");
		String protocol = request.getParameter("protocol");
				
		System.out.println(vName);
		System.out.println(vId);
		System.out.println(vPw);
		
		for(int i = 0; i < hobbys.length; i++)
		{
			System.out.print(hobbys[i] + " ");
		}
		System.out.println();
		
		for(String item : hobbys)
		{
			System.out.print (item+ " ");
		}
		System.out.println();

		System.out.println(major);
		System.out.println(gender);
		System.out.println(protocol);
		
		Customer cus = new Customer();
		cus.setName(vName);
		cus.setId(vId);
		cus.setPw(vPw);
		cus.setHobbys(hobbys);
		cus.setMajor(major);
		cus.setGender(gender);
		cus.setProtocol(protocol);
		

		response.setContentType("text/html; charset=utf-8");
		PrintWriter writer = response.getWriter();
		
		writer.println("<html><head></head><body>");
		writer.println("이름 : " + cus.getName() + "<br />");
		writer.println("아이디 : " + cus.getId() + "<br />");
		writer.println("비밀번호 : " + cus.getPw() + "<br />");
		writer.println("취미 : " + Arrays.toString(cus.getHobbys()) + "<br />");
		writer.println("전공 : " + major + "<br/>");
		writer.println("성별 : " + gender + "<br/>");
		writer.println("프로토콜 : " + protocol + "<br/>");
		writer.println("</body></html>");
		writer.close();

		for(String item : hobbys)
		{
			System.out.print (item+ " ");
		}
		System.out.println(Arrays.toString(cus.getHobbys()));
		
		
	}

}
