﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using COMP229_F2016_MidTerm_300742916;
using System.Web.ModelBinding;
using COMP229_F2016_MidTerm_300742916.Models;

namespace COMP229_F2016_MidTerm_300742916
{
    public partial class TodoDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
               
            }

        }

        
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to the students page
            Response.Redirect("/TodoList.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {

            // Use EF to conect to the server
            using (TodoContext db = new TodoContext())
            {

                // save a new record

                Todo newlist = new Todo();

                int TodoID = 0;

                if (Request.QueryString.Count > 0) // our URL has a TodoID in it
                {
                    // get the id from the URL
                }

                // add form data to the new student record
                newlist.ToDoDescription = TodoNameTextBox.Text;
                newlist.ToDoNotes = TodoNotesTextBox.Text;


                // use LINQ to ADO.NET to add / insert new student into the db

                if (TodoID == 0)
                {

                    db.Todos.Add(new Todo());

                }

                // save our changes - also updates and inserts
                   db.SaveChanges();
                // Redirect back to the updated students page
                Response.Redirect("/TodoList.aspx");
                    }

            }
        }
    }
