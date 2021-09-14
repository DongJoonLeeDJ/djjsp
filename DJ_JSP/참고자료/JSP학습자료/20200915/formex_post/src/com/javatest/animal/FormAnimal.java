package com.javatest.animal;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.javatest.student.Student;

/**
 * Servlet implementation class FormAnimal
 */
@WebServlet("/FormAnimal")
public class FormAnimal extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public FormAnimal() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		//�ѱ� ���� ó��
				request.setCharacterEncoding("utf-8");
				
				//�Ķ���� �޴� �κ�(Form�±��� �� �޴� �κ�)
				String vName = request.getParameter("name");
				String vAge = request.getParameter("age");
				String vNumber = request.getParameter("number");
				String kinds = request.getParameter("kinds");

				System.out.println();
				System.out.println();
				System.out.println();
				System.out.println(vName);
				System.out.println(vAge);
				System.out.println(vNumber);	
				System.out.println(kinds);	
				System.out.println();
				System.out.println();
				System.out.println();
				
				Animal ani = new Animal();
				ani.setName(vName);
				ani.setNumber(vNumber);
				ani.setKinds(kinds);

				System.out.println();
				System.out.println();
				System.out.println();
			
				System.out.println(ani.getKinds()); 
				System.out.println();
				System.out.println();
				System.out.println();
				try
				{
					ani.setAge(Integer.parseInt(vAge));
				}
				catch (Exception e) {
					// TODO: handle exception
					ani.setAge(20);
				}
				

				response.setContentType("text/html; charset=utf-8");
				PrintWriter writer = response.getWriter();
				
				writer.println("<html><head></head><body>");
				writer.println("�̸� : " + ani.getName() + "<br />");
				writer.println("���� : " + ani.getAge() + "<br />");
				writer.println("�ĺ���ȣ : " + ani.getNumber() + "<br />");
				writer.println("���� : " + ani.getKinds() + "<br />");
				writer.println("</body></html>");
				writer.close();
	}

}
