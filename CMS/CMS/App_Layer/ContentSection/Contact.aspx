<%@ Page Title="" Language="C#" MasterPageFile="~/App_Layer/ContentSection/BaseMaster.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CMS.App_Layer.ContentSection.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Repeater ID="ContactText" runat="server" EnableViewState="false">
       <ItemTemplate>

         <%# Eval("PageText") %>
       </ItemTemplate>
   </asp:Repeater>
</asp:Content>
