using konsolowa;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestEncryptStringBasic()
        {
            Assert.IsTrue(Program.encryptString("abc", 3)=="def");
        }
        
        [TestMethod]
        public void TestEncryptStringWrapping()
        {
            Assert.IsTrue(Program.encryptString("xyz", 3)=="abc");
        }
        [TestMethod]
        public void TestEncryptStringUnencrypting()
        {
            Assert.IsTrue(Program.encryptString("def", -3)=="abc");
        }
        [TestMethod]
        public void TestEncryptStringLargeKey()
        {
            Assert.IsTrue(Program.encryptString("abc", 29)=="def");
        }
        [TestMethod]
        public void TestEncryptStringSpace()
        {
            Assert.IsTrue(Program.encryptString("ab cd", 2)=="cd ef");
        }

    }
}
