
	<%! 
		int i = 10;
    	String str = "ABCD";
    %>
   
   <%!
   		public int sum(int a, int b)
   		{
	   		return i+a+b;
   		}
   %>
   
   
   <%
   		out.println("i = " + i + "<br/>");
		out.println("str = " + str + "<br/>");
		out.println("str = " + sum(1,5) + "<br/>");
   
   %>
   
   <%= i %><br/>
   <%= str %><br/>
   <%=sum(1,2) %>
