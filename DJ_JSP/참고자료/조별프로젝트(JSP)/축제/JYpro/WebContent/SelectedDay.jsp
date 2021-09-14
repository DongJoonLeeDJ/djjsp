<%@page import="example.Festival"%>
<%@page import="java.util.ArrayList"%>
<%@page import="example.Festival_DBManager"%>
<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>

<%
Festival_DBManager fsdb=new Festival_DBManager();

String sday = request.getParameter("day");
String smonth = request.getParameter("month");
String syear = request.getParameter("year");

String selected_date = syear;

if(Integer.parseInt(smonth)<10)
{
	smonth="-0"+smonth;	
}
else
	smonth="-"+smonth;

if(Integer.parseInt(sday)<10)
{
	sday="-0"+sday;
}
else
	sday="-"+sday;

selected_date+=smonth+sday;
ArrayList<Festival> list = fsdb.SelectFestivalByDate(selected_date);   

%>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>축제 목록</title>

<script>
		var parent=null;
		var fst_name=null;
		var fst_x=null;
		var fst_y=null;
		var im=null;
// 		테스트용 지금 안씀
        function onLoad(){   
        parent = window.opener;
//         alert(window.name)
		alert(window.closed)
		parent.popupClose();
// 		opener.close();
        window.top;
        }
        function fesClick(fst_name){
        	//현재 창을 닫고 기존(부모)창을 이동 시킴->값으로 축제명을 넘겨줌
        	window.close();
        	opener.location.href="festival.jsp?fes_name="+fst_name;
        }
        function unLoad(){
        	window.close();
        }
</script>
		<!-- all css here -->
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <link rel="stylesheet" href="css/font-awesome.min.css">
        <link rel="stylesheet" href="css/pe-icon-7-stroke.css">
        <link rel="stylesheet" href="css/owl.carousel.css">
		<link rel="stylesheet" href="css/magnific-popup.css">
		<link rel="stylesheet" href="css/meanmenu.css">
        <link rel="stylesheet" href="style.css">
        <link rel="stylesheet" href="css/responsive.css">
        <script src="js/vendor/modernizr-2.8.3.min.js"></script>
        <!-- 박상준 -->
    	<link rel="stylesheet" type="text/css" href="css/styles.css"/>

</head>
<body>
	<div class="header-top-area black-bg hidden-xs" style="min-height:41.14px">
			<div class="container">
				<div class="row">
				</div>
			</div>
	</div>
<div>

<%for(int i =0;i<list.size();i++){	
	Festival fst = list.get(i);
	%>
	<script type="text/javascript">
		fst_name='<%=fst.getFes_name()%>'
	</script>
	<a href="" onclick="fesClick('<%=fst.getFes_name()%>')">
		<%=fst.getFes_name()%>
	</a><br>
<%} %>

</div>


</body>
</html>