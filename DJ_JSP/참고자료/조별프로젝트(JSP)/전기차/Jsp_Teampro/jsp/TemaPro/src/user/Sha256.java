package user;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class Sha256 {
	public static String ecrypt(String input) {
		MessageDigest md = null;
		byte[] byteData = null;
		try {
			md = MessageDigest.getInstance("SHA-256");
			md.update(input.getBytes());
			byteData = md.digest();
			StringBuffer sb = new StringBuffer();
			for (int i = 0; i < byteData.length; i++) {
				sb.append(Integer.toString((byteData[i] & 0xff) + 0x100, 16).substring(1));
			}
			StringBuffer hexString = new StringBuffer();
			for (int i = 0; i < byteData.length; i++) {
				String hex = Integer.toHexString(0xff & byteData[i]);
				if (hex.length() == 1) {
					hexString.append('0');
				}
				hexString.append(hex);
			}
			return hexString.toString();
		} catch (NoSuchAlgorithmException e) {
			e.printStackTrace();
			return null;
		}
	}
}
