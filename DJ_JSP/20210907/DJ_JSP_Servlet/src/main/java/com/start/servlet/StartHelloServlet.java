package com.start.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class StartHelloServlet
 */
@WebServlet({ "/StartHelloServlet", "/ABCDEFG", "/DJ_Put_it_back_on" })
public class StartHelloServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public StartHelloServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		// get 방식으로 이 servlet에 접근할 경우 호출함
		PrintWriter p = response.getWriter();
		response.getWriter().append("Served at: ").append(request.getContextPath());
		p.println("Hello I am Get");
		
		//doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//post 방식으로 접근할 경우 여기를 호출함
		//doGet(request, response);
		PrintWriter p = response.getWriter();
		p.println("Hi there I am Post");
		
	}

}
