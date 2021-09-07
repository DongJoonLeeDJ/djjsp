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
 * Servlet implementation class CustomForm_With_Class
 */
@WebServlet("/CustomForm_With_Class")
public class CustomForm_With_Class extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CustomForm_With_Class() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
	
		// TODO Auto-generated method stub
				//response.getWriter().append("Served at: ").append(request.getContextPath());
				
				
				String[] hobbys = request.getParameterValues("hobby");
				String major = request.getParameter("major");
				String gender = request.getParameter("gender");
				
				response.setContentType("text/html; charset=utf-8");
				PrintWriter writer = response.getWriter();
				
				Custom c = new Custom(hobbys, major, gender);
				
				writer.println("<html><head></head><body>");
				writer.println("전공 : "+ c.getMajor() +"<br>");
				writer.println("성별 : "+ c.getGender() +"<br>");
				writer.println("취미 : "+ Arrays.toString(c.getHobbys()) +"<br>");
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
