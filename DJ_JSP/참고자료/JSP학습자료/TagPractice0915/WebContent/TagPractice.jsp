<%@ page language="java" contentType="text/html; charset=EUC-KR"
	pageEncoding="EUC-KR"%>
<%@page import="java.util.Arrays"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
	<%--������ : <%@ %> :������ �Ӽ�
	�ּ� : <%-- --%>
	<%-- 	����: <%! %> :����, �޼ҵ� ����
	ǥ����: <%= %> :����� ���
	��ũ��Ʈ�� : <%  %> : java�ڵ�
	�׼��±�: <jsp:action></jsp:action> :�ڹٺ󿬰�--%>

	<%
		int i = 0;
	while (true) {
		i++;
		out.println("2 *" + i + "=" + (2 * i) + "<br/>");
	%>

	=============
	<br />
	<%
		if (i >= 5)
		break;
	}
	%>
	<br />
	====Arrays import====
	<%
	int[]iArr={10,20,30};
	%>
	<br />
	<br />
	<%
	out.println(Arrays.toString(iArr));
	%>
	<h1>include���Ϸ� �̵�!</h1>
	<%@ include file="include.jsp" %> <%--include.jsp�� ������ ���´�. --%>
	<a href="include.jsp">include.jsp��!</a> <%--�����۸�ũ�� include.jsp�� �̵��ϵ��� ���� --%>
</body>
</html>