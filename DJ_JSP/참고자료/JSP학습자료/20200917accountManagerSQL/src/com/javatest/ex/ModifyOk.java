package com.javatest.ex;

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class JoinOK
 */





@WebServlet("/ModifyOk")
public class ModifyOk extends HttpServlet 
{
	private static final long serialVersionUID = 1L;
	
	Connection	connection;
	Statement	statement;
	ResultSet	resultSet;
	
	String strName, strID, strPW, strPhone1, strPhone2, strPhone3, strGender;
	
	HttpSession httpSession;
	
	/**
     * @see HttpServlet#HttpServlet()
     */
    public ModifyOk() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		System.out.println(".....!!!");
		response.getWriter().append("Served at: ").append(request.getContextPath());

	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	//	doGet(request, response);
		System.out.println(".....");
		doAction( request, response );
	}
	
	private	void	doAction( HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("utf-8");
		
		strName	=	request.getParameter("name");
		strID	=	request.getParameter("id");
		strPW	=	request.getParameter("pw");
		strPhone1	=	request.getParameter("phone1");
		strPhone2	=	request.getParameter("phone2");
		strPhone3	=	request.getParameter("phone3");
		strGender	=	request.getParameter("gender");
		
		String	strQuery	=	"update member set name = '"+strName+"', phone1 = '"+strPhone1+"', "
				+ "phone2 = '" + strPhone2 +"', phone3 = '"+strPhone3+"', gender = '"+strGender+"' where id = '"+strID+"'";
		System.out.println(strQuery);
		
		httpSession = request.getSession();
		
		if(confirmPw())
		{

			try 
			{			
				String	strDriver	=	"oracle.jdbc.driver.OracleDriver";
				String	strURL		=	"jdbc:oracle:thin:@localhost:1521:xe";
				String	strUserID	=	"scott";
				String	strUserPW	=	"tiger";
				
				Class.forName(strDriver);
				connection	=	DriverManager.getConnection( strURL, strUserID, strUserPW );
				statement	=	connection.createStatement();
				
				int i = statement.executeUpdate(strQuery);
				
				if( i == 1 ) {
					System.out.println( "성공" );
					httpSession.setAttribute("name", strName);
					response.sendRedirect("modifyResult.jsp");
				}
				else
				{
					System.out.println( "실패" );
					response.sendRedirect("modify.jsp");
				}
				
			}
			catch( Exception e ) {
				e.printStackTrace();
			}
			finally 
			{
				try 
				{
					if(  statement != null  )
						statement.close();
					if(  connection != null  )
						connection.close();
				}
				catch( Exception e ) {
					e.printStackTrace();
				}
			}
		} else
		{
			System.out.println("NG");
		}
				
	}	//	private	void	doAction(

	private boolean confirmPw()
	{
		String sessionPw = (String)httpSession.getAttribute("pw");
		if(strPW.equals(sessionPw))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
}
