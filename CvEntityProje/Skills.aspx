<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Skills.aspx.cs" Inherits="CvEntityProje.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>SKILLS</th>
            <th>DELETE</th>
            <th>UPDATE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID")  %></td>
                    <td><%# Eval("YETENEK")  %></td>
                    <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "DeleteSkill.Aspx?ID=" + Eval("ID")%>'
                        
                         CssClass="btn btn-danger" >Delete</asp:HyperLink></td>

                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "UpdateSkill.Aspx?ID=" + Eval("ID")%>'
                        
                         CssClass="btn btn-success" >Update</asp:HyperLink></td>

                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="NewSkills.Aspx" class="btn btn-primary" style="margin-left: 20px">New Skill Add</a>
</asp:Content>
