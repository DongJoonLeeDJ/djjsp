<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>

<!-- ����Ʈ ���� false�̹Ƿ� ���� ��������� ����ϱ� ���ؼ� �� ���� true�� �־� �Ѵ�. -->
<%@ page isErrorPage="true"%>

<!-- ex) http status 500ó��, �� �������� ���� �ִµ� 200�� ����ó���̴�. -->
<!-- ����ó���Ȱɷ� ���ֽ�Ű���� ��. ������ 500���� �ڵ����� ������ �� �ֱ� �����̴�. -->
<% response.setStatus(200); %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
	���� �߻�<br />
<!-- 	isErrorPage=true�� �� �θ� �� exception��ü�� �� ���� -->
	<%= exception.getMessage() %>
</body>
</html>