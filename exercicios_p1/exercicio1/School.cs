
namespace exercicio1
{
    public class School
    {
        public string Name { get; }
        public string Location { get; }
    
        public School (string name, string Location){
            this.Name = name;
            this.Location = Location;
        }

        public override bool Equals(object obj)
        {
            /* iguais se Name e Location iguais */
            School o = obj as School;
            if (o is null)
                return false;
            return o.Location == Location && o.Name == Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Location.GetHashCode();
        }
    }
}