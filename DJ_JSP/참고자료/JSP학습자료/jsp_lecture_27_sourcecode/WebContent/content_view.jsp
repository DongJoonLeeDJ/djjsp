<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>

	<table width="500" cellpadding="0" cellspacing="0" border="1">
		<form action="modify.do" method="post">
			<input type="hidden" name="bId" value="${content_view.bId}">
			<tr>
				<td> ��ȣ </td>
				<td> ${content_view.bId} </td>
			</tr>
			<tr>
				<td> ��Ʈ </td>
				<td> ${content_view.bHit} </td>
			</tr>
			<tr>
				<td> �̸� </td>
				<td> <input type="text" name="bName" value="${content_view.bName}"></td>
			</tr>
			<tr>
				<td> ���� </td>
				<td> <input type="text" name="bTitle" value="${content_view.bTitle}"></td>
			</tr>
			<tr>
				<td> ���� </td>
				<td> <textarea rows="10" name="bContent" >${content_view.bContent}</textarea></td>
			</tr>
			<tr >
				<td colspan="2"> <input type="submit" value="����"> &nbsp;&nbsp; <a href="list.do">��Ϻ���</a> &nbsp;&nbsp; <a href="delete.do?bId=${content_view.bId}">����</a> &nbsp;&nbsp; <a href="reply_view.do?bId=${content_view.bId}">�亯</a></td>
			</tr>
		</form>
	</table>
	
</body>
</html>