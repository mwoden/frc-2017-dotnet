using WPILib.Commands;

namespace Robot.Commands.Intake
{
    public class RunIntake : Command
    {
        public RunIntake() { Requires(Robot.Intake); }

        protected override void Initialize() => Robot.Intake.On();
        protected override bool IsFinished() => false;
        protected override void Interrupted() => Robot.Intake.Off();
    }
}
