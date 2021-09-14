<%@page import="Ask.AskDTO"%>
<%@page import="java.util.ArrayList"%>
<%@page import="Ask.AskDBManager"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%
	AskDBManager adb = new AskDBManager();
	ArrayList<Ask.AskDTO> list = adb.select("건설기계");
%>
</head>
<body>
<%
	String listPage;
%>	
	<div class="container my-3 text-center">
	<h4 style="color:#5872A5;"><2021년도 전기자동차(건설기계) 지자체 연락처></h4>    
		<table class="table table-bordered my-3">
   			<thead>
     			<tr>
			        <th>시도</th>
			        <th>지역구분</th>
			        <th>담당부서</th>
			        <th>연락처</th>        
			    </tr>
			</thead>
   			<tbody>
		      <%
		      	for(int i=0; i<list.size(); i++){
		      		    	  Ask.AskDTO info_list = list.get(i);
		      %>
		      <tr>
		      	<td><% out.print(info_list.getCity()); %></td>
		      	<td><% out.print(info_list.getSido()); %></td>
		      	<td><% out.print(info_list.getDep()); %></td>
		      	<td><% out.print(info_list.getPn()); %></td>
		      </tr>
		      <% } %>
		    </tbody>
		</table>
	</div>
</body>
</html>