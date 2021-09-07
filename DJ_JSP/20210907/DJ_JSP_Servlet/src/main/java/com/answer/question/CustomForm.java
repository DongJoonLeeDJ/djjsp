package com.answer.question;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Arrays;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class CustomForm
 */
@WebServlet("/CustomForm")
public class CustomForm extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CustomForm() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		
		
		String[] hobbys = request.getParameterValues("hobby");
		String major = request.getParameter("major");
		String gender = request.getParameter("gender");
		
		response.setContentType("text/html; charset=utf-8");
		PrintWriter writer = response.getWriter();
		
		//배열을 출력해보는 방법 2가지.
		//1번째 : Arrays에 있는 toString 함수 이용해서, 배열을 한 줄의 문자열로 만든다.
		String hobbyList = Arrays.toString(hobbys);
		//2번째 : 반복문 이용
		String myHobbyList = "";
		for(String item : hobbys)
		{
			myHobbyList += "  "+ item;
		}
		
		writer.println("<html><head></head><body>");
		writer.println("전공 : "+major+"<br>");
		writer.println("성별 : "+gender+"<br>");
		writer.println("취미1 : "+hobbyList+"<br>");
		writer.println("취미2 : "+myHobbyList+"<br>");
		writer.println("</body></html>");
		
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
