"use strict";

function Id(id) {
    this.id = id;
    this.href = new URL(`#${id}`, location) + "";
}

Id.prototype.toString = function () {
    return `url(${this.href})`;
};

var Download = (function () {
    function Download() {
        const _this = this;
    }

    Download.prototype.DownloadFile = function (blob, fileName) {
        const blobDownload = new Blob([blob]);
        const url = window.URL.createObjectURL(blobDownload);
        const download = document.createElement("a");
        download.href = url;
        download.download = fileName;
        download.click();
        download.remove();
    }

    return Download;
}());

var download = new Download();