package com.start.servlet;

import java.io.IOException;

import javax.annotation.PostConstruct;
import javax.annotation.PreDestroy;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class TestLifeCycle
 */
@WebServlet("/TestLifeCycle")
public class TestLifeCycle extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public TestLifeCycle() {
        super();
        // TODO Auto-generated constructor stub
    }
    
    //처음 웹페이지 생성때 호출됨
    @Override
    public void init() throws ServletException {
    	// TODO Auto-generated method stub
    	super.init();
    	System.out.println("init");
    }
    
    //톰캣서버가 꺼지거나 화면을 새로고칠 때(단순히 새로고침 말고 서블릿 내용이 바뀌어서 다시 서버에 올릴 때)
    @Override
    public void destroy() {
    	// TODO Auto-generated method stub
    	super.destroy();
    	System.out.println("destroy");
    }
    
    @Override
    protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
    	// TODO Auto-generated method stub
    	super.service(req, resp);
    	System.out.println("service");
    }
    
    @PostConstruct
    private void ABCD()
    {
    	System.out.println("post construct");
    }
    
    @PreDestroy
    private void EFGH()
    {
    	System.out.println("PreDestroy(After Destroy)");
    }
    
    //Init -> PostConstruct -> service-> doGet, doPost -> destroy -> PreDestroy 

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
		System.out.println("Get");
		response.getWriter().println("   G   e    t   ");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		response.getWriter().println("Post");
	}

}
