using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLog.ApplicationLogic;
using StructureMap;
using UTLog.IoC;

namespace UTLog
{
    [TestClass]
    public class UnitTest1
    {
        //interessante! approfondisci
        private readonly IContainer container = Container.For<InverseofControl>();

        #region TEST TRACE
        [TestMethod]
        public void TestMethodTRACE() //1
        {
            var log = container.GetInstance<ILogWrite>();
            Assert.IsTrue(log.TRACE("Test DTOBOUND"));
        }
        #endregion

        #region TEST DEBUG
        [TestMethod]
        public void TestMethodTRACEDebug() //2
        {
            var log = container.GetInstance<ILogWrite>();
            Assert.IsTrue(log.TRACEDEBUG("Test DTOBOUND - Debug"));
        }
        #endregion

        #region TEST INFORMATION
        [TestMethod]
        public void TestMethodTRACEInformation() //3 - todo
        {
            var log = container.GetInstance<ILogWrite>();
            Assert.IsTrue(log.TRACEINFORMATION("Test DTOBOUND - Information"));
        }
        #endregion
        
        #region TEST WARNING
        [TestMethod]
        public void TestMethodTRACEWarning() //4
        {
            var log = container.GetInstance<ILogWrite>();
            Assert.IsTrue(log.TRACEWARNING("Test DTOBOUND - Warning"));
        }
        #endregion

        #region TEST ERROR
        [TestMethod]
        public void TestMethodTRACEError() //5
        {
            try
            {
                throw new Exception("vercingetorige uccise giulio cesare");
            }
            catch (Exception ERROREDIPROVA)
            {

                var log = container.GetInstance<ILogWrite>();
                Assert.IsTrue(log.TRACEERROR(ERROREDIPROVA));
            }
            
            
        }
        #endregion

        #region TEST CRITICAL
        [TestMethod]
        public void TestMethodTRACECritical() //6 - todo
        {
            var log = container.GetInstance<ILogWrite>();
            Assert.IsTrue(log.TRACECRITICAL("Test DTOBOUND - Critical"));
        }
        #endregion
    }
}
