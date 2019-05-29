<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminChangeMaster.aspx.cs" Inherits="CMS.App_Layer.AdminSection.AdminChangeMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>

        <div style="width:100%;">
            <table style="width:50%;height:200px;text-align:left;">
                <tr>
                    <td style="width:30%;">Header Image:</td>
                    <td style="width:70%;text-align:center;">
                        <asp:FileUpload ID="FileUpload_HIMG" runat="server" style="width:90%;border-radius:4px;"/>
                    </td>
                </tr>
                <tr>
                    <td style="width:30%;">Header Text:</td>
                    <td style="width:70%;text-align:center;">
                        <asp:TextBox ID="txt_HeaderText" runat="server" style="width:90%;border-radius:4px;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center;">
                        <asp:Button ID="Button1" runat="server" Text="Save" Width="140px" style="background-color:#6bc5d0;color:white;" OnClick="Button1_Click"/>
                    </td>
                </tr>
            </table>
        </div>
            <div>
                <a href="../ContentSection/Default.aspx">Back to WebSite</a>
            </div>
        </center>
    </form>
</body>
</html>
