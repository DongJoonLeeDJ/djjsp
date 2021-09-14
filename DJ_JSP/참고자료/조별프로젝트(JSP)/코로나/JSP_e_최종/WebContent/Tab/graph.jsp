<%@page import="jsp.com.org.Covid_Data.Covid_Data"%>
<%@page import="jsp.com.org.Covid_Data.Covid_Data_Info"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<% String ID= (String)session.getAttribute("ID");%>
<%
	Covid_Data CData = new Covid_Data();
	ArrayList<Covid_Data_Info> CDI = new ArrayList<Covid_Data_Info>();
	CDI = CData.Addr_Select();
	ArrayList<Covid_Data_Info> WCDI = new ArrayList<Covid_Data_Info>();
	WCDI = CData.Week_Select();
%>
<style type="text/css">
	.rectColor{
		stroke:#000000;
		stroke-width : 1px;
		fill : #9999FF;
	}
	rect{
		stroke:#000000;
		stroke-width : 1px;
		fill : #9999CC;
	}
</style>

<html>

<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<script src="https://d3js.org/d3.v6.min.js" charset="UTF-8"></script>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="../css/Style.css"/>
</head>
<body>
<header>
	<nav class="navbar navbar-expand-sm">
  <!-- Brand -->
  	<a font-weight: bold;" class="navbar-brand" href="../Main.jsp">COVID-19</a>

  <!-- Links -->
  	<ul class="navbar-nav">
  		<li class="nav-item">
      		<a class="nav-link" href="../Main.jsp">메인</a>
    	</li>
    	<li class="nav-item">
     		<a class="nav-link" href="graph.jsp">코로나 확진 현황</a>
    	</li>
    	<li class="nav-item">
     		<a class="nav-link" href="../vaccineInfo.jsp">백신 예방 접종</a>
    	</li>
    	<li class="nav-item">
    		<a class="nav-link" href="NoticeBoard.jsp">국민의 소리</a>
    	</li>
    	 <li class="nav-item">
      		<a class="nav-link" href="../survey.jsp">설문조사</a>
    	</li>
    </ul>
	<!-- 로그인 안될시에 보이는 화면 -->
    <%
    	if(ID == null ){
    %>
    <!-- Dropdown -->
    <ul class="navbar-nav navbar-right">
    	<li class="nav-item dropdown">
      		<a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">접속하기</a>
      		<div class="dropdown-menu">
        		<a class="dropdown-item" href="../loginPage.jsp">로그인</a>
        		<a class="dropdown-item" href="../memberInsert.jsp">회원가입</a>
      		</div>
    	</li>
  	</ul>
  <%
  	}else{
  %>
  <ul class="navbar-nav navbar-right">
  	<li class="nav-item dropdown">
    	<a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">회원관리</a>
      	<div class="dropdown-menu">
        	<a class="dropdown-item" href= "../check/logout.jsp">로그아웃</a>
      	</div>
    	</li>
  </ul>
  <%
  	}
   %>
</nav>
	</header>
	<script type="text/javascript">

	
	</script>
	
	<div class = "container mt-3" align="center">
	<button class = "btn btn-outline-info col-5 " id = "btn1">전체 확진자현황</button>
	<button class = "btn btn-outline-info col-5 " id = "btn2">주간 확진자현황</button>
	</div>	
	<div class = "container">
	 <svg id="Graph" style="display:none" width = "1200", height = "800"></svg>
     <svg id="Week" style="display:none" width = "1200", height = "800"></svg>
    </div>
    
<script type="text/javascript">
		$('#btn1').click(function(){
			$('#Graph').attr("style","display:block")
			$('#Week').attr("style","display:none")
				var y=1;
				<%for(int i=0; i<WCDI.size(); i++){%>
				var index = "<%=CDI.get(i)%>";
				
				var AddrCount = index.indexOf(",");
				var AddrCount2 = index.indexOf("]");
				Count = index.substring(AddrCount+1,AddrCount2)
				Count =Count/5;
				var AddrName = index.indexOf("[");
				var AddrName2 = index.indexOf(",");
				Name = index.substring(AddrName+1,AddrName2)
				
				d3.select("#Graph")
					.append("rect")
					.attr("class","rectColor")
					.attr("x",(<%=i%>+1)*43)
					.attr("y",770-Count)
					.attr("width",30)
					.attr("height",Count)
					
					
				d3.select("#Graph")
					.append("text")
				    .text(Name)
				    .attr("x", (<%=i%>+1)*43)
				    .attr("y", 790)
				    .attr("font-family", "sans-serif")
				    .attr("font-size", "10px")
				    .attr("fill", "black")
				    .attr("text-anchor", "left")
				    
				d3.select("#Graph")
					.append("text")
				    .text(Count*5)
				    .attr("x", (<%=i%>+1)*43)
				    .attr("y", 780-Count)
				    .attr("font-family", "sans-serif")
				    .attr("font-size", "11px")
				    .attr("fill", "black")
				    .attr("text-anchor", "left")
				y++;
		<%}%>
		})
</script>

<script type="text/javascript">
	$('#btn2').click(function(){
		$('#Week').attr("style","display:block")
		$('#Graph').attr("style","display:none")
			var y=1;
			<%for(int i=0; i<WCDI.size(); i++){%>
			var index = "<%=WCDI.get(i)%>";
			var AddrCount = index.indexOf(",");
			var AddrCount2 = index.indexOf("]");
			Count = index.substring(AddrCount+1,AddrCount2)
			Count = Count*3
			var AddrName = index.indexOf("[");
			var AddrName2 = index.indexOf(",");
			Name = index.substring(AddrName+1,AddrName2)
			
			d3.select("#Week")
				.append("rect")
				.attr("class","rectColor")
				.attr("x",(<%=i%>+1)*43)
				.attr("y",770-Count)
				.attr("width",30)
				.attr("height",Count)
				
				
			d3.select("#Week")
				.append("text")
			    .text(Name)
			    .attr("x", (<%=i%>+1)*43)
			    .attr("y", 790)
			    .attr("font-family", "sans-serif")
			    .attr("font-size", "10px")
			    .attr("fill", "black")
			    .attr("text-anchor", "left")
			    
			d3.select("#Week")
				.append("text")
			    .text(Count/3)
			    .attr("x", (<%=i%>+1)*43)
			    .attr("y", 780-Count)
			    .attr("font-family", "sans-serif")
			    .attr("font-size", "11px")
			    .attr("fill", "black")
			    .attr("text-anchor", "left")
			y++;
			<%}%>
	})
</script>


</body>
</html>



