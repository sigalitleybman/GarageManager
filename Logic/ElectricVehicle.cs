﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class ElectricVehicle : Vehicle
    {
        private readonly float m_MaximumBatteryTimeInHours;
        private float m_BatteryTimeRemainingInHours;
        
        public ElectricVehicle(float i_BatteryTimeRemainingInHours, float i_MaximumBatteryTimeInHours, string i_ModelName, string i_Licensing) : 
                   base(i_ModelName, i_Licensing, ((i_BatteryTimeRemainingInHours / i_MaximumBatteryTimeInHours) * 100))
        {
            m_BatteryTimeRemainingInHours = i_BatteryTimeRemainingInHours;
            m_MaximumBatteryTimeInHours = i_MaximumBatteryTimeInHours;
        }

        ////Properties:
        public float BatteryTimeRemainingInHours
        {
            get
            {
                return m_BatteryTimeRemainingInHours;
            }

            set
            {
                m_BatteryTimeRemainingInHours = value;
            }
        }

        public float MaximumBatteryTimeInHours
        {
            get
            {
                return m_MaximumBatteryTimeInHours;
            }
        }

        public abstract void BatteryCharging(float i_HoursToAdd);
    }
}
