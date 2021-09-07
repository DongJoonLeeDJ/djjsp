package com.start.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class FormEx
 */
@WebServlet("/FormEx")
public class FormEx extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public FormEx() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		String name = request.getParameter("myname");
		int age = Integer.parseInt(request.getParameter("myage"));
		System.out.println(name);
		response.setContentType("text/html; charset=utf-8");
		PrintWriter writer = response.getWriter();
		//writer.println(name+"님 안녕");
		
		Student s = new Student(name, age);
		writer.println(s.getName()+"님 안녕, 나이는 "+s.getAge()+"살이구나");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		request.setCharacterEncoding("utf-8"); //Post방식은 이 걸 추가해줘야 함
		String name = request.getParameter("myname_post");
		System.out.println(name);
		response.setContentType("text/html; charset=utf-8");
		PrintWriter writer = response.getWriter();
		writer.println(name+"님 안녕하세요. Post입니다.");
		
	}

}
