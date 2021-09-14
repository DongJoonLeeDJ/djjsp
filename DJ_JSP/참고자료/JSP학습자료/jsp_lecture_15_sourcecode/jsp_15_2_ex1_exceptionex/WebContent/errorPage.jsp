<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>

<!-- 디폴트 값은 false이므로 예외 페이지라고 명시하기 위해선 이 값을 true로 둬야 한다. -->
<%@ page isErrorPage="true"%>

<!-- ex) http status 500처럼, 그 페이지의 값이 있는데 200은 정상처리이다. -->
<!-- 정상처리된걸로 간주시키려고 함. 웹에서 500으로 자동으로 설정할 수 있기 때문이다. -->
<% response.setStatus(200); %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
	에러 발생<br />
<!-- 	isErrorPage=true로 안 두면 이 exception객체를 못 쓴다 -->
	<%= exception.getMessage() %>
</body>
</html>