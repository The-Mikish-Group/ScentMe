//***********************************************//
//  Function used to open Web Page in new Tab    //
//***********************************************//
function newTab(tabURL) {
    var newWindowTab = window.open(tabURL);
}

//***********************************************//
//  Create Image List of Carousel Items          //
//***********************************************//
function createImageList(imageLocation, altText, imageCount) {

    altText = "";
    var i = imageCount;

    // Make *first* Picture "active" or Carousel won't start"'"
    var text = "<div class='carousel-item active'><img src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(imageCount).slice(-6)) + "' /></img></div>";
    i = i - 1;

    // Make the rest of the list
    while (i > 0) {

        text = text + "<div class='carousel-item'><img src='" + imageLocation.concat("000000".concat(i).slice(-6)) + ".jpg' alt='" + altText.concat("000000".concat(imageCount).slice(-6)) + "' /></img></div>";
        i = i - 1;

    }

    // insert the list into the "CarouselItems" element
    document.getElementById("CarouselItems").innerHTML = text;

}

//***********************************************//
//  Change background                            //
//***********************************************//
function changeBackground(newBackground) {
    $('body').css('background-image', newBackground);
}
