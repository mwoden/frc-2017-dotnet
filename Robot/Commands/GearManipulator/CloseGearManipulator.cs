using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPILib;
using WPILib.Commands;

namespace Robot.Commands.GearManipulator
{
    public class CloseGearManipulator : InstantCommand
    {
        public CloseGearManipulator() { Requires(Robot.GearManipulator); }
        protected override void Initialize() { Robot.GearManipulator.Close(); }
    }
}
