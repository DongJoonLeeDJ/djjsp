package com.mh.org4.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

import org.springframework.stereotype.Component;

import com.mh.org4.dto.TestDto;

@Component
public class TestDao {

	public ArrayList<TestDto> doList() {
		ArrayList<TestDto> list = new ArrayList<TestDto>();
		System.out.println("dolist");
		
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		
		String url = "jdbc:mysql://localhost:3306/mh"; 

		try {
			// jar 파일
			Class.forName("com.mysql.jdbc.Driver");
			// mysql db 연결 id root pw 1234
			conn = DriverManager.getConnection(url, "root", "1234");
			// select 작성
			pstmt = conn.prepareStatement("select * from test");
			// 실행.. 반환되는값을..rs 담는거..
			rs = pstmt.executeQuery();
			// rs...next...
			while(rs.next()) {
				
				TestDto dto = new TestDto();
				dto.setPara1(rs.getString(1));
				dto.setPara2(rs.getString(2));
				list.add(dto);
				
//				System.out.println("rs.getString(1) = "+rs.getString(1));
//				System.out.println("rs.getString(2) = "+rs.getString(2));
//				list.add(rs.getString(1));
//				list.add(rs.getString(2));
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		
//		list.add("a");
//		list.add("b");
		return list;
	}
}
