<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TCTransferHistory.aspx.vb" Inherits="RF_Check_WIP.TCTransferHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>History Transfer</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
<%--  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>--%>
    <link href="scripts/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/jquery.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
            <h2>Transfer History</h2>
          <table class="table table-bordered">
            <thead>
              <tr class="info">
                  <th>Number</th>
                <th>LotNo</th>
                <th>CartNo</th>
                <th>Input</th>
                <th>Output</th>
              </tr>
            </thead>
            <%
                Dim count As Integer = 0
                Dim countNumber As Integer = 1
                For Each Data As RF_Check_WIP.TransferData In c_TCTransfer
                    %>
            <tbody>
              <tr class="<%=c_ColorList(count)%>">
                     <td><%=countNumber %></td>
                <td><%=Data.LotNo %></td>
                <td><%=Data.CartNo %></td>
                <td><%=Data.LotStartTime %></td>
                  <td><%=Data.LotEndTime %></td>
              </tr>
     
            </tbody>
       
           <%
                    count += 1
                    countNumber += 1
                    If count >= 2 Then
                        count = 0
                    End If
                Next %>
              
          </table>
     
        </div>
    </form>
</body>
</html>
