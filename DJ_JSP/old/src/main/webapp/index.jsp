<%@ page language="java" 
contentType="text/html; 
charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
	
    <!-- Bootstrap CSS -->
<!--<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"> -->
	<link rel="stylesheet" href="bootstrap4.css">
    <title>Hello, world!</title>
    
    <style>
    	#Hello
    	{
    		color : red;
    	}
    	#Bye
    	{
    		color : yellow;
    	}
    	.btn
    	{
    		font-style : italic
    	}
    	div.ldj
    	{
    		background : springgreen
    	}
    	div
    	{
    		border : 1px solid black
    	}
    	
    	.lng>h1 /*자손*/
    	{
    	font-size : xx-large
    	}
    	.lng h1 /*후손*/
    	{
    		text-decoration :underline
    	}
    	
    </style>
    
  </head>
  <body>
  <div class="ldj">
    <h1 id="Hello" class="btn btn-danger">Hello, world! 하이</h1>
	<h1 id="Bye" class="btn btn-dark">Bye, world! ㅂㅂ2</h1>
  </div>
  
  
  <div class="lng">
    <h1 class="btn btn-danger">아침 먹었는데 왜 벌써 배고플까</h1>
    <h2 class="btn-primary">오늘도 평화로운 603호</h2>
    <div>
		<h1 class="btn btn-dark">Bye, world! ㅂㅂ2</h1>
		<h2 class="btn btn-primary">어어어어어</h2>
	</div>
  </div>
  
  
  
  
    <!-- Optional JavaScript; choose one of the two! -->

    <!-- Option 1: Bootstrap Bundle with Popper -->
<!--     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script> -->

    <!-- Option 2: Separate Popper and Bootstrap JS -->
    <!--
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
    -->
  </body>
</html>