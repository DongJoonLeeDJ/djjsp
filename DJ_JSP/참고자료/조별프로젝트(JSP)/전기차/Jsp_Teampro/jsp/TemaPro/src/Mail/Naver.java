package Mail;

import java.util.Properties;

import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;

public class Naver {
	
	public static void FindIDMail(String mail, String userid) {
		String host = "smtp.naver.com"; // 네이버일 경우 네이버 계정, gmail경우 gmail 계정
		String user = "umgo3245@naver.com"; // 패스워드 
		String password = "asdf1234!"; 
		
		
		Properties props = new Properties(); 
		props.put("mail.smtp.host", host); 
		props.put("mail.smtp.port", 587); 
		props.put("mail.smtp.auth", "true");

		Session session = Session.getDefaultInstance(props, new javax.mail.Authenticator() { 
			protected PasswordAuthentication getPasswordAuthentication() { 
				return new PasswordAuthentication(user, password); 
				} 
			});
		try { 
			MimeMessage message = new MimeMessage(session); 
			message.setFrom(new InternetAddress(user));
			message.addRecipient(Message.RecipientType.TO, new InternetAddress(mail)); 
			
			// 메일 제목 
			message.setSubject("아이디찾기"); 
			// 메일 내용 
			message.setText("니 아이디는 "+userid); // send the message 
			Transport.send(message); 
			System.out.println("Success Message Send"); 
			} catch (MessagingException e) { 
				e.printStackTrace(); }
		}
	public static void FindPWMail(String mail, String pw) {
		String host = "smtp.naver.com"; // 네이버일 경우 네이버 계정, gmail경우 gmail 계정
		String user = "umgo3245@naver.com"; // 패스워드 
		String password = "asdf1234!"; 
		
		
		Properties props = new Properties(); 
		props.put("mail.smtp.host", host); 
		props.put("mail.smtp.port", 587); 
		props.put("mail.smtp.auth", "true");

		Session session = Session.getDefaultInstance(props, new javax.mail.Authenticator() { 
			protected PasswordAuthentication getPasswordAuthentication() { 
				return new PasswordAuthentication(user, password); 
				} 
			});
		try { 
			MimeMessage message = new MimeMessage(session); 
			message.setFrom(new InternetAddress(user));
			message.addRecipient(Message.RecipientType.TO, new InternetAddress(mail)); 
			
			// 메일 제목 
			message.setSubject("비밀번호찾기"); 
			// 메일 내용 
			message.setText("니 비밀번호는 "+pw); // send the message 
			Transport.send(message); 
			System.out.println("Success Message Send"); 
			} catch (MessagingException e) { 
				e.printStackTrace(); }
		}
}
