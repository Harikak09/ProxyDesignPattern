/********************************************************************************************
 * 
 * Filename    = Program.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Proxy Design Pattern
 * 
 * Project     = Client
 *
 * Description = Client interacts with proxy service which manages calls to the real service.
 * 
 *********************************************************************************************/
using RealObject;
using ProxyObject;
using System.Diagnostics;

namespace Client
{
    /// <summary>
    /// Takes the console input as user/admin and runs the appropriate operations.
    /// </summary>
    public class Program
    {
        // A reference to the service interface which could be a real service or a proxy.
        private readonly IService _service;
        // A string representing the access level of the user (e.g., "Admin" or "User").
        private readonly string _access;

        /// <summary>
        /// Constructor for the Program class.
        /// Initializes the service and access level.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="access"></param>
        public Program(IService service, string access)
        {
            _service = service;
            _access = access;
        }

        /// <summary>
        /// Executes the operations based on the user's access level.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void Run()
        {
            if (_access == "Admin")
            {
                // If the user is an admin, perform both operations
                _service.Operation1();
                _service.Operation2();
                Trace.TraceInformation("Current accesser is Admin");
            }
            else if (_access == "User")
            {
                // If the user is an user
                _service.Operation1();
                _service.Operation2();
                Trace.TraceInformation("Current accesser is User");
            }
            else
            {
                // If the access level is neither "Admin" nor "User", throw an exception.
                throw new ArgumentException("Enter correct user type!");
                
            }
        }
        static void Main()
        {
            // Prompt the user to enter their access type.
            Console.WriteLine("Enter the type (Admin or User):");
            string? userType = Console.ReadLine();

            // Check if the entered user type is null or empty
            if (string.IsNullOrEmpty(userType))
            {
                Console.WriteLine("User type cannot be empty.");
                return;
            }

            // Declare a variable to hold the service instance
            IService service;
            
            //Determine the type of user and assign the appropriate service implementation
            if (userType == "Admin")
            {
                // If the user is an admin, use either proxy or real service
                service = new ProxyService(userType);
                
            }
            else if (userType == "User")
            {
                // If user is an User use proxy service
                service = new ProxyService(userType);
            }
            else
            {
                // If the entered user type is invalid, display an error message and exit the program
                Console.WriteLine("Invalid user type. Please enter 'Admin' or 'User'.");
                return;
            }
            Console.WriteLine("Service Type: "+ service);
            Console.WriteLine();

            // Create an instance of the Program class with the selected service and user type
            Program program = new (service, userType);

            //Run the program to perform the operations based on the user type
            program.Run();
        }
    }
}
