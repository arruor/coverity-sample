using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public interface IBase
    {

    }

    public abstract class BaseClass : IBase
    {
    }

    public class ChildClass : BaseClass
    {

    }

    public class GrandChildClass : ChildClass
    {

    }
}
