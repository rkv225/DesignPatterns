using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public interface IPizza
    {
        string Prepare();
        string Bake();
        string Cut();
        string Box();
        string Label(string store);
    }
}
