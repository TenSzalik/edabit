using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests93
    {
        [TestCase(1, "-")]
        [TestCase(2, "--")]
        [TestCase(3, "---")]
        [TestCase(4, "----")]
        [TestCase(5, "-----")]
        [TestCase(6, "------")]
        [TestCase(7, "-------")]
        [TestCase(8, "--------")]
        [TestCase(9, "---------")]
        [TestCase(10, "----------")]
        [TestCase(11, "-----------")]
        [TestCase(12, "------------")]
        [TestCase(13, "-------------")]
        [TestCase(14, "--------------")]
        [TestCase(15, "---------------")]
        [TestCase(16, "----------------")]
        [TestCase(17, "-----------------")]
        [TestCase(18, "------------------")]
        [TestCase(19, "-------------------")]
        [TestCase(20, "--------------------")]
        [TestCase(21, "---------------------")]
        [TestCase(22, "----------------------")]
        [TestCase(23, "-----------------------")]
        [TestCase(24, "------------------------")]
        [TestCase(25, "-------------------------")]
        [TestCase(26, "--------------------------")]
        [TestCase(27, "---------------------------")]
        [TestCase(28, "----------------------------")]
        [TestCase(29, "-----------------------------")]
        [TestCase(30, "------------------------------")]
        [TestCase(31, "-------------------------------")]
        [TestCase(32, "--------------------------------")]
        [TestCase(33, "---------------------------------")]
        [TestCase(34, "----------------------------------")]
        [TestCase(35, "-----------------------------------")]
        [TestCase(36, "------------------------------------")]
        [TestCase(37, "-------------------------------------")]
        [TestCase(38, "--------------------------------------")]
        [TestCase(39, "---------------------------------------")]
        [TestCase(40, "----------------------------------------")]
        [TestCase(41, "-----------------------------------------")]
        [TestCase(42, "------------------------------------------")]
        [TestCase(43, "-------------------------------------------")]
        [TestCase(44, "--------------------------------------------")]
        [TestCase(45, "---------------------------------------------")]
        [TestCase(46, "----------------------------------------------")]
        [TestCase(47, "-----------------------------------------------")]
        [TestCase(48, "------------------------------------------------")]
        [TestCase(49, "-------------------------------------------------")]
        [TestCase(50, "--------------------------------------------------")]
        [TestCase(51, "---------------------------------------------------")]
        [TestCase(52, "----------------------------------------------------")]
        [TestCase(53, "-----------------------------------------------------")]
        [TestCase(54, "------------------------------------------------------")]
        [TestCase(55, "-------------------------------------------------------")]
        [TestCase(56, "--------------------------------------------------------")]
        [TestCase(57, "---------------------------------------------------------")]
        [TestCase(58, "----------------------------------------------------------")]
        [TestCase(59, "-----------------------------------------------------------")]
        [TestCase(60, "------------------------------------------------------------")]
        public void FixedTest(int num, string expectedResult)
        {
            string result = Program93.Go(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}