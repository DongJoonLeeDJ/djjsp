<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

<!--  존재하지도 않는 사이트 방문 시도 -> 404에러 유발 -->
<jsp:forward page="abcd.jsp"></jsp:forward>

</body>
</html>