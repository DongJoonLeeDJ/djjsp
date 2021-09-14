package com.javatest.ldj;

import java.io.IOException;

import javax.annotation.PostConstruct;
import javax.annotation.PreDestroy;
import javax.servlet.ServletConfig;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/HC")
public class HelloCycle extends HttpServlet {
	private static final long serialVersionUID = 1L;
    public HelloCycle() {
        super();
    }
	public void init(ServletConfig config) throws ServletException {
		System.out.println("INIT");
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		System.out.println("Do GET");
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		System.out.println("Do pOST");
	}
	
	@PostConstruct
	private void abc()
	{
		System.out.println("post construct!!!!");
	}
	
	@Override
	public void destroy() {
		System.out.println("destroy~");
	}
	
	@PreDestroy
	private void realDestroy()
	{
		System.out.println("last final destroy");
	}
	

}
