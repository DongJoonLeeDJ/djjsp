package com.mh.mocom.dao;

import java.util.List;

import org.apache.ibatis.session.SqlSession;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.mh.mocom.dto.BoardDto;

@Repository
public class BoardDao {
	
	@Autowired
	SqlSession sqlsession;

	public List<BoardDto> selectlist() {
		List<BoardDto> list = sqlsession.selectList("board.selectlist"); 
		return list;
	}
}
