package DB;

public interface MySQL {
	public static final String CLASS_NAME = "com.mysql.cj.jdbc.Driver";
//	public static final String DB_URL = "jdbc:mysql://mydb-js.ctxirfweshyb.us-east-2.rds.amazonaws.com:3306/charge?useUnicode=yes&characterEncoding=UTF8";
	public static final String DB_URL = "jdbc:mysql://192.168.0.104:3306/charge?useUnicode=yes&characterEncoding=UTF8";
	public static final String USER_ID = "root";
	public static final String USER_PW = "1234";
	public static final String ADMIN_ID = "root";
	public static final String ADMIN_PW = "1234";
	/**
	 * 2020-12-31 11:59:59
	 */
	public static final String FORM_TIME12HOURS = "yyyy-MM-dd hh:mm:ss";
	/**
	 * 2020-12-31 23:59:59
	 */
	public static final String FORM_TIME24HOURS = "yyyy-MM-dd HH:mm:ss";

}
