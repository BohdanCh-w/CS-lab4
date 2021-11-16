﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct
{
    struct UserMock
    {
        private static uint userID;
        private static uint analisID;

        static public List<Doctor> doctorList
        {
            get
            {
                return new List<Doctor>()
                {
                    new Doctor(userID++, "Dick", "Dickenson"),
                    new Doctor(userID++, "Vagina", "Pisku"),
                    new Doctor(userID++, "Cum", "Cummer")
                };
            }
        }

        static public List<Client> clientList
        {
            get
            {
                return new List<Client>()
                {
                    new Client(userID++, "Cam", userID - 4, new PatientData(BLOOD_TYPE.Group_A, "Pizdania", new List<AnalisisResult>()
                    {
                        new AnalisisResult(analisID++, 109.9, "CUMpot", new Dictionary<string, string>()
                        {
                            ["Smegma"] = "Smegma",
                            ["Shit"] = "Good shit"
                        })
                    })),
                    new Client(userID++, "Yuri", userID - 4, new PatientData(BLOOD_TYPE.Group_AB, "Franik", new List<AnalisisResult>()
                    {
                        new AnalisisResult(analisID++, double.MinValue, "Dead man", new Dictionary<string, string>()
                        {
                            ["Alco"] = "drunk",
                            ["String"] = "typo string"
                        })
                    })),
                    new Client(userID++, "CSGO", userID - 4, new PatientData(BLOOD_TYPE.Group_O, "Valve", new List<AnalisisResult>()
                    {
                        new AnalisisResult(analisID++, double.NaN, "Zumori", new Dictionary<string, string>()
                        {
                            ["Milk"] = "Brist milk please",
                            ["Shit"] = "Very good shit"
                        })
                    }))
                };
            }
        }
    }
}