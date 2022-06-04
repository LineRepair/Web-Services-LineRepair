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
namespace web_services_ielectric.Tests.Report
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ReportServiceTestsFeature : object, Xunit.IClassFixture<ReportServiceTestsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ReportServiceTests.feature"
#line hidden
        
        public ReportServiceTestsFeature(ReportServiceTestsFeature.FixtureData fixtureData, web_services_ielectric_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Report", "ReportServiceTests", "\tAs a Developer\r\n\tI want to add new Report through the API\r\n\tSo that it becomes a" +
                    "vailable for applications", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
     testRunner.Given("the Endpoint https://localhost:44346/api/v1/reports is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Names",
                        "LastNames",
                        "CellphoneNumber",
                        "Address",
                        "Email",
                        "Password"});
            table10.AddRow(new string[] {
                        "Pedro",
                        "Jimenez",
                        "978675641",
                        "San Isidro",
                        "pedro@gmail.com",
                        "Pedro12345"});
#line 8
     testRunner.And("A Technician is already stored", ((string)(null)), table10, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Select Appointment")]
        [Xunit.TraitAttribute("FeatureTitle", "ReportServiceTests")]
        [Xunit.TraitAttribute("Description", "Select Appointment")]
        [Xunit.TraitAttribute("Category", "technician.selectAppointment")]
        public virtual void SelectAppointment()
        {
            string[] tagsOfScenario = new string[] {
                    "technician.selectAppointment"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select Appointment", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Names",
                            "LastNames",
                            "CellphoneNumber",
                            "Address",
                            "Email",
                            "Password"});
                table11.AddRow(new string[] {
                            "Pedro",
                            "Jimenez",
                            "978675641",
                            "San Isidro",
                            "pedro@gmail.com",
                            "Pedro12345"});
#line 14
    testRunner.When("A Technician Request is create to Report", ((string)(null)), table11, "When ");
#line hidden
#line 17
    testRunner.Then("A Response with Status 200 is received in Appointment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateReserve",
                            "DateAttention",
                            "Hour",
                            "Done",
                            "ClientId",
                            "TechnicianId"});
                table12.AddRow(new string[] {
                            "1/06/2022",
                            "4/06/2022",
                            "15:00",
                            "true",
                            "1",
                            "2"});
#line 18
    testRunner.And("Appointment Resource is included in Response Body", ((string)(null)), table12, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Select Appointment unfinished")]
        [Xunit.TraitAttribute("FeatureTitle", "ReportServiceTests")]
        [Xunit.TraitAttribute("Description", "Select Appointment unfinished")]
        [Xunit.TraitAttribute("Category", "technician.selectAppointment")]
        public virtual void SelectAppointmentUnfinished()
        {
            string[] tagsOfScenario = new string[] {
                    "technician.selectAppointment"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select Appointment unfinished", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "Names",
                            "LastNames",
                            "CellphoneNumber",
                            "Address",
                            "Email",
                            "Password"});
                table13.AddRow(new string[] {
                            "Pedro",
                            "Jimenez",
                            "978675641",
                            "San Isidro",
                            "pedro@gmail.com",
                            "Pedro12345"});
#line 24
    testRunner.When("A Technician Request is create to Report", ((string)(null)), table13, "When ");
#line hidden
#line 27
    testRunner.Then("A Response with Status 200 is received in Appointment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "DateReserve",
                            "DateAttention",
                            "Hour",
                            "Done",
                            "ClientId",
                            "TechnicianId"});
                table14.AddRow(new string[] {
                            "1/06/2022",
                            "4/06/2022",
                            "15:00",
                            "false",
                            "1",
                            "2"});
#line 28
    testRunner.And("Appointment Resource is included in Response Body", ((string)(null)), table14, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Report")]
        [Xunit.TraitAttribute("FeatureTitle", "ReportServiceTests")]
        [Xunit.TraitAttribute("Description", "Add Report")]
        [Xunit.TraitAttribute("Category", "report.adding")]
        public virtual void AddReport()
        {
            string[] tagsOfScenario = new string[] {
                    "report.adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Report", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Observation",
                            "Diagnosis",
                            "RepairDescription",
                            "ImagePath",
                            "Date",
                            "TechnicianId",
                            "AppointmentId"});
                table15.AddRow(new string[] {
                            "The microwave smell bad",
                            "A component is burned",
                            "I replaced the microchip successfully",
                            "https://google.com/images",
                            "10-12-24",
                            "2",
                            "1"});
#line 34
 testRunner.When("A Post Request is sent to Report", ((string)(null)), table15, "When ");
#line hidden
#line 37
 testRunner.Then("A Response with Status 200 is received in Report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "Observation",
                            "Diagnosis",
                            "RepairDescription",
                            "ImagePath",
                            "Date",
                            "TechnicianId",
                            "AppointmentId"});
                table16.AddRow(new string[] {
                            "The microwave smell bad",
                            "A component is burned",
                            "I replaced the microchip successfully",
                            "https://google.com/images",
                            "10-12-24",
                            "2",
                            "1"});
#line 38
 testRunner.And("A Report Resource is included in Response Body", ((string)(null)), table16, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Report with Invalid Technician")]
        [Xunit.TraitAttribute("FeatureTitle", "ReportServiceTests")]
        [Xunit.TraitAttribute("Description", "Add Report with Invalid Technician")]
        [Xunit.TraitAttribute("Category", "report-adding-Invalid")]
        public virtual void AddReportWithInvalidTechnician()
        {
            string[] tagsOfScenario = new string[] {
                    "report-adding-Invalid"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Report with Invalid Technician", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "Observation",
                            "Diagnosis",
                            "RepairDescription",
                            "ImagePath",
                            "Date",
                            "TechnicianId",
                            "AppointmentId"});
                table17.AddRow(new string[] {
                            "The microwave smell bad",
                            "A component is burned",
                            "I replaced the microchip successfully",
                            "https://google.com/images",
                            "10-12-24",
                            "-2",
                            "1"});
#line 44
 testRunner.When("A Post Request is sent to Report", ((string)(null)), table17, "When ");
#line hidden
#line 47
    testRunner.Then("A Response with Status 400 is received in Report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
    testRunner.And("A message of \"Invalid Technician\" is included in Response Body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                ReportServiceTestsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ReportServiceTestsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
