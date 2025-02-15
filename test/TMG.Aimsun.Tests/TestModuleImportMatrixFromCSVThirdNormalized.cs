﻿/*
    Copyright 2021 Travel Modelling Group, Department of Civil Engineering, University of Toronto

    This file is part of XTMF.

    XTMF is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    XTMF is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with XTMF.  If not, see <http://www.gnu.org/licenses/>.
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace TMG.Aimsun.Tests
{
    [TestClass]
    public class TestModuleImportMatrixFromCSVThirdNormalized
    {
        [TestMethod]
        public void TestImportMatrixFromCSVThirdNormalizedTestOD()
        {
            //change the network
            string newNetwork = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\FrabitztownNetworkWithTransitSchedule.ang");
            Helper.Modeller.SwitchModel(null, newNetwork);
            string modulePath = Path.Combine(Helper.TestConfiguration.ModulePath, "inputOutput\\importMatrixFromCSVThirdNormalized.py");
            string jsonParameters = JsonConvert.SerializeObject(new
            {
                OutputNetworkFile = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\output\\FrabitztownNetworkWithOd.ang"),
                ModelDirectory = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\Frabitztown"),
                ToolboxInputOutputPath = Path.Combine(Helper.TestConfiguration.NetworkFolder, "src\\TMGToolbox\\inputOutput"),
                MatrixCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownMatrixList.csv"),
                ODCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownOd.csv"),
                ThirdNormalized = true,
                IncludesHeader = true,
                MatrixID = "testOD",
                CentroidConfiguration = "baseCentroidConfig",
                VehicleType = "Car Class ",
                InitialTime = "06:00:00:000",
                DurationTime = "03:00:00:000"
            });
            Helper.Modeller.Run(null, modulePath, jsonParameters);
        }

        [TestMethod]
        public void TestImportMatrixFromCSVThirdNormalizedTransitOD()
        {
            // This unit test is used to test when transitOD is passed
            // change the network
            string newNetwork = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\FrabitztownNetworkWithOd.ang");
            Helper.Modeller.SwitchModel(null, newNetwork);
            string modulePath = Path.Combine(Helper.TestConfiguration.ModulePath, "inputOutput\\importMatrixFromCSVThirdNormalized.py");
            string jsonParameters = JsonConvert.SerializeObject(new
            {
                OutputNetworkFile = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\output\\FrabitztownNetworkWithOd2.ang"),
                ModelDirectory = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\Frabitztown"),
                ToolboxInputOutputPath = Path.Combine(Helper.TestConfiguration.NetworkFolder, "src\\TMGToolbox\\inputOutput"),
                MatrixCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownMatrixList.csv"),
                ODCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownOd2.csv"),
                ThirdNormalized = true,
                IncludesHeader = true,
                MatrixID = "testOD",
                CentroidConfiguration = "baseCentroidConfig",
                VehicleType = "Car Class ",
                InitialTime = "06:00:00:000",
                DurationTime = "03:00:00:000"
            });
            Helper.Modeller.Run(null, modulePath, jsonParameters);
        }

        [TestMethod]
        public void TestSaveImportMatrixFromCSVThirdNormalizedTestOD()
        {
            //change the network
            string newNetwork = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\FrabitztownNetworkWithTransitSchedule.ang");
            Helper.Modeller.SwitchModel(null, newNetwork);
            string modulePath = Path.Combine(Helper.TestConfiguration.ModulePath, "inputOutput\\importMatrixFromCSVThirdNormalized.py");
            string jsonParameters = JsonConvert.SerializeObject(new
            {
                OutputNetworkFile = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\output\\FrabitztownNetworkWithOd.ang"),
                ModelDirectory = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\Frabitztown"),
                ToolboxInputOutputPath = Path.Combine(Helper.TestConfiguration.NetworkFolder, "src\\TMGToolbox\\inputOutput"),
                MatrixCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownMatrixList.csv"),
                ODCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownOd.csv"),
                ThirdNormalized = true,
                IncludesHeader = true,
                MatrixID = "testOD",
                CentroidConfiguration = "baseCentroidConfig",
                VehicleType = "Car Class ",
                InitialTime = "06:00:00:000",
                DurationTime = "03:00:00:000"
            });
            Helper.Modeller.Run(null, modulePath, jsonParameters);
            //build an output file location of where to save the file
            string outputPath = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\test3\\FrabitztownNetworkWithOd.ang");
            Helper.Modeller.SaveNetworkModel(null, outputPath);
        }

        [TestMethod]
        public void TestSaveImportMatrixFromCSVThirdNormalizedTransitOD()
        {
            // This unit test is used to test when transitOD is passed
            // change the network
            string newNetwork = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\FrabitztownNetworkWithOd.ang");
            Helper.Modeller.SwitchModel(null, newNetwork);
            string modulePath = Path.Combine(Helper.TestConfiguration.ModulePath, "inputOutput\\importMatrixFromCSVThirdNormalized.py");
            string jsonParameters = JsonConvert.SerializeObject(new
            {
                OutputNetworkFile = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\output\\FrabitztownNetworkWithOd2.ang"),
                ModelDirectory = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\Frabitztown"),
                ToolboxInputOutputPath = Path.Combine(Helper.TestConfiguration.NetworkFolder, "src\\TMGToolbox\\inputOutput"),
                MatrixCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownMatrixList.csv"),
                ODCSV = Path.Combine(Helper.TestConfiguration.NetworkFolder, "inputFiles\\frabitztownOd2.csv"),
                ThirdNormalized = true,
                IncludesHeader = true,
                MatrixID = "testOD",
                CentroidConfiguration = "baseCentroidConfig",
                VehicleType = "Car Class ",
                InitialTime = "06:00:00:000",
                DurationTime = "03:00:00:000"
            });
            Helper.Modeller.Run(null, modulePath, jsonParameters);
            //build an output file location of where to save the file
            string outputPath = Path.Combine(Helper.TestConfiguration.NetworkFolder, "aimsunFiles\\test3\\FrabitztownNetworkWithOd2.ang");
            Helper.Modeller.SaveNetworkModel(null, outputPath);
        }
    }
}
