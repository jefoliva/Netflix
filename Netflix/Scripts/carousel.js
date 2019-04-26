window.onload = function () {

    function MouseWheelHandler(e, element) {
        var delta = 0;
        if (typeof e === 'number') {
            delta = e;
        } else {
            if (e.deltaX !== 0) {
                delta = e.deltaX;
            } else {
                delta = e.deltaY;
            }
            e.preventDefault();
        }

        element.scrollLeft -= (delta);
    }

    var tvniños = {};
    var drama = {};
    var accionyaventuras = {};

    function setEvents(el, id) {
        el.e = document.getElementById(`carousel-${id}`);
        el.items = document.getElementById(`carousel-items-${id}`);
        el.leftScroll = document.getElementById(`left-scroll-button-${id}`);
        el.rightScroll = document.getElementById(`right-scroll-button-${id}`);
        el.items.addEventListener("mousewheel", function (e) { handleMouse(e, el); }, false);
        el.items.addEventListener("scroll", function (e) { scrollEvent(e, el); }, false);
        el.leftScroll.addEventListener("click", function () { leftScrollClick(el); }, false);
        el.rightScroll.addEventListener("click", function () { rightScrollClick(el); }, false);
        setLeftScrollOpacity(el);
        setRightScrollOpacity(el);
    }
    setEvents(tvniños, 1);
    setEvents(drama, 2);
    setEvents(accionyaventuras, 3);



    function handleMouse(e, element) {
        MouseWheelHandler(e, element.items);
    }

    function leftScrollClick(element) {
        MouseWheelHandler(100, element.items);
    }

    function rightScrollClick(element) {
        MouseWheelHandler(-100, element.items);
    }

    function scrollEvent(e, element) {
        setLeftScrollOpacity(element);
        setRightScrollOpacity(element);
    }

    function setLeftScrollOpacity(element) {
        if (isScrolledAllLeft(element)) {
            element.leftScroll.style.opacity = 0;
        } else {
            element.leftScroll.style.opacity = 1;
        }
    }

    function isScrolledAllLeft(element) {
        if (element.items.scrollLeft === 0) {
            return true;
        } else {
            return false;
        }
    }

    function isScrolledAllRight(element) {
        if (element.items.scrollWidth > element.items.offsetWidth) {
            if (element.items.scrollLeft + element.items.offsetWidth === element.items.scrollWidth) {
                return true;
            }
        } else {
            return true;
        }

        return false;
    }

    function setRightScrollOpacity(element) {
        if (isScrolledAllRight(element)) {
            element.rightScroll.style.opacity = 0;
        } else {
            element.rightScroll.style.opacity = 1;
        }
    }
} 