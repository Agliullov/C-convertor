using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace UnitTestProject1.Controllers
{
    [TestClass]
    class ValueControllerTest
    {
        [TestMethod]
        public void CalcVal_magnitydezero_shouldbezero()
        {
            //arguments
            ValueController Val = new ValueController();
            Value qwe = Value.Foot;
            Value wer = Value.Metr;
            double vars = 0;
            //call
            double result = Val.CalcVal(qwe, wer, vars);
            //Expect
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void CalcVal_magnitydezero_shouldbenegative()
        {
            //arguments
            ValueController Val = new ValueController();
            Value qwe = Value.Foot;
            Value wer = Value.Metr;
            double vars = 0;
            //call
            double result = Val.CalcVal(qwe, wer, vars);
            //Expect
            Assert.AreEqual(-1, result);
        }
     }
}
