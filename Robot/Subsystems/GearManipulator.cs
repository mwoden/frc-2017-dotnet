using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPILib;
using WPILib.Commands;

namespace Robot.Subsystems
{
    public sealed class GearManipulator : Subsystem
    {
        DoubleSolenoid manipulatorSolenoid = new DoubleSolenoid(RobotMap.Solenoid.GearManipulatorForward, RobotMap.Solenoid.GearManipulatorReverse);

        public void Open() => manipulatorSolenoid.Set(DoubleSolenoid.Value.Forward);
        public void Close() => manipulatorSolenoid.Set(DoubleSolenoid.Value.Reverse);
        public bool IsOpen => manipulatorSolenoid.Get() == DoubleSolenoid.Value.Forward;

        protected override void InitDefaultCommand() { }
    }
}
