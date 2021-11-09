<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CvEntityProje.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>NAME </th>
            <th>EMAIL</th>
            <th>SUBJECT</th>
            <th>SHOW MESSAGE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID")%></td>
                    <td><%# Eval("ADSOYAD")%></td>
                     <td><%# Eval("MAIL")%></td>
                     <td><%# Eval("KONU")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "MessageDetail.Aspx?ID=" + Eval("ID")%>'
                        
                         CssClass="btn btn-warning" >Show Message</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "DeleteMessage.Aspx?ID=" + Eval("ID")%>'
                        
                         CssClass="btn btn-danger" style="margin-left: 30px">Delete Message</asp:HyperLink>
                    </td>
                    
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>



</asp:Content>
