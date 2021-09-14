<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	
	<link rel="stylesheet" href="../css/bootstrap.min.css">
	<link rel="stylesheet" href="../css/font-awesome.min.css">
	<link rel="stylesheet" href="../css/pe-icon-7-stroke.css">
	<link rel="stylesheet" href="../css/owl.carousel.css">
	<link rel="stylesheet" href="../css/magnific-popup.css">
	<link rel="stylesheet" href="../css/meanmenu.css">
	<link rel="stylesheet" href="../style.css">
	<link rel="stylesheet" href="../css/responsive.css">
	<script src="../js/vendor/modernizr-2.8.3.min.js"></script>

	<link rel="stylesheet" href="../css/bootstrap.css">
	<link rel="stylesheet" href="../css/custom.css">

	
	<title>회원가입</title>
	<script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
	<script src="../js/bootstrap.js"></script>
	<script type="text/javascript">
		function registerCheckFunction(){
			var userID = $('#userID').val();
			$.ajax({
				type:'POST',
				url:'../UserRegisterCheckServlet',
				data:{userID:userID},
				success:function(result){
					if(result == 1){
						$('#checkMessage').html('사용할수 있는 아이디입니다.');
						$('#checkType').attr('class','modal-content panel-success');
					}
					else{
						$('#checkMessage').html('사용할수 없는 아이디입니다.');
						$('#checkType').attr('class','modal-content panel-warning');
					}
					$('#checkModal').modal("show");
				}
			})
		}
		function passwordCheckFunction(){
			var userPassword1 =$('#userPassword1').val();
			var userPassword2 =$('#userPassword2').val();
			if(userPassword1 != userPassword2){
				$('#passwordCheckMessage').html('비밀번호가 서로 일치하지 않습니다.');
			}else{
				$('#passwordCheckMessage').html('');
			}
		}
	</script>
</head>
<body>
<!-- header start -->
		<header>
			<div class="header-top-area black-bg hidden-xs">
				<div class="container">
					<div class="row">
						<div class="col-md-6 col-sm-6">
<!-- 							<ul class="top-right"> -->
<!-- 								<li> -->
<!-- 									<i class="fa fa-envelope"></i> -->
<!-- 									<span id="userId">qkr03210@gmail.com</span> -->
<!-- 								</li> -->
<!-- 								<li> -->
<!-- 									<i class="fa fa-phone"></i> -->
<!-- 									<span>+82 10 9774 5263</span> -->
<!-- 								</li> -->
<!-- 							</ul> -->
						</div>
						<div class="col-md-6 col-sm-6 hidden-xs">
							<div class="header-icon floatright">
								<a href="https://github.com/dhw1009/JspTeamproject"><i class="fa fa-github"></i></a>
							</div>							
						</div>
					</div>
				</div>
			</div>
			<!-- header end -->
			<!-- main-menu-area-start -->
			<div class="main-menu-area">
				<div class="container">
					<div class="row">
						<div class="col-md-3 col-sm-2">
							<div class="logo">
								<a href="../index.jsp"><img src="../img/logo/1.png" alt="" /></a>
							</div>
						</div>
						<div class="col-md-9 col-sm-10">
							<div class="main-menu floatright">
								<nav>
									<ul>
										<li class="active"><a href="../index.jsp">Home</a>
										</li>
										<li><a href="../bbs/bbs.jsp">community</a></li>
										<li><a href="../team.jsp">team</a></li>
									</ul>
								</nav>
							</div>
							<div class="mobile-menu-area"></div>
						</div>
					</div>
				</div>
			</div>
			<!-- main-menu-area-end -->
		</header>
		<!-- header end -->
	<div class="container">
		<form method="post" action="../userRegister">
			<table class="table table-bordered table-hover" style="text-align:center; border:1px solid #dddddd;">
				<thead>
					<tr>
						<th colspan="3"><h4>회원 등록 양식</h4></th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td style="width:110px;"><h5>아이디</h5></td>
						<td><input class="form-control" type="text" id="userID" name="userID" maxLength="20" placeholder="아이디를 입력해주세요."></td>
						<td style="width:110px;"><button class="btn btn-primary" onclick="registerCheckFunction();" type="button">중복체크</button></td>
					</tr>
					<tr>
						<td style="width:110px;"><h5>비밀번호</h5></td>
						<td colspan="2"><input class="form-control" type="password"  id="userPassword1" name="userPassword1" maxLength="20" placeholder="비밀번호를 입력해주세요."></td>
					</tr>
					<tr>
						<td style="width:110px;"><h5>비밀번호 확인</h5></td>
						<td colspan="2"><input class="form-control" type="password" onkeyup="passwordCheckFunction();" id="userPassword2" name="userPassword2" maxLength="20" placeholder="비밀번호 확인을 입력해주세요."></td>
					</tr>
					<tr>
						<td style="width:110px;"><h5>이름</h5></td>
						<td colspan="2"><input class="form-control" type="text" id="userName" name="userName" maxLength="20" placeholder="이름을 입력해주세요."></td>
					</tr>
					<tr>
						<td style="width:110px;"><h5>전화번호</h5></td>
						<td colspan="2"><input class="form-control" type="text" id="userPhone" name="userPhone" maxLength="20" placeholder="전화번호를 입력해주세요."></td>
					</tr>
					<tr>
						<td style="text-align:left" colspan="3"><h5 style="color:red;" id="passwordCheckMessage"></h5><input class="btn btn-primary pull-right" type="submit" value="회원가입"></td>
					</tr>
				</tbody>
			</table>
		</form>
	</div>
	<%
		String messageContent = null;
		if(session.getAttribute("messageContent") != null){
			messageContent = (String) session.getAttribute("messageContent");
		}
		
		String messageType = null;
		if(session.getAttribute("messageType") != null){
			messageType = (String) session.getAttribute("messageType");
		}
		
		if(messageContent != null){
	%>
		<div class="modal fade" id="messageModal" tabindex = "-1" role="dialog" aria-hidden="true">
			<div class="vertical-alignment-helper">
				<div class="modal-dialog vertical-align-center">
					<div class="modal-content <%if(messageType.equals("오류메세지")) out.println("panel-warning"); else out.println("panel-success");%>">
						<div class="modal-header panel-heading">
							<button type="button" class="close" data-dismiss="modal">
								<span aria-hidden="true">&times;</span>
								<span class="sr-only">Close</span>
							</button>
							<h4 class="modal-title">
								<%=messageType %>
							</h4>
						</div>
						<div class="modal-body">
							<%=messageContent %>
						</div>
						<div class="modal-footer">
							<button type="button" class="btn btn-primary" data-dismiss="modal">확인</button>
						</div>
					</div>
				</div>
			</div>
		</div>
		<script>
			$('#messageModal').modal("show");
		</script>
	<%
		session.removeAttribute("messageContent");
		session.removeAttribute("messageType");
		}
	%>

	<div class="modal fade" id="checkModal" tabindex="-1" role="dialog"
		aria-hidden="true">
		<div class="vertical-alignment-helper">
			<div class="modal-dialog vertical-align-center">
				<div id="checkType" class="modal-content panel-info">
					<div class="modal-header panel-heading">
						<button type="button" class="close" data-dismiss="modal">
							<span aria-hidden="true">&times;</span> <span class="sr-only">Close</span>
						</button>
						<h4 class="modal-title">
							확인 메세지
						</h4>
					</div>
					<div class="modal-body" id="checkMessage">
					</div>
					<div class="modal-footer">
						<button type="button" class="btn btn-primary" data-dismiss="modal">확인</button>
					</div>
				</div>
			</div>
		</div>
	</div>

</body>
</html>
