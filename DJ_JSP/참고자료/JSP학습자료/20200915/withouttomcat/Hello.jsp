<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>

    <%

        int i = 0;
        while(true)
        {
            i++;
            out.println("2 * " + i + " = " + (2*i) + "<br/>");
            
    %>
        ========== <br/>
    <%
        if(i>=9)
            break;
        }
        
    %>
</body>

</html>