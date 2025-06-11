document.addEventListener("DOMContentLoaded", function() {
    const container = document.getElementById("download-container"); 

let tittle = "oto jak straciłem ponad 100.000 PLN..."
let author = "Karol Friz Wiśniewski"
let duration = "21:16";
let url ="https://www.youtube.com/embed/e6763Kqd8NY?si=u9dXn52JOIFkSWTr";


    if (!container) {
    console.error("Download container not found");}

        for (let i = 1; i <= 6; i++) {
        const tile = document.createElement("div");
        tile.className = "download-tab";
        tile.innerHTML = `<div class="thumbnail">
                            <iframe src="${url}" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

                        </div>
                        <div class="data">
                            <div class="upper-data"><h2 class="title">${tittle}</h2></div>
                            <div class="lower-data"><h4 class="author">${author}</h4>
                            <h4 class="duration">${duration}</h4></div>
                        </div>
                        <div class="download-button">
                            <div class="button-download"></div>
                            <div class="info-button"></div>
                        </div>`;
        tile.dataset.index = i;
        container.appendChild(tile);
        }

    });