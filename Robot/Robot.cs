using Robot.Subsystems;
using WPILib;
using WPILib.Commands;
using WPILib.LiveWindow;
using WPILib.SmartDashboard;

namespace Robot
{
    /// <summary>
    /// The VM is configured to automatically run this class, and to call the
    /// functions corresponding to each mode, as described in the IterativeRobot
    /// documentation. 
    /// </summary>
    public class Robot : IterativeRobot
    {
        public static Drive Drive { get; } = new Drive();
        public static Climber Climber { get; } = new Climber();
        public static GearManipulator GearManipulator { get; } = new GearManipulator();
        public static Intake Intake { get; } = new Intake();

        public static OI oi;

        Command autonomousCommand;
        SendableChooser chooser;

        public override void RobotInit()
        {
            oi = new OI();

            Robot.GearManipulator.Close();

            chooser = new SendableChooser();
            chooser.AddDefault("Default Auto", new Commands.Autonomous());
            //chooser.AddObject("My Auto", new MyAutoCommand);
            SmartDashboard.PutData("Chooser", chooser);
        }

        public override void AutonomousInit()
        {
            autonomousCommand = (Command)chooser.GetSelected();
            autonomousCommand?.Start();
        }

        public override void TeleopInit() => autonomousCommand?.Cancel();
        public override void AutonomousPeriodic() => Scheduler.Instance.Run();
        public override void TeleopPeriodic() => Scheduler.Instance.Run();
        public override void TestPeriodic() => LiveWindow.Run();

    }
}
