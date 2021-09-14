(function ($) {
"use strict";


$('.main-menu nav > ul > li').slice(-2).addClass('last-elements');

/* meanmenu */
$('.main-menu nav').meanmenu({
	 meanMenuContainer: '.mobile-menu-area',
	 meanScreenWidth: "767"
});
 
/* slider-active  */
$('.slider-active').owlCarousel({
    loop:true,
    nav:true,
	navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
    responsive:{
        0:{
            items:1,
			nav:false,
        },
        767:{
            items:1,
			nav:false,
        },
        1000:{
            items:1
        }
    }
})

/* counter */
$('.counter').counterUp(900);

/* mixItUp */
$('#Container').mixItUp();

/* image-link */
$('.image-link').magnificPopup({
  type: 'image',
  gallery:{
    enabled:true
  }
});

/* video-popup */
$('.video-popup').magnificPopup({
  type: 'iframe'
});

/* testimonial-active */
$('.testimonial-active').owlCarousel({
    loop:true,
    nav:false,
	autoplay:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        }
    }
})


/* brand-active */
$('.brand-active').owlCarousel({
    loop:true,
    nav:false,
	dots:false,
	autoplay:false,
	navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
    responsive:{
        0:{
            items:2
        },
        45:{
            items:3
        },
        768:{
            items:4
        },
        1000:{
            items:6
        }
    }
})


})(jQuery);	