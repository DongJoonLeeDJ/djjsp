package kb;
import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class UserRegisterServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");
		response.setContentType("text/html;charset=UTF-8");
		String userID = request.getParameter("userID");
		String userPassword1 = request.getParameter("userPassword1");
		String userPassword2 = request.getParameter("userPassword2");
		String userName = request.getParameter("userName");
		String userPhone = request.getParameter("userPhone");
		
		if(userID == null || userID.equals("") || userPassword1 == null || userPassword1.equals("")
				|| userPassword2 == null || userPassword2.equals("") || userName == null || userName.equals("")
				|| userPhone == null || userPhone.equals("")) {
			request.getSession().setAttribute("messageType", "오류 메시지");
			request.getSession().setAttribute("messageContent", "모든 내용을 입력하세요.");
			response.sendRedirect("http://localhost:9200/JYpro/login/signin.jsp");
			return;
		}
		if(!userPassword1.equals(userPassword2)) {
			request.getSession().setAttribute("messageType", "오류 메시지");
			request.getSession().setAttribute("messageContent", "비밀번호가 서로 일치하지 않습니다.");
			response.sendRedirect("http://localhost:9200/JYpro/login/signin.jsp");
			return;
		}
		int result = new ConnMysql().register(userID,userPassword1,userName,userPhone);
		if(result ==1) {
			request.getSession().setAttribute("messageType", "성공 메시지");
			request.getSession().setAttribute("messageContent", "회원가입에 성공했습니다. 로그인을 완료해 주세요.");
			response.sendRedirect("http://localhost:9200/JYpro/login/login.jsp");
			return;
		}
		else {
			
			request.getSession().setAttribute("messageType", "오류 메시지");
			request.getSession().setAttribute("messageContent", "이미 존재하는 회원입니다.");
			response.sendRedirect("http://localhost:9200/JYpro/login/signin.jsp");
			return;
		}
	}

}
