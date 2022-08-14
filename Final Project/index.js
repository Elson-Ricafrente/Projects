var slidePosition = 1;
SlideShow(slidePosition);

// forward/Back controls
function plusSlides(n) {
  SlideShow(slidePosition += n);
}

//  images controls
function currentSlide(n) {
  SlideShow(slidePosition = n);
}

function SlideShow(n) {
  var i;
  var slides = document.getElementsByClassName("Containers");
  var circles = document.getElementsByClassName("dots");
  if (n > slides.length) {slidePosition = 1}
  if (n < 1) {slidePosition = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";
  }
  for (i = 0; i < circles.length; i++) {
      circles[i].className = circles[i].className.replace(" enable", "");
  }
  slides[slidePosition-1].style.display = "block";
  circles[slidePosition-1].className += " enable";
} 

const mainMenu = document.querySelector('.menu ul');
const openMenu = document.querySelector('.open');
const closeMenu = document.querySelector('.close');

openMenu.addEventListener('click', show);

function show(){
  mainMenu.style.display = 'flex';
  closeMenu.style.display = 'block';
}

closeMenu.addEventListener('click', close);

function close(){
  mainMenu.style.display = 'none';
  closeMenu.style.display = 'none';
}


