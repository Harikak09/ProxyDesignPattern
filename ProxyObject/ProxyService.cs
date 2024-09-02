/******************************************************************************
 * 
 * Filename    = ProxyService.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Proxy Design Pattern
 * 
 * Project     = ProxyObject
 *
 * Description = Manages access to the real services.
 * 
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealObject;

namespace ProxyObject
{
    /// <summary>
    /// The ProxyService class implements the IService interface and serves as a proxy
    /// to the RealService. It controls access to operations based on the user's role.
    /// </summary>
    public class ProxyService: IService
    {
        private RealService? _realservice;
        private readonly string  _access;
        /// <summary>
        /// Initializes a new instance of the ProxyService class with the specified access level.
        /// </summary>
        /// <param name="access"></param>
        public ProxyService(string access)
        {
            _access = access;   
        }

        /// <summary>
        /// Executes the first operation.
        /// If the real service instance is not yet created, it initializes it.
        /// Then it prints a message and delegates the operation to the real service.
        /// </summary>
        public void Operation1()
        {
            // Check if the real service instance is null
            if (_realservice == null)
            {
                // Instantiate the real service if it hasn't been created yet.
                _realservice = new RealService();

            }
            else
            {

            }
            // Print a message indicating that Operation1 is being executed by the proxy service
            Console.WriteLine("Operation1 executing from proxy Service and calling Operation1 from real service");
            // Delegate the operation to the real service
            _realservice.Operation1();
            Trace.TraceInformation( "Operation1-ProxyService" );
        }


        /// <summary>
        /// Executes the second operation.
        /// Checks the user's access level before delegating to the real service.
        /// If the user is an Admin, it initializes the real service (if needed),
        /// prints a message, and delegates the operation to the real service.
        /// If the user is not an Admin, it prints an access denied message.
        /// </summary>
        public void Operation2()
        {
            // Check if the user's access level is Admin.
            if (_access == "Admin")
            {
                // Check if the real service instance is null
                if (_realservice == null)
                {
                    // Instantiate the real service if it hasn't been created yet
                    _realservice = new RealService();
                }
                else
                {

                }
                // Print a message indicating that Operation2 is being executed by the proxy service
                Console.WriteLine("Operation2 executing from proxy Service and calling Operation2 from real service");
                // Delegate the operation to the real service
                _realservice.Operation2();
                Trace.TraceInformation( "Operation2-ProxyService" );

            }
            else
            {
                //Print an access denied message if the user is not an Admin
                Console.WriteLine("Access denied for Operation2 from Proxy Service for user");
                Trace.TraceInformation("User cannot access");

            }

        }
    }
}
