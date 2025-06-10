document.addEventListener("DOMContentLoaded", function() {
    hideElements();
});

window.addEventListener("resize", function() {
    hideElements();
});

function hideElements() 
    {
        const home = document.querySelectorAll(".link_a");
    home.forEach(element => {
        if(element.dataset.button === "home")
        {
            if(window.innerWidth < 800)
            {
                element.textContent = "";
            }else
            {
                element.textContent = "Home";
            }
        }else if(element.dataset.button === "downloads")
        {
            if(window.innerWidth < 800)
            {
                element.textContent = "";
            }else
            {
                element.textContent = "Download";
            }
        }
        else if(element.dataset.button === "settings")
        {
            if(window.innerWidth < 800)
            {
                element.textContent = "";
            }else
            {
                element.textContent = "Settings";
            }
        }
        else if(element.dataset.button === "help")
        {
            if(window.innerWidth < 800)
            {
                element.textContent = "";
            }else
            {
                element.textContent = "Help";
            }
        }
        
    });

    const navbar = document.getElementById("nav-bar");
    if(navbar){
            if(window.innerWidth < 800)
            {
                navbar.style.width = "75px"
            }else
            {
                navbar.style.width = "150px";
            }
        }

    const mainPage = document.getElementById("main-page");
    if(mainPage){
        if(window.innerWidth < 800)
        {
            mainPage.style.marginLeft = "75px";
        }else
        {
            mainPage.style.marginLeft = "150px";
        }
    }
}