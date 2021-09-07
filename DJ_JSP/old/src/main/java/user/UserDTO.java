package user;

//Data Transfer Object = DVO 혹은 VO
//Student 같은 객체들
//데이터베이스에 전송하거나 전송될 객체
public class UserDTO {

	String userID;
	String userPassword;
	
	
	public String getUserID() {
		return userID;
	}
	public void setUserID(String userID) {
		this.userID = userID;
	}
	public String getUserPassword() {
		return userPassword;
	}
	public void setUserPassword(String userPassword) {
		this.userPassword = userPassword;
	}
	
	//alt+shift+s 누른 뒤 r
	
	
	
}
