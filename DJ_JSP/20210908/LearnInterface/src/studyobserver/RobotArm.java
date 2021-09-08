package studyobserver;

public class RobotArm implements EmergencyStopable {

	@Override
	public void Stop() {
		// TODO Auto-generated method stub
		System.out.println("send command : stop Arm");
		//특정 위치로 Lan 통신이 Rs232통신을 해서 장비를 멈추는 데 필요한 메시지들을 보냄
	}

	
}
