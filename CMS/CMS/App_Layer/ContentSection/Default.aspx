<%@ Page Title="" Language="C#" MasterPageFile="~/App_Layer/ContentSection/BaseMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CMS.App_Layer.ContentSection.Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Repeater ID="DefaultText" runat="server" EnableViewState="false">
       <ItemTemplate>

         <%# Eval("PageText") %>
       </ItemTemplate>
   </asp:Repeater>
</asp:Content>
