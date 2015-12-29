namespace WebPage.Views.Student
{
    using System;
    using Core.Interfaces.Generic;
    using ViewModels;

    public class Edit : IRenderable<StudentViewModel>
    {
        public void Render()
        {
            Console.WriteLine("<h1>AZ SAM EDIT VIEW NA STUDENT<h1/><br/>");
            Console.WriteLine("<h2><u><font color='red'>MOQ FULL NAME E " + Model.FullName + "</font></u></h2>");
        }

        public StudentViewModel Model { get; set; }
       
    }
}
