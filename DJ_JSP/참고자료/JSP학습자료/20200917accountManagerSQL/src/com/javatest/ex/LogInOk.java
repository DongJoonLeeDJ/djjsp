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
 * Servlet implementation class LogInOk
 */
@WebServlet("/LogInSuccess")
public class LogInOk extends HttpServlet 
{
	private static final long serialVersionUID = 1L;
	
	Connection	connection;
	Statement	statement;
	ResultSet	resultSet;
	
	private String strName, strID, strPW, strPhone1, strPhone2, strPhone3, strGender;
	
    /**
     * @see HttpServlet#HttpServlet()
     */
    public LogInOk() {
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
		
		strID	=	request.getParameter("id");
		strPW	=	request.getParameter("pw");
		
		System.out.println(strID + " & " + strPW);
		
		
		//String	strQuery	=	"insert into member values ('" + strName + "','" + strID + "','" + strPW + "'" + ",'" + strPhone1 + "','" + strPhone2 + "','" + strPhone3 + "','" + strGender + "')"; 
		String	strQuery	=	"Select * from member where id = '" + strID + "' and pw = '" + strPW + "'";
		
		System.out.println(strQuery);
		
		
		try 
		{			
			String	strDriver	=	"oracle.jdbc.driver.OracleDriver";
			String	strURL		=	"jdbc:oracle:thin:@localhost:1521:xe";
			String	strUserID	=	"scott";
			String	strUserPW	=	"tiger";
			
			Class.forName(strDriver);
			connection	=	DriverManager.getConnection( strURL, strUserID, strUserPW );
			statement	=	connection.createStatement();
			resultSet	=	statement.executeQuery(strQuery);
			
			//// 행이 끝날 때까지 탐색..
			while( resultSet.next() )
			{
				//// column별로 data를 가져 옴.
				strName		=	resultSet.getString("name");
				strID	=   resultSet.getString("id");
				strPW	=	resultSet.getString("pw");
				strPhone1	=	resultSet.getString("phone1");
				strPhone2	=	resultSet.getString("phone2");
				strPhone3	=	resultSet.getString("phone3");
				strGender	=	resultSet.getString("gender");
								
			}	//	while( resultSet.next() ){..
			
			System.out.println( "id : " + strID + " pw : " + strPW );
			
			if(  strName != null  ) 
			{
				HttpSession	 httpSession	=	request.getSession();
				httpSession.setAttribute("name", strName);
				httpSession.setAttribute("id", strID);
				httpSession.setAttribute("pw", strPW);
				response.sendRedirect("loginResult.jsp");				
			}	//	if(  strName != null  ){..
			else
			{
				response.sendRedirect("login.html");
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
				
	}	//	private	void	doAction(

}