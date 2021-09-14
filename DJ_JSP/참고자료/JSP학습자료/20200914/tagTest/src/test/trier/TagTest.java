package test.trier;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/TT")
public class TagTest extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public TagTest() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		System.out.println("HelloWorld~~");
		
		response.setContentType("text/html; charset=euc-kr");
		PrintWriter writer = response.getWriter();
		
		writer.println("<html>");
		writer.println("<head>");
		writer.println("</head>");
		writer.println("<body>");
		writer.println("<h1>한글출력</h1>");
		writer.println("</body>");
		writer.println("</html>");
		
		writer.close();
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		System.out.println("Poste~~~~~~~~~~~");
		
		response.setContentType("text/html; charset=euc-kr");
		PrintWriter writer = response.getWriter();
		
		writer.println("<html>");
		writer.println("<head>");
		writer.println("</head>");
		writer.println("<body>");
		writer.println("<h1>삽질을 너무 많이 했어</h1>");
		writer.println("</body>");
		writer.println("</html>");
		
		writer.close();

	}

}
