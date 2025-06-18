function reciveSearch(jsonString)
{
  const recivedObject = JSON.parse(jsonString)
  
  recivedObject.results.forEach((vid, index) => {
      const tile = document.createElement("div");
        tile.className = "download-tab";
        tile.innerHTML = `<div class="thumbnail">
                            <iframe src="${vid.Url}" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

                        </div>
                        <div class="data">
                            <div class="upper-data"><h2 class="title">${vid.Title}</h2></div>
                            <div class="lower-data"><h4 class="author">${vid.ChannelTitle}</h4>
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


/*
function reciveSearch(Q)
{
  if (Q.startsWith("#SRESPONSE")) {
    let args = Q.replace(/#SRESPONSE_/g, "").replace(/;/g, "").split("#");

    args.forEach(arg => {
      console.log(arg);
    });
    
    const container = document.getElementById("download-container"); 
    container.innerHTML = "";

    let tittle = "";
    let author = "";
    let duration = "";
    let url ="";

    let actual=0;
    let video_id=0;
    args.forEach(arg => {
      if(actual<=3)
      {
        switch(actual)
        {
          case 0:
            {
              url = zamienNaEmbed(arg);
              break;
            }
          case 1:
            {
              tittle = arg;
              break;
            }
          case 2:
            {
              author = arg;
              break;
            }
          case 3:
            {
              duration = arg;
              break;
            }
          default:
            {
              break;
            }
        }
        actual++;
      }
      else
      {
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
        tile.dataset.index = video_id;
        container.appendChild(tile);

        video_id++;
        actual=1;
        tittle = "";
        author = "";
        duration = "";
        url = zamienNaEmbed(arg);
      }

    });
  
  }
}


function zamienNaEmbed(link) {
  const prefix = "https://www.youtube.com/watch?v=";
  const embedPrefix = "https://www.youtube.com/embed/";

  if (link.startsWith(prefix)) {
    return link.replace(prefix, embedPrefix);
  } else {
    return link; // zwróć bez zmian, jeśli nie pasuje
  }
}*/