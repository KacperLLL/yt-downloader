document.addEventListener('DOMContentLoaded', function() {
    const queryCount = 10; // Zmienna do przechowywania liczby odpowiedzi na zapytanie
    const serach = document.getElementById('search-button');

    // argument pierwszy to zapytanie, drugi to ilość oczekiwanych wyników
    serach.addEventListener('click', function()
    {   
        const container = document.getElementById("download-container");
        const searchInputElement = document.getElementById('search-input');
        if (searchInputElement) {
            container.innerHTML = '<span class="loader"></span>';
            const searchInput = searchInputElement.value;  
            const query = new QueryCode(searchInput, 10, "search");

            window.chrome.webview.postMessage(JSON.stringify(query));
        }
        
    });

    document.addEventListener("keydown", function(event) {
    if (event.key === "Enter") {
        serach.click();
    }
    });
});