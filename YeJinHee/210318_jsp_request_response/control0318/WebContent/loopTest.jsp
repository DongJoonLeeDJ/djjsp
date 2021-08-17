<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
	String strArray[] = { "java", "jsp", "android", "html5" };
for (int i = 0; i < strArray.length; i++) {
	out.println("strArray[" + i + "]=" + strArray[i] + "<br>");
}

int i = 0;
while (i < 10) {
	out.println("출력: " + i + "<br>");
	i++;
}
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2><%=strArray[0]%></h2>

</body>
</html>