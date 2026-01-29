function changeImg(id) {
    var div = document.getElementById(id);
    var bg = window.getComputedStyle(div).backgroundImage;
    var url = bg.slice(5, -2);
    document.getElementById('selectedImg').src = url;

    var bgElement = document.getElementById('bg');
    bgElement.style.backgroundImage = bg;
}
