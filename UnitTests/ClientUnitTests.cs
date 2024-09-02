/******************************************************************************
 * 
 * Filename    = ClientUnitTests.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Proxy Design Pattern
 * 
 * Project     = UnitTests
 *
 * Description = Contains tests for Client project.
 * 
 *****************************************************************************/

using Client;
using RealObject;
using ProxyObject;

namespace UnitTests
{
    /// <summary>
    /// Test to verify that both operations are called when the user is an Admin.
    /// </summary>
    [TestClass]
    public class ClientUnitTests
    {
        [TestMethod]
        public void Run_BothOperations_Admin()
        {
            var service = new ProxyService( "Admin" );
            var program = new Program( service , "Admin" );

            // Redirect console output to a string writer for capturing output
            using var sw = new StringWriter();
            Console.SetOut( sw );

            //Run the program
            program.Run();
            // Get the console output and trim any extra spaces
            string result = sw.ToString().Trim();
            // Assert that the correct output is produced for Admin
            Assert.AreEqual( "Operation1 executing from proxy Service and calling Operation1 from real service\r\nOperation1 from Real Service\r\nOperation2 executing from proxy Service and calling Operation2 from real service\r\nOperation2 from Real Service" , result );   
        }

        /// <summary>
        /// Test to verify that only Operation1 is called and Operation2 is denied when the user is a User.
        /// </summary>
        [TestMethod]
        public void Run_OneOperations_User()
        {
            var service = new ProxyService( "User" );
            var program = new Program( service , "User" );

            // Redirect console output to a string writer for capturing output
            using var sw = new StringWriter();
            Console.SetOut( sw );
            //Run the program
            program.Run();
            // Get the console output and trim any extra spaces
            string result = sw.ToString().Trim();
            // Assert that the correct output is produced for User
            Assert.AreEqual( "Operation1 executing from proxy Service and calling Operation1 from real service\r\nOperation1 from Real Service\r\nAccess denied for Operation2 from Proxy Service for user" , result );
            
        }

        /// <summary>
        /// Test to verify that an ArgumentException is thrown for an invalid access type.
        /// </summary>
        [TestMethod]
        public void Error_InvalidAccess()
        {
            var service = new ProxyService( "Invalid" );
            var program = new Program( service , "Invalid" );
            // Assert that an ArgumentException is thrown when an invalid access type is used
            Assert.ThrowsException<ArgumentException>(program.Run);

        }
    }
}
