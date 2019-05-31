<%@ Page Title="" Language="C#" MasterPageFile="~/App_Layer/ContentSection/BaseMaster.Master" AutoEventWireup="true" CodeBehind="Downloads.aspx.cs" Inherits="CMS.App_Layer.ContentSection.Downloads" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Repeater ID="DownloadText" runat="server" EnableViewState="false">
       <ItemTemplate>

         <%# Eval("PageText") %>
       </ItemTemplate>
   </asp:Repeater>
</asp:Content>
