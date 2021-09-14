package oneday.com.org;

import java.io.IOException;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;

public class Accumulate {
	private String number3;
	static Document doc;
	static Document doc1;
	static Elements test;
	static Elements e1; 
	static Elements e2;
	
	
	public Accumulate() {
		try {
			this.doc = Jsoup.connect("http://ncov.mohw.go.kr/").get();
			this.e1 = doc.getElementsByAttributeValue("class", "num");
			this.e2 = doc.getElementsByAttributeValue("class", "before");
		}
		catch (Exception e) {
			
		}
	}
	
	public String Accumulate1() {
		number3 = e1.get(0).text().substring(4);
		return number3;
	}

	public String Accumulate2() {
		number3 = e1.get(1).text();
		return number3;
	}

	public String Accumulate3() {
		number3 = e1.get(2).text();
		return number3;
	}

	public String Accumulate4() {
			number3 = e1.get(3).text();
			return number3;
	}

	public String Accumulate5() {
			number3 = e2.get(0).text().substring(4);
			return number3;
	}

	public String Accumulate6() {
			number3 = e2.get(1).text();
			return number3;
	}

	public String Accumulate7() {
			number3 = e2.get(2).text();
			return number3;
	}

	public String Accumulate8() {
			number3 = e2.get(3).text();
			return number3;
	}
	
}
