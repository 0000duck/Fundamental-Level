using System.ComponentModel;

namespace _04.StudentClass
{
    public class Student
    {
        public delegate void PropertyChangedEventHandler(object obj, PropertyChangedEventArgs args);
        public event PropertyChangedEventHandler OnPropertyChange;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.IsChanged(this.name, value, "Name");
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                this.IsChanged(this.age, value, "Age");
                this.age = value;
            }
        }

        private void IsChanged(dynamic oldValue, dynamic newValue, string title)
        {
            var onPropCh = this.OnPropertyChange;
            if (onPropCh != null)
            {
                onPropCh(this, new PropertyChangedEventArgs(oldValue, newValue, title));
            }
        }
    }
}