using 
    System
    ;

namespace 
    Student

    {public class Student{private 
        
        string facultyNumber;

        public Student(
            string firstName
            , string
            lastName
            , string facultyNumber
            ) : base(
                firstName, 
                lastName){
            this
                .
                FacultyNumber 
                               = facultyNumber;}

        public string 
        
        FacultyNumber{get { return this.facultyNumber; }
            set
            { if (string.IsNullOrEmpty(value)){throw new ArgumentNullException("Faculty number cannot be empty");}

                this
                    .facultyNumber 
                    = 
                    value
                    ;}}

        public override string ToString(){return base.
                ToString() 
                + "Faculty Number : " + 
                this.
                facultyNumber +
                Environment.
                NewLine;}}}