package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;

import com.mh.jpa02.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Sort;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import javax.validation.Valid;
import java.text.SimpleDateFormat;
import java.util.List;

/*
1. 게시판
 - 쓰기 할때 날짜저장
 - 자세히 보기
 - page 1페이지 -> 10 2페이지 -> 10

2. security -> login
 로그인안한상태
 /main.jsp
 로그인한상태 ( user )
 /board
 로그인한상태 ( admin )
 /memberlist 회원목록
 /게시글관리...
 -> 코로나 ..

3. @OneToMany
jpa
 - left outer join
 - inner join
 select * from board a
 left outer join board_tail b on a.board_id = b.board.id

 select * from board a, board_tail b
 where a.board_id == b.board.id

프론트 -> 백엔드 (springboot)
- react.js
select -> update-> delete -> insert

-- 개발자...
-- 갑질... 서비스업종..
민간 기업 jpa ...
공사,, mybatis...

4. OAuth 인증처리...
google 로그인, apple 로그인

 */
@Controller
public class GreetingController {

    @Autowired
    BoardRepository boardRepository;

    @GetMapping("/greeting")
    public String greeting(@RequestParam(name = "name", required = false, defaultValue = "World") String name, Model model) {
        model.addAttribute("name", name);
        return "greeting";
    }

    @GetMapping("/")
    public String home() {
        return "home";
    }

    @GetMapping("/board")
    public String board(Model model) {
        List<Board> list = boardRepository.findAll(Sort.by(Sort.Direction.DESC, "id"));
        model.addAttribute("list", list);
        return "board/board";

    }

    @GetMapping("/form")
    public String form(Board board) {
        return "board/form";
    }

    @PostMapping("/form")
    public String form(Model model,@Valid Board board, BindingResult bindingResult) {
        model.addAttribute("board",board);
        if( bindingResult.hasErrors()){
//            System.out.println("일로오나");
            return "board/form";
        }
        long nano = System.currentTimeMillis();
        String curDate = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(nano);
        board.setDate(curDate);
        boardRepository.save(board);
        return "redirect:/board";
    }

    //    @PostMapping("/form")
//    public String form(@RequestParam(name = "title") String title,
//                       @RequestParam(name = "content") String content) {
//        System.out.println(title);
//        System.out.println(content);
//        Board board = new Board();
//        board.setTitle(title);
//        board.setContent(content);
//        boardRepository.save(board);
//        return "board/form";
//    }

}