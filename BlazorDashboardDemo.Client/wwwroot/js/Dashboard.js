console.log("Dashboard.js loaded");
window.getContainerWidth = (selector) => {
    const element = document.querySelector(selector);
    return element ? element.offsetWidth : 0;
};