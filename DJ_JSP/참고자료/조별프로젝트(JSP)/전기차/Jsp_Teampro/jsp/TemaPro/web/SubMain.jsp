<%@page import="Ask.AskDTO"%>
<%@page import="java.util.ArrayList"%>
<%@page import="Ask.AskDBManager"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%
    String listPage=request.getParameter("listPage");
    if(listPage==null){
        listPage="Info/Info_first.jsp";
    }
%>
<!DOCTYPE html>
<html>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<link href="CSS/styles.css" rel="stylesheet" />
<head>
	<meta charset="UTF-8">
	<title>지자체 문의처</title>
</head>
<body>
    <div id="cartype" style="padding-top:30px;">
    	<h3>저공해차 구매보조금 관련 문의처</h3>
    	<input type="button" class="btn btn-outline-info" onclick="location.href='index.jsp?contentPage=SubMain.jsp?listPage=Info/Info_list_A.jsp'" value="전기승용"/>
    	<input type="button" class="btn btn-outline-info" onclick="location.href='index.jsp?contentPage=SubMain.jsp?listPage=Info/Info_list_B.jsp'" value="전기화물"/>
    	<input type="button" class="btn btn-outline-info" onclick="location.href='index.jsp?contentPage=SubMain.jsp?listPage=Info/Info_list_C.jsp'" value="전기승합"/>
    	<input type="button" class="btn btn-outline-info" onclick="location.href='index.jsp?contentPage=SubMain.jsp?listPage=Info/Info_list_D.jsp'" value="전기이륜차"/>
    	<input type="button" class="btn btn-outline-info" onclick="location.href='index.jsp?contentPage=SubMain.jsp?listPage=Info/Info_list_E.jsp'" value="수소연료전지차"/>
    	<input type="button" class="btn btn-outline-info" onclick="location.href='index.jsp?contentPage=SubMain.jsp?listPage=Info/Info_list_F.jsp'" value="건설기계"/>
    </div>
    <div id="main">
    	<jsp:include page="<%=listPage%>"/>
    </div>   
</body>
</html>