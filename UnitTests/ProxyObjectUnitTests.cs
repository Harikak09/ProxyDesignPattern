/******************************************************************************
 * 
 * Filename    = ProxyObjectUnitTests.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Proxy Design Pattern
 * 
 * Project     = UnitTests
 *
 * Description = Contains tests for Proxy Object project.
 * 
 *****************************************************************************/

using ProxyObject;
using RealObject;

namespace UnitTests
{
    /// <summary>
    /// Contains unit tests for the ProxyService class in the ProxyObject namespace.
    /// </summary>
    [TestClass]
    public class ProxyObjectUnitTests
    {
        /// <summary>
        /// Test to verify that Operation1 on ProxyService correctly calls the real service's Operation1.
        /// </summary>
        [TestMethod]
        public void Operation1_CallRealService_WhenCalled()
        {
            // Arrange: Create a ProxyService instance with Admin access
            var proxyservice = new ProxyService("Admin");

            // Redirect console output to a string writer for capturing output
            using var sw = new StringWriter();
            Console.SetOut( sw );

            // Act: Call Operation1 on the proxy service
            proxyservice.Operation1();

            // Assert: Verify that the output matches the expected result
            string res = sw.ToString().Trim(); 
            Assert.AreEqual( "Operation1 executing from proxy Service and calling Operation1 from real service\r\nOperation1 from Real Service" , res);

            
        }

        /// <summary>
        /// Test to verify that Operation2 on ProxyService correctly calls the real service's Operation2.
        /// </summary>
        [TestMethod]
        public void Operation2_CallRealService_WhenCalled()
        {   // Arrange: Create a ProxyService instance with Admin access
            var proxyservice = new ProxyService( "Admin" );
            // Redirect console output to a string writer for capturing output
            using var sw = new StringWriter();
            Console.SetOut( sw );
            // Act: Call Operation2 on the proxy service
            proxyservice.Operation2();
            // Assert: Verify that the output matches the expected result
            string res = sw.ToString().Trim();
            Assert.AreEqual( "Operation2 executing from proxy Service and calling Operation2 from real service\r\nOperation2 from Real Service" , res);

            
        }

        /// <summary>
        /// Test to verify that Operation2 on ProxyService does not call the real service's Operation2 if the user is a User.
        /// </summary>
        [TestMethod]
        public void Operation2_DonotCallRealService_WhenCalled()
        {
            // Arrange: Create a ProxyService instance with User access
            var proxyservice = new ProxyService( "User" );
            // Redirect console output to a string writer for capturing output
            using var sw = new StringWriter();
            Console.SetOut( sw );
            // Act: Call Operation2 on the proxy service
            proxyservice.Operation2();
            // Assert: Verify that the output matches the expected result when access is denied
            string res = sw.ToString().Trim();
            Assert.AreEqual( "Access denied for Operation2 from Proxy Service for user" , res );

            
        }
    }
}
