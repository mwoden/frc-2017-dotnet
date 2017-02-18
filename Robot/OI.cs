using WPILib;
using WPILib.Buttons;

namespace Robot
{
    /**
     * This class is the glue that binds the controls on the physical operator
     * interface to the commands and command groups that allow control of the robot.
     */
    public class OI
    {
        private readonly Joystick leftStick = new Joystick(RobotMap.Oi.Controller.LeftStick);
        private readonly Joystick rightStick = new Joystick(RobotMap.Oi.Controller.RightStick);
        private readonly XboxController copilot = new XboxController(RobotMap.Oi.Controller.Copilot);

        public OI()
        {
        }

        public double LeftY => -leftStick.GetY();
        public double RightY => -rightStick.GetY();
    }
}
