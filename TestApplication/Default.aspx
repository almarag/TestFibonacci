<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    <div class="row">
        <div class="col-md-4">
            Fibonnaci Iterative:
            <asp:Label 
                ID="FibonacciIterative"
                runat="server"
                >
            </asp:Label>
        </div>
        <div class="col-md-4">
            Fibonnaci Recursive:
            <asp:Label 
                ID="FibonacciRecursive"
                runat="server"
                >
            </asp:Label>
        </div>
        <div class="col-md-4">
        </div>
    </div>
</asp:Content>
