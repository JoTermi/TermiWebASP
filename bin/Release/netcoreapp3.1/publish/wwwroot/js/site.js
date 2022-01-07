// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function displayLandingButton() {
    document.getElementById("buttonLandingPage").style.visibility = 'visible';
    document.getElementById("buttonLandingPage").style.alignItems = 'center';
    document.getElementById("buttonLandingPage").style.justifyContent = 'center';
}

function hideLandingButton() {
    document.getElementById("buttonLandingPage").style.visibility = 'hidden';
}

function topFunction() {

    document.getElementById('GoUp').setAttribute('style', 'visibility:hidden');
    window.scrollTo({
        behavior: "smooth",
        top: 0,
    });
}


// Shows the button When the user scrolls down 10px from the top of the document
function scrollFunction() {

    if (document.body.scrollTop > 10 || document.documentElement.scrollTop > 10) {
        document.getElementById('GoUp').setAttribute('style', 'visibility:visible');
    }
    else {
        document.getElementById('GoUp').setAttribute('style', 'visibility:hidden');
    }
}

function loadImpressum() {

    document.getElementById('impressumId').scrollIntoView();
    topFunction();

}

function loadIcon2() {

    var isChrome = !!window.chrome && (!!window.chrome.webstore || !!window.chrome.runtime);
    if (isChrome) {
        document.getElementById('imgIcon').setAttribute('style', 'width:50px');
        document.getElementById('imgIcon').setAttribute('style', 'height:40px');
    }
}

function loadIcon() {

    // Chrome 1 - 85
    var isChrome = !!window.chrome && (!!window.chrome.webstore || !!window.chrome.runtime);
    if (isChrome) {
        document.getElementById('imageIcon').setAttribute('style', 'width:40%');
    }

    // Firefox 1.0+
    var isFirefox = typeof InstallTrigger !== 'undefined';
    if (isFirefox) {
        // Do nothing. The icon is set properly in firefox
    }

    // Edge 20+
    var isEdge = !isIE && !!window.StyleMedia;
    if (isEdge) {
        document.getElementById('imageIcon').setAttribute('style', 'width:40%');
    }

    // Internet Explorer 6-11
    var isIE = /*@cc_on!@*/false || !!document.documentMode;
    if (isIE) {
        document.getElementById('imageIcon').setAttribute('style', 'width:40%');
    }
}


function getBaseUrl() {
    var re = new RegExp(/^.*\/\/[^\/]+/);
    return re.exec(window.location.href);
}

function eventFire(el, etype) {
    alert("TEST EVENT FIRE!");
    if (el.fireEvent) {
        el.fireEvent('on' + etype);
    } else {
        var evObj = document.createEvent('Events');
        evObj.initEvent(etype, true, false);
        el.dispatchEvent(evObj);
    }
}

function smoothScroll(target) {
    
    var clientHeight = document.getElementById('navBarId').clientHeight;

    if (target === 'homeId') {

        document.querySelector('.home').scrollIntoView({
            behavior: 'smooth',
        });
    }

    if (target === 'leistungId') {

        //alert("The Window location is: " + window.location);
        alert("In leistung id");

        document.querySelector('.leistung').scrollIntoView({
            behavior: 'smooth',
        });
    }

    if (target === 'contactId') {

        document.querySelector('.contact').scrollIntoView({
            behavior: 'smooth',
        });
    }
    if (target === 'skillsId') {

        document.querySelector('.skills').scrollIntoView({
            behavior: 'smooth',
        });
    }

    if (target === 'linkId') {

        document.querySelector('.link').scrollIntoView({
            behavior: 'smooth',
        });
    }

    setTimeout(() => {
        window.scrollTo({ behavior: 'smooth', top: window.scrollY - clientHeight });
    }, 500);

}
