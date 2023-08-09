// scroll-to-top
const scrollUp = document.querySelector("#scroll-to-top");

window.addEventListener("scroll", () => {

    if (this.scrollY >= 350)
        scrollUp.classList.add("active");
    else
        scrollUp.classList.remove("active")
})

// sticky-navbar
window.onscroll = function () {
    myFunction()
};
var menu = document.getElementById("menu");
var sticky = menu.offsetTop;

function myFunction() {
    if (window.pageYOffset >= sticky) {
        menu.classList.add("sticky")
    } else {
        menu.classList.remove("sticky");
    }
}
//slideshow
var slideIndex = 0;
showSlides();

function showSlides() {
    var i;
    var slides = document.getElementsByClassName("slide-banner-content");
    var dots = document.getElementsByClassName("dot");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex > slides.length) {
        slideIndex = 1
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    setTimeout(showSlides, 2000);
}
/*---------- */
const brandSwiper = new Swiper('.brand-slideshow .swiper', {
    loop: true,
    speed: 500,
    slidesPerView: 1,
    autoplay: {
        delay: 2000,
        disableOnInteraction: false,
        pauseOnMouseEnter: true,
    },
    // navigation: {
    //     nextEl: '.brandslider .swiper-next',
    //     prevEl: '.brand__slider .swiper-prev',
    // },
    breakpoints: {
        // >= 480
        480: {
            slidesPerView: 2
        },
        768: {
            slidesPerView: 4
        },
        1200: {
            slidesPerView: 6
        },
    }
});
// res - menu-navbars
function openNav() {
    document.getElementById("Side-nav").style.width = "250px";
}

function closeNav() {
    document.getElementById("Side-nav").style.width = "0";
}
// Footer List Control
function footerListControl() {
    const footerDrop = document.querySelectorAll(".footer-content.has-drop");

    footerDrop.forEach((item) => {
        const footerTitle = item.querySelector(".footer-title");

        footerTitle.addEventListener("click", () => {
            const footerDropActive = document.querySelector(".footer-content.active");

            if (footerDropActive && footerDropActive != item)
                footerDropActive.classList.remove("active");
            item.classList.toggle("active");
        })
    })
};
footerListControl();
// res-search 
const icon = document.querySelector('.icon');
const search = document.querySelector('.search');
icon.onclick = function () {
    search.classList.toggle('active');
}

//search
function timkiem() {
    var input = document.getElementById("searchinput").value;
    if (input == "") {
        alert("Mời nhập");
    }
    else if (input.indexOf("daniel wellington") >= 0 || input.indexOf("dw") >= 0) {
        location.href = "searchResultDW.aspx";
    }
    else if (input.indexOf("hublot") >= 0 || input.indexOf("hl") >= 0) {
        location.href = "searchResultHL.aspx";
    }
    else {
        location.href = "home.aspx";
    }
}
