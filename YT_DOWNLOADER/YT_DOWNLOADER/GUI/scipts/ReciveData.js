function reciveSearch(jsonString)
{
  const container = document.getElementById("download-container"); 
  container.innerHTML = "";

  console.log("typeof jsonString:", typeof jsonString);
  console.log("jsonString:", jsonString);

  if (typeof jsonString === "string") {
    try {
      jsonString = JSON.parse(jsonString);
    } catch (e) {
      console.error("Błąd parsowania JSON:", e);
      return;
    }
  }

  if (!jsonString.results) {
    console.error("Brak results w jsonString!");
    return;
  }

  jsonString.results.forEach((vid, index) => {
      const tile = document.createElement("div");
        tile.className = "download-tab";
        tile.innerHTML = `<div class="thumbnail">
                            <iframe src="${zamienNaEmbed(vid.Url)}" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

                        </div>
                        <div class="data">
                            <div class="upper-data"><h2 class="title">${vid.Title}</h2></div>
                            <div class="lower-data"><h4 class="author">${vid.Author.ChannelTitle}</h4>
                            <h4 class="duration">${vid.Duration}</h4></div>
                        </div>
                        <div class="download-button">
                            <div class="button-download"></div>
                            <div class="info-button"></div>
                        </div>`;
        tile.dataset.index = index;
        container.appendChild(tile);
  });
}


function zamienNaEmbed(link) {
  const prefix = "https://www.youtube.com/watch?v=";
  const embedPrefix = "https://www.youtube.com/embed/";

  if (link.startsWith(prefix)) {
    return link.replace(prefix, embedPrefix);
  } else {
    return link; // zwróć bez zmian, jeśli nie pasuje
  }
}