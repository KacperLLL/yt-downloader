//lista elementów w kolejce, oraz lista wyświtlanych filmów
let elements = [];
let films = [];

//klasa elementu kolejki
class Element {
    constructor(vid, index) {
        this.id = index;
        this.url = vid.Url;
        this.title = vid.Title;
        this.duration = vid.Duration;
        this.author = vid.Author.ChannelTitle;
        this.isDownloading = false;
        this.queue = document.getElementById("queue");
        this.mainContainer = document.getElementById("download-container");
    }
   
    addToList(){   
        const tile = document.createElement("div");
            tile.className = "download-tab";
            tile.innerHTML = `<div class="thumbnail">
                                <iframe src="${zamienNaEmbed(this.url)}" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

                            </div>
                            <div class="data">
                                <div class="upper-data"><h2 class="title">${this.title}</h2></div>
                                <div class="lower-data"><h4 class="author">${this.author}</h4>
                                <h4 class="duration">${this.duration}</h4></div>
                            </div>
                            <div class="download-button">
                                <div class="button-download"></div> 
                                <div class="info-button"></div>
                            </div>`;
            tile.dataset.index = this.id;
            tile.dataset.duration = this.duration;
            tile.dataset.author = this.author;
            this.mainContainer.appendChild(tile); 
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