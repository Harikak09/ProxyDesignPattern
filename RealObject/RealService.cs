/******************************************************************************
 * 
 * Filename    = RealService.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Proxy Design Pattern
 * 
 * Project     = RealObject
 *
 * Description = Contains the operations that a real subject can perform.
 * 
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealObject
{
    /// <summary>
    /// Contains multiple operations that a real object can perform/execute.
    /// Implements the IServcie interface.
    /// </summary>
    public class RealService: IService
    {
        /// <summary>
        /// Executes first operation.
        /// </summary>
        /// 
        
        public void Operation1()
        { 
            //Perform first operation and print message to console.
            Console.WriteLine("Operation1 from Real Service");
            Trace.TraceInformation("Operation1-RealService");

        }

        public void Operation2()
        {
            //Perform second operation and print message to console.
            Console.WriteLine("Operation2 from Real Service");
            Trace.TraceInformation( "Operation2-RealService" );

        }
    }
}
