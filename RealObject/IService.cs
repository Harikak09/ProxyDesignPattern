/******************************************************************************
 * 
 * Filename    = IService.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Proxy Design Pattern
 * 
 * Project     = RealObject
 *
 * Description = Defines the operations that all services must implement.
 * 
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealObject
{ 
    /// <summary>
    /// Any class implementing this interface must provide concrete implementations for these operations.
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Performs the first operation.
        /// </summary>
        public void Operation1();
        

        /// <summary>
        /// Performs the second operation.
        /// </summary>
        public void Operation2();
    }
}
