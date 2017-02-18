using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPILib;
using WPILib.Commands;

namespace Robot.Commands.GearManipulator
{
    public class ToggleGearManipulator : ConditionalCommand
    {
        public ToggleGearManipulator()
              : base(new CloseGearManipulator(), new OpenGearManipulator())
        { }

        protected override bool Condition() => Robot.GearManipulator.IsOpen;
    }
}
