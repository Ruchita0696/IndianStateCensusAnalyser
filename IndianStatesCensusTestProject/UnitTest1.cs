

using IndianStateCensusAnalyser;
using IndianStateCensusAnalyser.DTO;

namespace IndianStatesCensusTestProject
{
 
    public class Tests
    {
        string statecensusFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CsvFiles\CensusData.csv";
        string wrongExtensionFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CSVAdapterFactory.cs";
        string wrongFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CsvFiles\CensusData.csv";
        string wrongheadersFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CsvFiles\WrongHeaders.csv";
        string wrongDelimitersFilepath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CsvFiles\WrongDelimiter.csv";

        string stateCodesFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CsvFiles\StateCodes.csv";
        string stateCodeswrongExtensionFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CSVAdapterFactory.cs";
        string stateCodeswrongFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CensusData.csv";
        string stateCodesWrongHeadersFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CsvFiles\StateCodeWrongHeaders.csv";
        string stateCodesWrongDelimitersFilePath = @"D:\23.Third Party Library\ThirdPartyLibrary\IndianStateCensusAnalyser\CsvFiles\StateCodeWrongDelimiters.csv";

        IndianStateCensusAnalyser.CSVAdapterFactory csvAdapter = default;
        Dictionary<string, CensusDTO> allStateRecords;
        [SetUp]
        public void Setup()
        {
            allStateRecords = new Dictionary<string, CensusDTO>();
            csvAdapter = new IndianStateCensusAnalyser.CSVAdapterFactory();
        }
        /// <summary>
        /// Uc1 - Tc-1.1 - Test for number of records matches
        /// </summary>
        [Test]
        public void TestNumberofRecordMatches()
        {
            allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, statecensusFilePath, "State,Population,Area,Density");
            int expected = 5, actual = allStateRecords.Count;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        ///  Uc1 - Tc-1.2 - Test for Wrong File Extension
        /// </summary>
        [Test]
        public void TestForWrongFileExtension()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, wrongExtensionFilePath, "State,Population,Area,Density");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "Invalid file extension";

                Assert.AreEqual(expected, ex.Message);
            }

        }
        /// <summary>
        /// Uc1 - Tc-1.3 - Test for File not found exception
        /// </summary>
        [Test]
        public void TestForFileNotFound()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, wrongFilePath, "State,Population,Area,Density");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "File not found";

                Assert.AreEqual(ex.Message, expected);
            }

        }
        /// <summary>
        /// Uc1 - Tc-1.4 - Test for wrong headers exception
        /// </summary>
        [Test]
        public void TestForWrongHeaders()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, wrongheadersFilePath, "State,Population,Area,Density");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "Invalid file headers";

                Assert.AreEqual(ex.Message, expected);
            }

        }
        /// <summary>
        /// Uc1 - Tc-1.5 - Test for wrong demlimiters
        /// </summary>
        [Test]
        public void TestForWrongDelimiters()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, wrongDelimitersFilepath, "﻿State,Population,Area,Density");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "Invalid Delimiter";

                Assert.AreEqual(ex.Message, expected);
            }
        }
        //-----------------------------------------UC2-------------------------------------------------------------------
        /// <summary>
        /// Uc2 - Tc-2.1 - Test for number of records matches
        /// </summary>
        [Test]
        public void TestNumberOfStateCodeRecordMatches()
        {
            allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, stateCodesFilePath, "SerialNumber,Tin,StateName,StateCode");
            int expected = 6, actual = allStateRecords.Count;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        ///  Uc2 - Tc-2.2 - Test for Wrong File Extension
        /// </summary>
        [Test]
        public void TestForStateCodeWrongFileExtension()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, stateCodeswrongExtensionFilePath, "SerialNumber,Tin,StateName,StateCode");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "Invalid file extension";

                Assert.AreEqual(ex.Message, expected);
            }

        }
        /// <summary>
        /// Uc2 - Tc-2.3 - Test for File not found exception
        /// </summary>
        [Test]
        public void TestForStateCodeFileNotFound()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, stateCodeswrongFilePath, "SerialNumber,Tin,StateName,StateCode");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "File not found";

                Assert.AreEqual(ex.Message, expected);
            }

        }
        /// <summary>
        /// Uc2 - Tc-2.4 - Test for wrong headers exception
        /// </summary>
        [Test]
        public void TestForStateCodeWrongHeaders()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, stateCodesWrongHeadersFilePath, "SerialNumber,Tin,StateName,StateCode");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "Invalid file headers";

                Assert.AreEqual(ex.Message, expected);
            }

        }
        /// <summary>
        /// Uc2 - Tc-2.5 - Test for wrong demlimiters
        /// </summary>
        [Test]
        public void TestForStateCodeWrongDelimiters()
        {
            try
            {
                allStateRecords = csvAdapter.LoadCsvData(IndianStateCensusAnalyser.CensusAnalyser.Country.INDIA, stateCodesWrongDelimitersFilePath, "SerialNumber,Tin,StateName,StateCode");


            }
            catch (StateCensusAnalyserException ex)
            {
                string expected = "Invalid Delimiter";

                Assert.AreEqual(ex.Message, expected);
            }

        }
    }
}