package com.mh.jpa02.model;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.ToString;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.List;

@Data
@AllArgsConstructor
@Entity
@ToString
public class Board {

    public Board() {
    }

    @Id
    @Column(name = "board_id")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    private String name;

    @Size(min = 2, max = 30, message = "제목은 2이상 30이하 길이여야합니다.")
    private String title;

    private String content;

    private String date;

    // spring boot -> thymeleaf, security, OnetoMany ManyToOne
    /*
        jpa
        @OneToMany
        @ManyToOne
     */
    @OneToMany(mappedBy = "board", cascade = CascadeType.ALL, orphanRemoval = true, fetch = FetchType.LAZY)
    private List<BoardTail> boardTailList;


}
