package studyobserver;

public class RobotHead implements EmergencyStopable{

	@Override
	public void Stop() {
		// TODO Auto-generated method stub
		System.out.println("The other robots stopped.");
		System.out.println("But This is already stopped.");
	}

}
