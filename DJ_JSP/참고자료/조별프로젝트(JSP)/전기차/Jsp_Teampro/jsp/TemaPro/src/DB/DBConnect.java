package DB;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 * default singleton
 * 
 * @author jaemoonnlee
 *
 */
public class DBConnect {
	private DBConnect() {
		try {
			Class.forName(MySQL.CLASS_NAME);
			instance = DriverManager.getConnection(MySQL.DB_URL, MySQL.USER_ID, MySQL.USER_PW);
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			// ?
		}
	}

	private static Connection instance = null;

	public static Connection getInstance() {
		if (instance == null) {
			new DBConnect();
		}
		return instance;
	}
}