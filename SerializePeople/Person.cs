using System;
using System.Runtime.Serialization;

namespace SerializePeople
{
    enum Gender { Male, Female };
    [Serializable()]
    class Person : ISerializable
    {
        private String name;
        private DateTime birthDate;
        private Gender gender;
        private int age;


        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            this.age = CountAge(DateTime.Now, birthDate);
        }
        public Person(SerializationInfo info, StreamingContext ctxt)
        {
            name = (String)info.GetValue("name", typeof(string));
            birthDate = (DateTime)info.GetValue("birthDate", typeof(DateTime));
            gender = (Gender)info.GetValue("gender", typeof(Gender));
            age = (int)info.GetValue("age", typeof(int));
        }

        #region //Getter Setter
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        #endregion

        private int CountAge(DateTime now, DateTime birthDate)
        {
            return DateTime.Today.Year - birthDate.Year;      
        }
        
        public override String ToString()
        {
            return "My name is: "+ name + ", born in: "+ birthDate + ", gender: "+ gender + ", age: " + age;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", name);
            info.AddValue("birthDate", birthDate);
            info.AddValue("gender", gender);
            info.AddValue("age", age);
        }
    }
}
