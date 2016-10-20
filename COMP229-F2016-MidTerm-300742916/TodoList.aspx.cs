using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//required using statements
using System.Web.ModelBinding;
using COMP229_F2016_MidTerm_300742916.Models;

namespace COMP229_F2016_MidTerm_300742916
{
    public partial class TodoList : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                this.getTodoList();

            }

        }
        private void getTodoList()
        {
            using (TodoContext db = new TodoContext())
            {
                var TodoData = (from toDo in db.Todos
                                select toDo);
                ToDoGridView.DataSource = TodoData.ToList();
                ToDoGridView.DataBind();
            }
        }

        protected void ToDoGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            // store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected StudentID using the Grid's DataKey collection
            int TodoID = Convert.ToInt32(ToDoGridView.DataKeys[selectedRow].Values["TodoID"]);

            // use EF and LINQ to find the selected student in the DB and remove it
            using (TodoContext db = new TodoContext())
            {
                // create object ot the student clas and store the query inside of it
                Todo deletedStudent = (from TodoRecords in db.Todos
                                       where TodoRecords.TodoID == TodoID
                                       select TodoRecords).FirstOrDefault();

                // remove the selected student from the db
                db.Todos.Remove(deletedStudent);

                // save my changes back to the db
                db.SaveChanges();

                // refresh the grid
                this.getTodoList();
            }

        }
    }
}