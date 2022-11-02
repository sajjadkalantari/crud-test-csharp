﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mc2.CrudTest.IntegrationTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CustomerCrudFeature : object, Xunit.IClassFixture<CustomerCrudFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CustomerCrud.feature"
#line hidden
        
        public CustomerCrudFeature(CustomerCrudFeature.FixtureData fixtureData, Mc2_CrudTest_IntegrationTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CustomerCrud", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Code",
                        "Description"});
            table1.AddRow(new string[] {
                        "101",
                        "invalid mobile number"});
            table1.AddRow(new string[] {
                        "102",
                        "invalid email address"});
            table1.AddRow(new string[] {
                        "103",
                        "Invalid Bank Account Number"});
            table1.AddRow(new string[] {
                        "201",
                        "Duplicate customer by first-name, last-name,Date-of-birth"});
            table1.AddRow(new string[] {
                        "202",
                        "Duplicate Customer by Email address"});
#line 4
 testRunner.Given("system erro codes are following", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create Read Edit Delete Customer")]
        [Xunit.TraitAttribute("FeatureTitle", "CustomerCrud")]
        [Xunit.TraitAttribute("Description", "Create Read Edit Delete Customer")]
        public void CreateReadEditDeleteCustomer()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Read Edit Delete Customer", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID",
                            "Firstname",
                            "Lastname",
                            "Email",
                            "Phonenumber",
                            "DateOfBirth",
                            "BankAccountNumber"});
                table2.AddRow(new string[] {
                            "1",
                            "John",
                            "Doe",
                            "john@doe.com",
                            "+989121234567",
                            "01-JAN-2000",
                            "IR480170000000227662719000"});
#line 14
 testRunner.When("user creates a customer with following data", ((string)(null)), table2, "When ");
#line hidden
#line 17
 testRunner.Then("user can lookup all customers and filter by email of \"john@doe.com\" and get \"1\" r" +
                        "ecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("user edit customer with new email of \"new@gmail.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("user can lookup all customers and filter by email of \"john@doe.com\" and get \"0\" r" +
                        "ecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.And("user can lookup all customers and filter by email of \"new@gmail.com\" and get \"1\" " +
                        "records", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.When("user delete customer by Email of \"new@gmail.com\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("user can lookup all customers and filter by email of \"john@doe.com\" and get \"0\" r" +
                        "ecords", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And("user can lookup all customers and filter by email of \"new@gmail.com\" and get \"0\" " +
                        "records", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CustomerCrudFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CustomerCrudFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
