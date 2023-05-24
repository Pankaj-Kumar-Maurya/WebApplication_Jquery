<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="WebApplication_Jquery.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
               
                 <tr>
                    <th>Name </th>
                    <td><input type="text" id="txtname"/></td>
                </tr>
                 <tr>
                    <th>Address </th>
                    <td><input type="text" id="txtaddress"/></td>
                </tr>
                 <tr>
                    <th>Age </th>
                    <td><input type="text" id="txtage"/></td>
                </tr>
                 <tr>
                    <th></th>
                    <td><input type="button" id="btnsave" value="Save" onclick="Save()"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
