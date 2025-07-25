function reciveSearch(jsonString)
{
  const container = document.getElementById("download-container"); 
  container.innerHTML = "";

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

  jsonString.results.forEach((vid) => {
    let element = new Element(vid);
    element.addToList();
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