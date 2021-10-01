package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;
import com.mh.jpa02.repository.BoardRepository;
import com.mh.jpa02.validator.BoardValidator;
import com.sun.org.apache.xpath.internal.operations.Mod;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Sort;
import org.springframework.security.core.Authentication;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import javax.validation.Valid;
import java.text.SimpleDateFormat;
import java.util.List;


@Controller
@RequestMapping("/board")
public class BoardController {

    @Autowired
    BoardRepository boardRepository;

    @Autowired
    BoardValidator boardValidator;


    @GetMapping("/list")
    public String board(Model model,
                        @RequestParam(required = false,defaultValue = "0")int page,
                        @RequestParam(required = false,defaultValue = "")String searchtxt) {
        int size = 5;
        Page<Board> list = boardRepository.findByTitleContainingOrContentContaining(
                searchtxt,
                searchtxt,
                PageRequest.of(page,size,
                    Sort.by(Sort.Direction.DESC, "id")
                )
        );

        model.addAttribute("startpage",1);
        model.addAttribute("curpage",(list.getPageable().getPageNumber()+1));
        model.addAttribute("endpage",list.getTotalPages());

        model.addAttribute("list", list);
        return "board/list";
    }

    /*
select * from board a, board_tail b
where a.id = b.board_id;

select * from board a
left outer join board_tail b on a.id = b.board_id;
     */

    @GetMapping("/view")
    public String view(long id,Model model) {
        Board board = boardRepository.findById(id).orElse(null);
        model.addAttribute("board",board);
        return "board/view";
    }
    
    @GetMapping("/form")
    public String form(Model model, @RequestParam(required = false, defaultValue = "0") long id) {
        Board board = boardRepository.findById(id).orElse(new Board());
        model.addAttribute("board", board);
        return "board/form";
    }

    @GetMapping("/delete")
    public String delete(@RequestParam(required = false, defaultValue = "0") long id) {
        boardRepository.deleteById(id);
        return "redirect:/board/list";
    }

    // page 모양만들기
    // # 문법 봐야됨
    // #filed

    // 다음주 월요일
    // security


    // 목금
    // @oneTomany
    // @ManyToOne

    @PostMapping("/form")
    public String form(Model model, @Valid Board board, BindingResult bindingResult, Authentication authentication ) {
//        System.out.println("작성자 = "+authentication.getName());
//        System.out.println(board);
        board.setName(authentication.getName());
        model.addAttribute("board",board);
        boardValidator.validate(board,bindingResult);
        if( bindingResult.hasErrors()){
            return "board/form";
        }
        long nano = System.currentTimeMillis();
        String curDate = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").format(nano);
        board.setDate(curDate);
//        board.setId(1l);
        boardRepository.save(board);
        return "redirect:/board/list";
    }

}
