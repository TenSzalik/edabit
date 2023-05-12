//Create a function that takes a number (from 1 - 60) and returns a corresponding string of hyphens.
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1, Result = "-")]
    [TestCase(2, Result = "--")]
    [TestCase(3, Result = "---")]
    [TestCase(4, Result = "----")]
    [TestCase(5, Result = "-----")]
    [TestCase(6, Result = "------")]
    [TestCase(7, Result = "-------")]
    [TestCase(8, Result = "--------")]
    [TestCase(9, Result = "---------")]
    [TestCase(10, Result = "----------")]
    [TestCase(11, Result = "-----------")]
    [TestCase(12, Result = "------------")]
    [TestCase(13, Result = "-------------")]
    [TestCase(14, Result = "--------------")]
    [TestCase(15, Result = "---------------")]
    [TestCase(16, Result = "----------------")]
    [TestCase(17, Result = "-----------------")]
    [TestCase(18, Result = "------------------")]
    [TestCase(19, Result = "-------------------")]
    [TestCase(20, Result = "--------------------")]
    [TestCase(21, Result = "---------------------")]
    [TestCase(22, Result = "----------------------")]
    [TestCase(23, Result = "-----------------------")]
    [TestCase(24, Result = "------------------------")]
    [TestCase(25, Result = "-------------------------")]
    [TestCase(26, Result = "--------------------------")]
    [TestCase(27, Result = "---------------------------")]
    [TestCase(28, Result = "----------------------------")]
    [TestCase(29, Result = "-----------------------------")]
    [TestCase(30, Result = "------------------------------")]
    [TestCase(31, Result = "-------------------------------")]
    [TestCase(32, Result = "--------------------------------")]
    [TestCase(33, Result = "---------------------------------")]
    [TestCase(34, Result = "----------------------------------")]
    [TestCase(35, Result = "-----------------------------------")]
    [TestCase(36, Result = "------------------------------------")]
    [TestCase(37, Result = "-------------------------------------")]
    [TestCase(38, Result = "--------------------------------------")]
    [TestCase(39, Result = "---------------------------------------")]
    [TestCase(40, Result = "----------------------------------------")]
    [TestCase(41, Result = "-----------------------------------------")]
    [TestCase(42, Result = "------------------------------------------")]
    [TestCase(43, Result = "-------------------------------------------")]
    [TestCase(44, Result = "--------------------------------------------")]
    [TestCase(45, Result = "---------------------------------------------")]
    [TestCase(46, Result = "----------------------------------------------")]
    [TestCase(47, Result = "-----------------------------------------------")]
    [TestCase(48, Result = "------------------------------------------------")]
    [TestCase(49, Result = "-------------------------------------------------")]
    [TestCase(50, Result = "--------------------------------------------------")]
    [TestCase(51, Result = "---------------------------------------------------")]
    [TestCase(52, Result = "----------------------------------------------------")]
    [TestCase(53, Result = "-----------------------------------------------------")]
    [TestCase(54, Result = "------------------------------------------------------")]
    [TestCase(55, Result = "-------------------------------------------------------")]
    [TestCase(56, Result = "--------------------------------------------------------")]
    [TestCase(57, Result = "---------------------------------------------------------")]
    [TestCase(58, Result = "----------------------------------------------------------")]
    [TestCase(59, Result = "-----------------------------------------------------------")]
    [TestCase(60, Result = "------------------------------------------------------------")]
    public static string FixedTest(int num)
    {
        return Program.Go(num);
    }
}
using System;

public class Program
{
    public static string Go(int num)
    {

    }
}
