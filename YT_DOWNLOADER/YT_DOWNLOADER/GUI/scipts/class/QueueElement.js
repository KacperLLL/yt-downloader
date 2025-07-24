class QueueElement {
    constructor(id, title, duration, author, url) {
        this.id = id;
        this.url = url;
        this.title = title;
        this.duration = duration;
        this.author = author;
        this.isDownloading = false;
    }

   

    addToQueue() {}
    removeFromQueue() {}
    startDownload() {}
    stopDownload() {}

    //getter methods to access the properties
    getStatus() {
            return this.isDownloading;
        }

    getId() {
        return this.id;
    }

    getUrl() {
        return this.url;
    }

    getTitle() {
        return this.title;
    }

    getDuration() {
        return this.duration;
    }

    getAuthor() {
        return this.author;
    }

}