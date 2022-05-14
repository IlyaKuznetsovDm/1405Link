


var people = new List<Person>()
{
    new Person("Tom",23,"Samsung",new List<string>{"english","germany" }),
    new Person( "Bob",27,"Samsung",new List<string>{"english","franch" }),
    new Person("Sam",26,"Samsung",new List<string>{"english","spanish" }),
    new Person("Alice",24,"Samsung",new List<string>{"english","italy" })
};

var result = from p in people
             from l in p.Languages
             where p.Age>25
             where l.Equals("spanish")
             orderby p.Name
             select p;
var result1 = people.SelectMany(u => u.Languages, (u, l) => 
new { Person = u, Lang = l }).
    Where(u =>u.Lang.Equals("italy") && u.Person.Age < 25).
    Select(u => u.Person);
  
foreach (var item in result1)
{
    Console.WriteLine(item.ToString());
}
class Person
{
  
    public Person(string name, int age, string company List<string> language)
    {
        Name = name;
        Age = age;
        Languages = language;
        Company =  company;
        
    }

    public string Name { get; set; }
    public int Age { get; set; }
    
    public List<string> Languages { get; set; }

    public string Company { get; set; }
    
}



