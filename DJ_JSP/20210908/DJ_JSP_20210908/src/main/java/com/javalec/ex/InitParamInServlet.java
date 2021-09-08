package com.javalec.ex;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebInitParam;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class InitParamInServlet
 */
@WebServlet(
		urlPatterns = {"/InitParamInServlet"},
		initParams= 
				{
						@WebInitParam(name="name", value="aaaa"),
						@WebInitParam(name="path", value="sdfiuasdflkjla")
				}
		)
public class InitParamInServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public InitParamInServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		String name = getInitParameter("name");
		String path = getInitParameter("path");
		
		response.setContentType("text/html; charset=utf-8");
		
		response.getWriter().println("<body>");
		response.getWriter().println(name);
		response.getWriter().println("<br>");
		response.getWriter().println(path);
		response.getWriter().println(getInitParameter("path"));
		
		String id = getServletContext().getInitParameter("id");
		String pw = getServletContext().getInitParameter("pw");
		response.getWriter().println("id :" + id);
		response.getWriter().println("pw : " + pw);
		response.getWriter().println("</body>");
		
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
