package com.answer.question;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class StudentForm
 */
@WebServlet("/StudentForm")
public class StudentForm extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public StudentForm() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		
		//한글화 대비
		request.setCharacterEncoding("utf-8");
		
		String vName = request.getParameter("myname");
		String vNumber = request.getParameter("mynumber");
		int vAge = 0;
		try {			
			vAge = Integer.parseInt(request.getParameter("myage"));
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		Student myStudent = new Student(vName, vAge, vNumber);
		
		response.setContentType("text/html; charset=utf-8");
		PrintWriter writer = response.getWriter();
		writer.println("<html>");
		writer.println("<head></head>");
		writer.println("<body>");
		writer.println("<h1>이름 : "+ myStudent.getName() +"</h1>");
		writer.println("<h1>나이 : "+ myStudent.getAge() +"</h1>");
		writer.println("<h1>번호 : "+ myStudent.getNumber() +"</h1>");
		writer.println("</body>");
		writer.println("</html>");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
