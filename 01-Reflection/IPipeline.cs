using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Reflection
{
    public interface IPipeline<TInput,TOutput> 
        where TInput : BaseRequest
        where TOutput : IDisposable, new()
    {
        TOutput EjecutarTarea(TInput request);

    }
}
