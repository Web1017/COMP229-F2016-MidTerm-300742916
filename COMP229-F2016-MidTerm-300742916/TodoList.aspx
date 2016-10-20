<%@ Page Title="Todo List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TodoList.aspx.cs" Inherits="COMP229_F2016_MidTerm_300742916.TodoList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!--Javid Niftaliyev: 300742916-->
<!--GitHub: comp229-midterm.azurewebsites.net/ -->
<!--Azure: comp229-gametracker-part2.azurewebsites.net/Default.aspx  -->

     <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">

    <div class="TodoContent">
        <asp:GridView ID="ToDoGridView" runat="server" AutoGenerateColumns="false"
            CssClass="ToDoGridView" DataKeyNames="TodoID"
            Visible="true"
            HeaderStyle-CssClass="CS_GRID_HEADER" OnRowDeleting="ToDoGridView_RowDeleting">
            <Columns>
                <asp:BoundField DataField="TodoID" HeaderText="Todo" Visible="true" ItemStyle-CssClass="TodoID" />
                <asp:BoundField DataField="ToDoNotes" HeaderText="Notes" Visible="true" ItemStyle-CssClass="ToDoNotes" />
                <asp:BoundField DataField="ToDoDescription" HeaderText="Description" Visible="true" ItemStyle-CssClass="ToDoDescription" />
                <asp:BoundField DataField="Completed" HeaderText="Completed" Visible="true" ItemStyle-CssClass="Completed" />

               <asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Edit"
                            NavigateUrl="~/TodoDetails.aspx.cs" ControlStyle-CssClass="btn btn-primary btn-sm"
                            runat="server" DataNavigateUrlFields="TodoID"
                            DataNavigateUrlFormatString="TodoDetails.aspx?TodoID={0}" />

                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
              
            </Columns>
        </asp:GridView>
                </div>
            </div>
        </div>
    </div>

     
</asp:Content>
