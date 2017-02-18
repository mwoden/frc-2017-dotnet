namespace Robot
{
    public static class RobotMap
    {
        public static class Can
        {
            public static int LeftMotorA => 1;
            public static int LeftMotorB => 2;
            public static int RightMotorA => 3;
            public static int RightMotorB => 4;
        }

        public static class Pwm
        {
            public static int Climber => 0;
            public static int Shooter => 1;
            public static int Elevator => 2;
            public static int Intake => 3;

            public static int Auger => 5;
        }

        public static class Solenoid
        {
            public static int GearManipulatorForward => 1;
            public static int GearManipulatorReverse => 0;
        }

        public static class Oi
        {
            public static class Controller
            {
                public static int LeftStick => 0;
                public static int RightStick => 1;
                public static int Copilot => 2;
            }

            public static class XboxButton
            {
                public static int A => 1;
                public static int X => 3;

            }
        }
    }
}
