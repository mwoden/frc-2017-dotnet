using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPILib;
using WPILib.Commands;

namespace Robot.Commands.Climber
{
    public class ClimbUp : Command
    {
        public ClimbUp() { Requires(Robot.Climber); }
        protected override void Initialize() => Robot.Climber.Climb();
        protected override bool IsFinished() => false;
        protected override void Interrupted() => Robot.Climber.Stop();
    }
}
