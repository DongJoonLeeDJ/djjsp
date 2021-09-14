package oneday.com.org;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.SocketTimeoutException;

import org.jsoup.HttpStatusException;
import org.jsoup.Jsoup;
import org.jsoup.UnsupportedMimeTypeException;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;

public class OneDay1 {
	private int number1;
	private int number2;
	static Document doc;
	static Elements e1;

	public OneDay1() {
		try {
			this.doc = Jsoup.connect("http://ncov.mohw.go.kr/").get();
			this.e1 = doc.getElementsByAttributeValue("class", "data");
		} catch (Exception e) {

		}
	}

	public int OneDay1() {
		number1 = Integer.parseInt(e1.get(0).text());
		return number1;
	}

	public int OneDay2() {
		number2 = Integer.parseInt(e1.get(1).text());
		return number2;
	}

}
