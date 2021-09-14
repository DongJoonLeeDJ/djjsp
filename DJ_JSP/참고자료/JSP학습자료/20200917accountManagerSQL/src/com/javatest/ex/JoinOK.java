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

/**
 * Servlet implementation class JoinOK
 */





@WebServlet("/JoinOK")
public class JoinOK extends HttpServlet 
{
	private static final long serialVersionUID = 1L;
	
	Connection	connection;
	Statement	statement;
	ResultSet	resultSet;
	
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public JoinOK() {
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
		
		String	strName	=	request.getParameter("name");
		String	strID	=	request.getParameter("id");
		String	strPW	=	request.getParameter("pw");
		String	strPhone1	=	request.getParameter("phone1");
		String	strPhone2	=	request.getParameter("phone2");
		String	strPhone3	=	request.getParameter("phone3");
		String	strGender	=	request.getParameter("gender");
		
		
		System.out.println( " ---- Insert문에 삽입할 값 ---- " );
		System.out.println( strName );
		System.out.println( strID );
		System.out.println( strPW );
		
		System.out.println( strPhone1 );
		System.out.println( strPhone2 );
		System.out.println( strPhone3 );
		
		System.out.println( strGender );		
		System.out.println( " ---- Insert문에 삽입할 값 ---- " );
		
		
		//// insert Query文
		String	strQuery	=	"insert into member values ('" + strName + "','" + strID + "','" + strPW + "'" + ",'" + strPhone1 + "','" + strPhone2 + "','" + strPhone3 + "','" + strGender + "')"; 
		
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
			
			int i = statement.executeUpdate(strQuery);
			
			if( i == 1 ) {
				System.out.println( "성공" );
				response.sendRedirect("joinResult.jsp");
			}
			else
			{
				System.out.println( "실패" );
				response.sendRedirect("join.html");
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
