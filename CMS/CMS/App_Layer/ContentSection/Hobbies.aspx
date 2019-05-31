<%@ Page Title="" Language="C#" MasterPageFile="~/App_Layer/ContentSection/BaseMaster.Master" AutoEventWireup="true" CodeBehind="Hobbies.aspx.cs" Inherits="CMS.App_Layer.ContentSection.Hobbies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	
   <asp:Repeater ID="HobbiesText" runat="server" EnableViewState="false">
	   <ItemTemplate>

		 <%# Eval("PageText") %>
	   </ItemTemplate>
   </asp:Repeater>
</asp:Content>
