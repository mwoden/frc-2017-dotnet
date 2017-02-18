using WPILib;
using WPILib.Commands;

namespace Robot.Subsystems
{
    public class Intake : Subsystem
    {
        private readonly PWMSpeedController intake = new Spark(RobotMap.Pwm.Intake);

        public void On() => intake.Set(.5);
        public void Off() => intake.StopMotor();

        protected override void InitDefaultCommand() { }
    }
}
