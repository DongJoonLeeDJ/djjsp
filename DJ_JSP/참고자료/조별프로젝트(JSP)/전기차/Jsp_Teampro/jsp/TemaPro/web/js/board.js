/**
 * 게시글 불러오기
 * @param {String} board_title path용 변수
 * @param {int} id article_idx
 */
function readArticle(board_title, id) {
	location.href = 'index.jsp?contentPage=Board/' + board_title + '_detail.jsp?idx=' + id;
}

/**
 * 게시글 삭제
 * @param {String} board_title path용 변수
 * @param {int} id article_idx
 */
function deleteArticle(board_title, id) {
	if (confirm('삭제하시겠습니까?'))
		location.href = 'index.jsp?contentPage=Board/proc_' + board_title + '.jsp?idx=' + id;
	else
		alert('삭제 취소');
}

/**
 * 댓글 작성
 * @param {String} board_title 
 * @param {int} article_idx 
 * @param {int} mid 
 * @param {int} rp_level 
 */
function writeReply(board_title, article_idx, mid, rp_level = 0) {
	const URL = 'Board/proc_write_reply.jsp';
	let rp_context = $('#rp_context').val();
	$.ajax({
		url: URL,// URL
		type: 'POST',
		cache: false,
		dataType: 'json',
		data: {
			"board_title": board_title,
			"article_idx": article_idx,
			"mid": mid,
			"rp_context": rp_context,
			"rp_level": rp_level
		},
		success: function () {
			location.reload();
		},
		error: function (request, status, error) {
			let msg = 'ERR<br>';
			msg += request.status + '<br>'
				+ request.responseText + '<br>'
				+ error;
			console.log(msg);
		}
	})
}