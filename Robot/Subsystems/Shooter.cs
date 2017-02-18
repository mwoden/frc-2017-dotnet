using WPILib;
using WPILib.Commands;

namespace Robot.Subsystems
{
    public class Shooter : Subsystem
    {
        private readonly PWMSpeedController motor = new Spark(RobotMap.Pwm.Shooter);
        protected override void InitDefaultCommand() { }
    }
}
