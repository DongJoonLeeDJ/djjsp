package Member;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/idcheck")
public class IdCheck extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	protected void doPost(HttpServletRequest requset, HttpServletResponse response) throws ServletException, IOException {
		
		requset.setCharacterEncoding("UTF-8");
		response.setContentType("text/html;charset=UTF-8");
		String userID = requset.getParameter("userid");
		response.getWriter().write(new MemberDBManage().IdCheck(userID) + "");
		
	}
}