using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPILib;
using WPILib.Commands;

namespace Robot.Subsystems
{
    public sealed class Climber : Subsystem
    {
        private readonly PWMSpeedController motor = new VictorSP(RobotMap.Pwm.Climber);

        public Climber() { motor.Inverted = true; }

        public void Climb() => motor.Set(.8);
        public void Stop() => motor.StopMotor();

        protected override void InitDefaultCommand() { }
    }
}
