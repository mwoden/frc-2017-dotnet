using WPILib.Commands;

namespace Robot.Commands.Drive
{
    public sealed class DriveWithJoysticks : Command
    {
        public DriveWithJoysticks() { Requires(Robot.Drive); }
        protected override void Execute() => Robot.Drive.Tank(Robot.oi.LeftY, Robot.oi.RightY);
        protected override bool IsFinished() => false;

        protected override void Initialize() { }
        protected override void End() { }
        protected override void Interrupted() { }
    }
}
