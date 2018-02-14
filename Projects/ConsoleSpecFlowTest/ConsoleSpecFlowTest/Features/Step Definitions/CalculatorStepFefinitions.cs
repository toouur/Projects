using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
//using ClasssLibrary.Sample;
//using ClasssLibrary.Sample.Fakes;

namespace ConsoleSpecFlowTest.Features.Step_Definitions
{

    [Binding]
    class CalculatorStepFefinitions
    {

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed add button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result ==122)
                Console.WriteLine("The test PASSED");
            else
                Console.WriteLine("The test FAILED");
            throw new Exception("The value is different");
        }

        [When(@"I fill all the mandatory details in the form")]
        public void WhenIFillAllTheMandatoryDetailsInTheForm(Table table)
        {
            var details = table.CreateSet<EmployeeDetails>();

            foreach (EmployeeDetails emp in details)
            {
                Console.WriteLine("The details of an employee :" + emp.Name);
                Console.WriteLine("****************************************");
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
            }
        }



    }
}
