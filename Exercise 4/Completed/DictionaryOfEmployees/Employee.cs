namespace DictionaryOfEmployees
{
    public class Employee 
    {
        public int    Id        { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }

        public override string ToString ( )
		{
            return string.Format( "{0}: {1} {2}", Id, FirstName, LastName );
        }
    }
}