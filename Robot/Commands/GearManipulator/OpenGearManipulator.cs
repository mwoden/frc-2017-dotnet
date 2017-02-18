using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPILib;
using WPILib.Commands;

namespace Robot.Commands.GearManipulator
{
    public class OpenGearManipulator : InstantCommand
    {
        public OpenGearManipulator() { Requires(Robot.GearManipulator); }
        protected override void Initialize() { Robot.GearManipulator.Open(); }
    }
}
