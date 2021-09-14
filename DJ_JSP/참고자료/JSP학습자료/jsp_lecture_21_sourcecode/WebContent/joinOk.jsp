<%@page import="java.sql.Timestamp"%>
<%@page import="com.javalec.ex.*"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<% request.setCharacterEncoding("EUC-KR"); %>

<!-- DTO dto = new DTO(); -->
<jsp:useBean id="dto" class="com.javalec.ex.MemberDto"/>

<!-- dto�� ��� ������� ���� set �ϰڴٶ�� �ǹ� -->
<!-- * : �ڵ������� �Էµǰ� �ϱ�, �̰� ������ �ϸ� DTO ���� ������� �̸��̶� form �±׻��� name �Ӽ��̶� ���� �Ȱ��ƾ� �� -->
<!-- *�� ������ ���ؼ� action=joinOk.jsp �ϴ� ������ dto ������ ��� ������� ������ �� �Էµ� -->
<jsp:setProperty name="dto" property="*" />
<%
		dto.setrDate(new Timestamp(System.currentTimeMillis()));
		MemberDao dao = MemberDao.getInstance(); //�������� �ʰ� �׳� �ν��Ͻ��� �����´�.
		//��ü�� ��� �����ؼ� ���� �� �ƴϰ� �ϳ��� ��ü ������ ����.
		//�̷��� �̱��� �����̶�� �Ѵ�.
		
		//������ private�� �д�.
		//������ �� �� ���� ��� static �޼ҵ��� getInstance�� �̸� ������ �ν��Ͻ��� 'instance'�� �����Ѵ�. 
		
		//�ϳ��� ������� �� ������ ��ü�� ��� ���� �����ؼ� �� �� �ִ�.
		
		//����ڰ� �Է��� ���̵� �������� �˻��Ѵ�.
		
		//�̱�������... Ŭ������.�Լ� �̷������� ���Ÿ� �Լ� ������ �� static �ٿ�����
		//�ٵ� getinstance�� �̿��ϰԵǸ� �ϳ��� �������� static ���̸�
		//Ŭ������.�Լ�, Ŭ������.����ó�� �� �� �ְ� �ȴ�.������ �� �ϳ��� ��ü�� ����ҰŴϱ�...
		if(dao.confirmId(dto.getId()) == MemberDao.MEMBER_EXISTENT) {
%>
		<script language="javascript">
			alert("���̵� �̹� ���� �մϴ�.");
			history.back(); //�ٽ� ȸ�������������� �̵��ع����� �ϴ� ��
		</script>
<%
		} else {
			int ri = dao.insertMember(dto);
			if(ri == MemberDao.MEMBER_JOIN_SUCCESS) {
				session.setAttribute("id", dto.getId());
%>
			<script language="javascript">
				alert("ȸ�������� ���� �մϴ�.");
				document.location.href="login.jsp";
			</script>
<%
			} else {
%>
			<script language="javascript">
				alert("ȸ�����Կ� �����߽��ϴ�.");
				document.location.href="login.jsp";
			</script>
<%
			}
		}
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=EUC-KR">
<title>Insert title here</title>
</head>
<body>
	
</body>
</html>