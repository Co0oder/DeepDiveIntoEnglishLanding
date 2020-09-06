//Geting elements from page
const elems = document.querySelectorAll(".carousel-images img");
const but_next = document.querySelector(".carousel-next");
const but_prev = document.querySelector(".carousel-prev");
const frame = document.querySelector(".frame");

const step = elems[0].clientWidth;
const count = elems.length;

var position = 0;

animate();

but_next.addEventListener('click', () => {
    if (position < step * (count - 2)) position += step;
    animateFrame()
    animate();
});

but_prev.addEventListener('click', () => {
    if (position > -step) position -= step;
    animateFrame()
    animate();
});

function animate() {
    elems.forEach((item) => { item.style.transform = `translateX(${-position}px) scale(0)` })
    var index = position / step;
    //If you are at the beginning of a carousel, disable animation left
    if (index === -1) {
        elems[0].style.transform = `translateX(${-position}px) scale(1)`;
        elems[1].style.transform = `translateX(${-position}px) scale(0.65)`;
    } else {
        elems[index].style.transform = `translateX(${-position}px) scale(0.65)`;
        elems[index + 1].style.transform = `translateX(${-position}px) scale(1)`;
        //If you are at the end of a carousel, disable animation right
        if (index < count - 2)
        elems[index + 2].style.transform = `translateX(${-position}px) scale(0.65)`;
    }
}

//Animate frame after button click
function animateFrame()
{
    frame.style.transform = `scale(1.08)`;
    frame.style.opacity = `0.5`;
    setTimeout(() => { frame.style.transform = `scale(1)`; frame.style.opacity = `1`; }, 500)
}