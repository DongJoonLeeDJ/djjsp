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
    @Column(name = "boardtail_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String tuser_name;
    private String tcontent;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "board_id")
    private Board board;
}
