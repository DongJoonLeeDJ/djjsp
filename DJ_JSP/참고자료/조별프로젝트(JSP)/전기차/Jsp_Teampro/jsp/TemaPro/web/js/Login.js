var formTarget = $('.form-box').find('input, textarea');
formTarget.on('keyup blur focus', function (e) {
  
  var $this = $(this),
    label = $this.prev('label');
  
  if (e.type === 'keyup') {
    if ($this.val() === '') {
      label.removeClass('active highlight');
    } else {
      label.addClass('active highlight');
    }
  } else if (e.type === 'blur') {
    if( $this.val() === '' ) {
      label.removeClass('active highlight');
    } else {
      label.removeClass('highlight');
    }
  } else if (e.type === 'focus') {
    
    if( $this.val() === '' ) {
      label.removeClass('highlight');
    }
    else if( $this.val() !== '' ) {
      label.addClass('highlight');
    }
  }
  
});

var tab = $('.tab a');
tab.on('click', function (e) {
  
  e.preventDefault();
  
  $(this).parent().addClass('active');
  $(this).parent().siblings().removeClass('active');
  
  var target = $(this).attr('href'),
    tabContents = $('.tab-content > div');
  
  tabContents.not(target).hide();
  
  $(target).fadeIn(600);
  
});