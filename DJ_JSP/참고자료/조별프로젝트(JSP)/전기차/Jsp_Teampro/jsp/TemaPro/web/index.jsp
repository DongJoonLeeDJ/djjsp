<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%
    String contentPage=request.getParameter("contentPage");
    if(contentPage==null){
        contentPage="FirstView.jsp";
    }
%>
<!DOCTYPE html>
<html lang="UTF-8">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>JSP Project</title>
        <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
        <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css" rel="stylesheet" />
        <link href="CSS/styles.css" rel="stylesheet" />
        <script  src="http://code.jquery.com/jquery-latest.min.js"></script>

        <style>
        	html{height:100%;}
        	body{height:100%; margin:0;}
 	        #wrap { 
 	        	min-height:100%;
 	        	position:relative;
 	            width: 100%; 
 	            margin : 0 auto 0 auto;
 	        }        
 	        #header { 	        	 
 	            text-align: center;
 	            width: 100%; 
 	            height: 200px;
 	            margin:0;
 	            display:inline;	            
 	        }	         
 	        #main {
 	            width: 100%;
 	            height:100%;
 	            min-height:700px;
 	            text-align:center;  
  	            vertical-align: bottom;
  	            position :relative;
  	            padding-bottom:50px;
 	        } 
 	        #footer { 	        
 	            width: 100%; 
 	            height: 30px;
   				bottom:0;
  				text-align: center;
  				color: white;
 	        }
        </style>
    </head>
    <body> 
    <div id="wrap">
    	<div id="header">
   			<jsp:include page="Header.jsp" />
        </div>    
    	<div id="main">
            <jsp:include page="<%=contentPage%>"/>
    	</div>
        <div class="py-5 bg-dark" id="footer">
            <p class="m-0 text-center text-white">Copyright &copy; Your Website 2021</p>
        </div>        
        <!-- Bootstrap core JS-->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"></script>
        <!-- Core theme JS-->
        <script src="js/scripts.js"></script>
     </div>
    </body>
</html>
	