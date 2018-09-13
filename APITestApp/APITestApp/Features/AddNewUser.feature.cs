﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace APITestApp.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AddNewUser")]
    public partial class AddNewUserFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddNewUser.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddNewUser", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new user")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("228", "Alex", "kalyan", "asd", "ads", "asd", "ad", "33263", "-31.8129", "62.5342", "(254)954-1289", "demarco.info", "Keebler LLC", "User-centric fault-tolerant solution", "revolutionize end-to-end systems", null)]
        public virtual void AddNewUser(
                    string id, 
                    string name, 
                    string username, 
                    string email, 
                    string street, 
                    string suite, 
                    string city, 
                    string zipcode, 
                    string lat, 
                    string lng, 
                    string phone, 
                    string website, 
                    string cname, 
                    string catchPhrase, 
                    string bs, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new user", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("I have endpoint /users", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When(string.Format("I call POST method with body {0} and {1} and {2} and {3} and {4} and {5} and {6} " +
                        "and {7} and {8} and {9} and {10} and {11} and {12} and {13} and {14}", id, name, username, email, street, suite, city, zipcode, lat, lng, phone, website, cname, catchPhrase, bs), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("response status is ok and user added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
