document.addEventListener('DOMContentLoaded', function() {
    const queryCount = 10; // Zmienna do przechowywania liczby odpowiedzi na zapytanie
    const serach = document.getElementById('search-button');

    // argument pierwszy to zapytanie, drugi to ilość oczekiwanych wyników
    serach.addEventListener('click', function()
    {   
        const container = document.getElementById("download-container");
        const searchInputElement = document.getElementById('search-input');
        if (searchInputElement) {
            container.innerHTML = "";
            const searchInput = searchInputElement.value;
            const query = '#SEARCH_' + searchInput+ "_" + queryCount+";";
            window.chrome.webview.postMessage(query);
        }
        
    });

    document.addEventListener("keydown", function(event) {
    if (event.key === "Enter") {
        serach.click();
    }
    });
});