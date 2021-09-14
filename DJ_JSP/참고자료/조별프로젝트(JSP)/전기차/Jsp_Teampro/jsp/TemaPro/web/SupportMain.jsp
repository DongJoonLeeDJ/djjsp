<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<link href="CSS/styles.css" rel="stylesheet" />
<head>
	<meta charset="UTF-8">
	<title>차종별, 시도별 보조금 금액 조회</title>
<style>
	.btn-info{
		width:150pt;
		height:120pt;
		font-size : 28px;
	}
	#area{
		padding-top : 150px;
		padding-bottom:200px;
	}
</style>
</head>
<body>
<%
        String contentPage;
%>
<div id="area">
	<input type="button" class="btn btn-info mr-5" value="차종별" onclick="location.href='index.jsp?contentPage=CarSearch/CarS.jsp'">
	<input type="button" class="btn btn-info" value="시도별" onclick="location.href='index.jsp?contentPage=CarSupportFund/CarSF.jsp'">
</div>


</body>
</html>