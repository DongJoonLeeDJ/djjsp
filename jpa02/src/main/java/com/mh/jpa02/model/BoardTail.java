package com.mh.jpa02.model;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.RequiredArgsConstructor;
import lombok.ToString;

import javax.persistence.*;

@Entity
@Data
@ToString
@AllArgsConstructor
@RequiredArgsConstructor
public class BoardTail {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String tuser_name;
    private String tcontent;

    private long board_id;
}
