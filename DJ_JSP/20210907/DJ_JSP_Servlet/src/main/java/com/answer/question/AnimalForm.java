package com.answer.question;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class AnimalForm
 */
@WebServlet("/AnimalForm")
public class AnimalForm extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public AnimalForm() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
	
		request.setCharacterEncoding("utf-8");
		
		String aName = request.getParameter("a_myname");
		String aNumber = request.getParameter("a_mynumber");
		int aAge = 0;
		try {			
			aAge = Integer.parseInt(request.getParameter("a_myage"));
		} catch (Exception e) {
			e.printStackTrace();
		}
		String aKinds = request.getParameter("a_mykinds");
		
		Animal myAnimal = new Animal(aKinds,aName,aAge,aNumber);
		
		response.setContentType("text/html; charset=utf-8");
		PrintWriter writer = response.getWriter();
		writer.println("<html>");
		writer.println("<head></head>");
		writer.println("<body>");
		writer.println("<h1>이름 : "+ myAnimal.getName() +"</h1>");
		writer.println("<h1>나이 : "+ myAnimal.getAge() +"</h1>");
		writer.println("<h1>번호 : "+ myAnimal.getNumber() +"</h1>");
		writer.println("<h1>종류 : "+ myAnimal.getKinds() +"</h1>");
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
