<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <title>회원가입 처리 JSP</title>
    <link rel="stylesheet" href="../css/comm2.css">
</head>
<body>
    <!-- JoinForm.jsp에서 입력한 정보를 넘겨 받아 처리한다. -->
    <% 
        // 한글 깨짐을 방지하기 위한 인코딩 처리
        request.setCharacterEncoding("UTF-8"); 
    
        // getParameter()를 이용해 넘겨진 파라미터 값을 얻어올 수 있다.
        // 파라미터 값을 얻을때 name= 에 지정해둔 값과 동일한 값을 인자로 지정해야 된다.
        String id = request.getParameter("id");
        String password = request.getParameter("password");
        String name = request.getParameter("name");
        
        // 성별의 경우 파라미터 이름이 둘다 gender로 동일하므로 배열로 받아야 된다.
        String[] gender = request.getParameterValues("gender");
        String birthyy = request.getParameter("birth_yy");
        
        // 생일의 경우 <select>로 되어 있는데 파라미터 값을 받을 시 배열형태로 넘겨 받는다.
        String[] birthmm = request.getParameterValues("birth_mm");
        String birthdd = request.getParameter("birth_dd");
        String email1 = request.getParameter("email_1");
        
        // 이메일의 경우 <select>로 되어 있는데 파라미터 값을 받을 시 배열형태로 넘겨 받는다.
        String[] email2 = request.getParameterValues("email_2");
        String phone = request.getParameter("phone");
        String address = request.getParameter("address");
    %>
    
    <div id="wrap">
        <br><br>
        <b><font size="5" color="gray">회원가입 정보를 확인하세요.</font></b>
        <br><br>
        <font color="blue"><%=name %></font>님 가입을 축하드립니다.
        <br><br>
        
        <table>
            <tr>
                <td id="title">아이디</td>
                <td><%=id %></td>
            </tr>
                        
            <tr>
                <td id="title">비밀번호</td>
                <td><%=password %></td>
            </tr>
                    
            <tr>
                <td id="title">이름</td>
                <td><%=name %></td>
            </tr>
                    
            <tr>
                <td id="title">성별</td>
                <td>
                <%
                    // 배열로 넘겨받은 값을 처리하기 위해 for문 이용
                    for(String g : gender){
                        out.println(g);
                    }
                %>
                </td>
            </tr>
                    
            <tr>
                <td id="title">생일</td>
                <td>
                <%=birthyy %>년 
                <%
                    // 배열로 넘겨받은 값을 처리하기 위해 for문 이용
                    for(String mm : birthmm){
                        out.println(mm);
                    }        
                %>월 <%=birthdd %>일
                </td>
            </tr>
                    
            <tr>
                <td id="title">이메일</td>
                <td>
                    <%=email1 %>
                    <%
                    // 배열로 넘겨받은 값을 처리하기 위해 for문 이용
                    for(String e : email2){
                        out.println("@"+e);
                    }        
                    %>
                </td>
            </tr>
                    
            <tr>
                <td id="title">휴대전화</td>
                <td><%=phone %></td>
            </tr>
            <tr>
                <td id="title">주소</td>
                <td>
                    <%=address %>
                </td>
            </tr>
        </table>
        
        <br>
        <input type="button" value="확인">
    </div>
</body>
</html>