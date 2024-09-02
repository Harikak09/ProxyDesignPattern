/******************************************************************************
 * 
 * Filename    = RealObjectUnitTests.cs
 *
 * Author      = Karumudi Harika
 *
 * Product     = Proxy Design Pattern
 * 
 * Project     = UnitTests
 *
 * Description = Contains tests for Real Object project.
 * 
 *****************************************************************************/
using RealObject;

namespace UnitTests
{
    /// <summary>
    /// Contains unit tests for the RealService class in the RealObject namespace.
    /// </summary>
    [TestClass]
    public class RealObjectUnitTests
    {
        /// <summary>
        /// Test to verify that Operation1 on RealService produces the correct output.
        /// </summary>
        [TestMethod]
        public void Operation1_Test()
        {
            // Arrange: Create an instance of RealService
            var realservice = new RealService();

            // Redirect console output to a StringWriter for capturing output
            using var sw = new StringWriter();
            Console.SetOut( sw );
            // Act: Call Operation1 on the RealService instance
            realservice.Operation1();
            // Assert: Verify that the output matches the expected result
            string res = sw.ToString().Trim();
            Assert.AreEqual( "Operation1 from Real Service" , res );
            
        }

        /// <summary>
        /// Test to verify that Operation2 on RealService produces the correct output.
        /// </summary>
        [TestMethod]
        public void Operation2_Test()
        {
            // Arrange: Create an instance of RealService
            var realservice = new RealService();

            // Redirect console output to a StringWriter for capturing output
            using var sw = new StringWriter();
            Console.SetOut( sw );
            // Act: Call Operation2 on the RealService instance
            realservice.Operation2();
            // Assert: Verify that the output matches the expected result
            string res = sw.ToString().Trim();
            Assert.AreEqual( "Operation2 from Real Service" , res );
            
        }
    }
}
