namespace exercicio1
{
    public class Student
    {
        public int Nr { get; }
        public string Name { get; }
        public School School { get; }
        public string Nationality { get; }
        
        public Student(int nr, string name, School school, string Nationality){
            this.Nr = nr;
            this.Name = name;
            this.School = school;
            this.Nationality = Nationality;
        }
    }
}