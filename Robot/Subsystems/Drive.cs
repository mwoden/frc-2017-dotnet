using CTRE;
using WPILib;
using WPILib.Commands;

namespace Robot.Subsystems
{
    public sealed class Drive : Subsystem
    {
        private readonly CANTalon leftMotorA = new CANTalon(RobotMap.Can.LeftMotorA);
        private readonly CANTalon leftMotorB = new CANTalon(RobotMap.Can.LeftMotorB);
        private readonly CANTalon rightMotorA = new CANTalon(RobotMap.Can.RightMotorA);
        private readonly CANTalon rightMotorB = new CANTalon(RobotMap.Can.RightMotorB);
        private readonly RobotDrive drive;

        public Drive() { drive = new RobotDrive(leftMotorA, leftMotorB, rightMotorA, rightMotorB); }

        public void Tank(double left, double right) => drive.TankDrive(left, right);
        protected override void InitDefaultCommand() => SetDefaultCommand(new Commands.Drive.DriveWithJoysticks());
    }
}
