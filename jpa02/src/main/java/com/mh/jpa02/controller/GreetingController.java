package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;

import com.mh.jpa02.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

@Controller
public class GreetingController {

    @Autowired
    BoardRepository boardRepository;

    @GetMapping("/greeting")
    public String greeting(@RequestParam(name="name", required=false, defaultValue="World") String name, Model model) {
        model.addAttribute("name", name);
        return "greeting";
    }

    @GetMapping("/")
    public String home() {
        return "home";
    }

    @GetMapping("/board")
    public String board(Model model) {
//        List<Board> list = Arrays.asList(
//                new Board(1l,"board1",
//                        "title1111","1111content","20210916"),
//                new Board(2l,"board2",
//                        "title2222","2222content","20210917"));
        List<Board> list = boardRepository.findAll();
        model.addAttribute("list",list);
//        ArrayList
        return "board/board";
/*
슈퍼코드... java?? spring 백엔드..
플랫폼... 추천...

1. 인적사항
2. arraylist list 차이점..
 list가 부모 클래스가 라서 arraylist는 자식클래스라서
3. 데이터베이스..쓰는 이유
 - 무결성.. 큰이유가 있다... 엑셀보다 나은상황..
 - 보안..
 - pk fk
4. 데이터베이스에서...? 조회 할때.. 성능 향상 기법...
 - 인덱스 사용해서 ... 조건에따라 다를수 있지만.. 데이터 성능향상...
5. 자바 int ?? 최대값... 4바이트...
 1바이트 8bit...
 0 0 0 0 0 0 0 0
 1 1 1 1 1 1 1 1
 4바이트 32bit
 2의 32의 -1 10인
6. override overloading.... 차이...
 @overrid 재정의... 부모클래스메서드 자식클래스메서드재정의

7. react...
componet...
속성.. props
useState

django...

 */
    }

    @GetMapping("/form")
    public String form(Model model) {
        return "board/form";
    }

    /*
        react
        fetch(url).then((data)->{return data.json()}).then(

        )
        jquesy.getselector('id').val('asdf')
        useState()
     */

}