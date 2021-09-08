package studyobserver;

public class ControlRobot {

	public static void main(String[] args) {
		Robot MyRobot = new Robot();
		
		RobotArm MyRot_Arm = new RobotArm();
		RobotLeg MyRot_Leg = new RobotLeg();
		RobotHead MyRot_Head = new RobotHead();
		
		System.out.println("비상정지시 로봇의 팔을 멈추게 한다.");
		MyRobot.subscribe(MyRot_Arm);
		MyRobot.notifyParts(); //비상정지 호출(비상정지가 구현된 부분들 모두 호출)
		
		System.out.println("비상정지시 로봇의 팔과 다리를 멈추게 한다.");
		MyRobot.subscribe(MyRot_Leg);
		MyRobot.notifyParts();//비상정지 호출(비상정지가 구현된 부분들 모두 호출)

		System.out.println("비상정지시 로봇의 팔과 다리와 머리를 멈추게 한다.");
		MyRobot.subscribe(MyRot_Head);
		MyRobot.notifyParts();//비상정지 호출(비상정지가 구현된 부분들 모두 호출)

		System.out.println("비상정지시 팔은 움직여도 되고 다리랑 머리만 멈추게 한다.");
		MyRobot.unsubscribe(MyRot_Arm);
		MyRobot.notifyParts();//비상정지 호출(비상정지가 구현된 부분들 모두 호출)
		
	}

}
