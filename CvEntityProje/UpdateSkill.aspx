﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateSkill.aspx.cs" Inherits="CvEntityProje.UpdateSkill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4>Update skill page</h4>
    <br />
<%--    <asp:Label ID="Label1" runat="server" Text="Skill Explanation"></asp:Label>--%>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="skill" ></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update" CssClass="btn btn-group" OnClick="Button1_Click"/>

</asp:Content>
