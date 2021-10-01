package com.mh.jpa02.controller;

import com.mh.jpa02.model.Board;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping(value = "board")
public class RestApiController {

    // DB table board -> List collection 여러개의 행
//    @GetMapping("list")
//    public ResponseEntity<?> list(){
//        return null;
//    }

    // DB Board 한개 행 return
    // spring -> gson lib
    // react -> spring RestController
//    @GetMapping("test")
//    public Board one(){
//        return new Board(1l,"name",
//                "title","content","20210916");
//    }
}
