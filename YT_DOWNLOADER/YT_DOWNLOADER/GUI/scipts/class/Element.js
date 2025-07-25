//lista elementów w kolejce, oraz lista wyświtlanych filmów
let elements = [];
let list = [];

//klasa elementu kolejki
class Element {
    constructor(vid) {
        this.url = vid.Url;
        this.title = vid.Title;
        this.duration = vid.Duration;
        this.author = vid.Author.ChannelTitle;
        this.isDownloading = false;
        this.queue = document.getElementById("queue");
        this.mainContainer = document.getElementById("download-container");
        this.queueTile = null;
    }
   
    addToList(){   null
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
            this.mainContainer.appendChild(tile); 
            list.push(this);

            tile.querySelector(".button-download").addEventListener("click", () => {
                this.addToQueue();
            });
        }
    addToQueue() {
        try
        {
            elements.forEach(element => {
            if(element.url === this.url) {
                throw new Error("Film już w kolejce");
            }
        });

        this.queueTile = document.createElement("li");
        this.queueTile.innerHTML = `<div class="queue-item">
                                <div class="QuTitle">${this.title}}</div>
                                <div class="QuAuthor">${this.author}</div>
                                <div class="btn_trash"></div>
                            </div>`;
        this.queue.appendChild(this.queueTile);
        this.queueTile.querySelector(".btn_trash").addEventListener("click", () => {
            this.removeFromQueue();
        });
        elements.push(this);
        }
        catch (error) {
            alert(error.message);
        }
    }
    removeFromQueue() {
        this.queue.removeChild(this.queueTile);
        elements = elements.filter(element => element !== this);
        this.queueTile = null;
    }
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