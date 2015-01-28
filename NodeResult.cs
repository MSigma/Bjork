using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bjork
{
    /// <summary>
    /// Success: The execution has finished successfully
    /// Running: The execution started a process that is currently running and will not finish this tick
    /// Failure: The execution has finished unsuccessfully
    /// </summary>
    public enum NodeResult
    {
        Success,
        Running,
        Failure,
    }
}
