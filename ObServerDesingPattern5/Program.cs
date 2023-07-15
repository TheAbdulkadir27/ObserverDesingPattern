using System;

namespace ObServerDesingPattern5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var datamodel = new DataModel() { Data = ".\\SQLEXPRESS; Initial Catalog=Example; Integrated Security=true" };
            ObServer DataBindingSource1 = new ObServer("DatabindingSource1", datamodel);
            ObServer DataBindingSource2 = new ObServer("DataBindingSource2", datamodel);
            datamodel.PropertyChanged += DataBindingSource1.Update;
            datamodel.PropertyChanged += DataBindingSource2.Update;
            datamodel.Data = ".\\SQLEXPRESS; Initial Catalog=example2; Integrated Security=true";
            Console.ReadKey();
        }
    }
}
