// See https://aka.ms/new-console-template for more information
using OtusHW_5;


Quadrocopter quadrocopter = new Quadrocopter();
IRobot robot = quadrocopter;
IChargeable chargeable = quadrocopter;
IFlyingRobot flyingRobot = quadrocopter;

Console.WriteLine(quadrocopter.GetInfo());
Console.WriteLine(robot.GetInfo());
Console.WriteLine(chargeable.GetInfo());
Console.WriteLine(flyingRobot.GetInfo());

Console.WriteLine(robot.GetRobotType());
Console.WriteLine(flyingRobot.GetRobotType());
Console.WriteLine(((IFlyingRobot)quadrocopter).GetRobotType());
Console.WriteLine(((IRobot)quadrocopter).GetRobotType());

quadrocopter.Charge();
quadrocopter.GetType();

