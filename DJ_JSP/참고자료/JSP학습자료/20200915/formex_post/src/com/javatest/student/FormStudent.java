package com.javatest.student;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


/**
 * Servlet implementation class FormAnimal
 */
@WebServlet("/FormStudent")
public class FormStudent extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public FormStudent() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
//		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub

		//한글 깨짐 처리
		request.setCharacterEncoding("utf-8");
		
		//파라메터 받는 부분(Form태그의 값 받는 부분)
		
		String vName = request.getParameter("name");
		String vAge = request.getParameter("age");
		String vNumber = request.getParameter("number");
		
				
		System.out.println(vName);
		System.out.println(vAge);
		System.out.println(vNumber);	
		
		Student stu = new Student();
		stu.setName(vName);
		stu.setNumber(vNumber);
		
		try
		{
			stu.setAge(Integer.parseInt(vAge));
		}
		catch (Exception e) {
			// TODO: handle exception
			stu.setAge(20);
		}
		

		response.setContentType("text/html; charset=utf-8");
		PrintWriter writer = response.getWriter();
		
		writer.println("<html><head></head><body>");
		writer.println("이름 : " + stu.getName() + "<br />");
		writer.println("나이 : " + stu.getAge() + "<br />");
		writer.println("학번 : " + stu.getNumber() + "<br />");
		writer.println("</body></html>");
		writer.close();
	}

}
