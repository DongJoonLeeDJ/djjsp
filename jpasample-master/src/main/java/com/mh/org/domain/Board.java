package com.mh.org.domain;

import java.sql.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Board {

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private long idx;
	
	private String name;
	private String title;
	private String content;
	private Date wdate;
	
	
	public Board(long idx, String name, String title, String content, Date wdate) {
		super();
		this.idx = idx;
		this.name = name;
		this.title = title;
		this.content = content;
		this.wdate = wdate;
	}
	@Override
	public String toString() {
		return "Board [idx=" + idx + ", name=" + name + ", title=" + title + ", content=" + content + ", wdate=" + wdate
				+ "]";
	}
	public long getIdx() {
		return idx;
	}
	public void setIdx(long idx) {
		this.idx = idx;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public String getContent() {
		return content;
	}
	public void setContent(String content) {
		this.content = content;
	}
	public Date getWdate() {
		return wdate;
	}
	public void setWdate(Date wdate) {
		this.wdate = wdate;
	}
	
	
}
