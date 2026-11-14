namespace Chapter_Three

{
    public class EmployeeMO
    {
        public string Name { get; set; }
        public EmployeeMO(string name)
        {
            Name = name;
        }
        public virtual void DisplayRole()
        {
            Console.WriteLine($"{Name} is a general employee");
        }

    }
    public class ManagerMO : EmployeeMO
    {
        public ManagerMO(string name) : base(name) { }

        public override void DisplayRole()
        {
            Console.WriteLine($"{Name} is the manager");
        }


    }

    public class MethodOverriding
    {
        static void Main()
        {
            ManagerMO obj = new ManagerMO("Anushma");
            obj.DisplayRole();
        }
    }
}