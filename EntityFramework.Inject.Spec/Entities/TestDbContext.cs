using System.Data.Entity;
using System.Diagnostics;

namespace EntityFramework.Inject.Spec.Entities
{
	public class TestDbContext : DbContext
	{
	    public object SomeOtherParameter { get; private set; }

	    public TestDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
		{
		}

	    public TestDbContext(string nameOrConnectionString, object someOtherParameter) : base(nameOrConnectionString)
	    {
	        SomeOtherParameter = someOtherParameter;
	    }
	}
}