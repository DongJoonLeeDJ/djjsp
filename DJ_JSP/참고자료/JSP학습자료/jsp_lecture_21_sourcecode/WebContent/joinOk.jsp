<%@page import="java.sql.Timestamp"%>
<%@page import="com.javalec.ex.*"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<% request.setCharacterEncoding("EUC-KR"); %>

<!-- DTO dto = new DTO(); -->
<jsp:useBean id="dto" class="com.javalec.ex.MemberDto"/>

<!-- dto의 모든 멤버변수 값을 set 하겠다라는 의미 -->
<!-- * : 자동적으로 입력되게 하기, 이걸 쓰려고 하면 DTO 상의 멤버변수 이름이랑 form 태그상의 name 속성이랑 값이 똑같아야 함 -->
<!-- *을 씀으로 인해서 action=joinOk.jsp 하는 시점에 dto 변수의 모든 멤버변수 값들이 다 입력됨 -->
<jsp:setProperty name="dto" property="*" />
<%
		dto.setrDate(new Timestamp(System.currentTimeMillis()));
		MemberDao dao = MemberDao.getInstance(); //생성하지 않고 그냥 인스턴스를 가져온다.
		//객체를 계속 생성해서 쓰는 게 아니고 하나의 객체 가지고 쓴다.
		//이런걸 싱글톤 패턴이라고 한다.
		
		//생성자 private로 둔다.
		//생성을 할 수 없는 대신 static 메소드인 getInstance로 미리 생성된 인스턴스인 'instance'로 접근한다. 
		
		//하나만 만들어진 이 유일한 객체를 모든 곳에 공유해서 쓸 수 있다.
		
		//사용자가 입력한 아이디가 적합한지 검사한다.
		
		//싱글톤패턴... 클래스명.함수 이런식으로 쓸거면 함수 변수에 다 static 붙여야함
		//근데 getinstance를 이용하게되면 하나의 변수에만 static 붙이면
		//클래스명.함수, 클래스명.변수처럼 쓸 수 있게 된다.어차피 이 하나의 객체만 사용할거니까...
		if(dao.confirmId(dto.getId()) == MemberDao.MEMBER_EXISTENT) {
%>
		<script language="javascript">
			alert("아이디가 이미 존재 합니다.");
			history.back(); //다시 회원가입페이지로 이동해버리게 하는 것
		</script>
<%
		} else {
			int ri = dao.insertMember(dto);
			if(ri == MemberDao.MEMBER_JOIN_SUCCESS) {
				session.setAttribute("id", dto.getId());
%>
			<script language="javascript">
				alert("회원가입을 축하 합니다.");
				document.location.href="login.jsp";
			</script>
<%
			} else {
%>
			<script language="javascript">
				alert("회원가입에 실패했습니다.");
				document.location.href="login.jsp";
			</script>
<%
			}
		}
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
	
</body>
</html>