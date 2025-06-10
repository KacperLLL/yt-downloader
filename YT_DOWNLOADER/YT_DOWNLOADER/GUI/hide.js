window.addEventListener("load", function() {
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

    const video = document.querySelectorAll("iframe");
    const videoContainer = document.querySelectorAll(".thumbnail");
    const title = document.querySelectorAll("h2.title");
    const author = document.querySelectorAll(".lower-data h4");
    const download_tab = document.querySelectorAll(".download-tab");
    const buttonDownload = document.querySelectorAll(".download-button div");
    {
        if(video.length > 0)
        {
            if(window.innerWidth < 800)
            {
                videoContainer.forEach(element => {
                element.style.width = "150px";
                element.style.height = "85px";
                });
            }
            else
            {
                videoContainer.forEach(element => {
                    element.style.width = "300px";
                    element.style.height = "170px";
                });
            }

            if(window.innerWidth < 800)
            {
                video.forEach(element => {
                element.style.width = "150px";
                element.style.height = "85px";
                });
            }
            else
            {
                video.forEach(element => {
                    element.style.width = "300px";
                    element.style.height = "170px";
                });
            }

            if(window.innerWidth < 800)
            {
                title.forEach(element => {
                element.style.fontSize = "12px";
                });
            }
            else
            {
                title.forEach(element => {
                    element.style.fontSize = "16px";
                });
            }

            if(window.innerWidth < 800)
            {
                author.forEach(element => {
                element.style.fontSize = "10px";
                });
            }
            else
            {
                author.forEach(element => {
                    element.style.fontSize = "12px";
                });
            }

            if(window.innerWidth < 800)
            {
                download_tab.forEach(element => {
                element.style.height = "85px";
                });
            }
            else
            {
                download_tab.forEach(element => {
                    element.style.height = "170px";
                });
            }

            if(window.innerWidth < 800)
            {
                buttonDownload.forEach(element => {
                element.style.fontSize = "8px";
                element.style.lineHeight = "4";
                });
            }
            else
            {
                buttonDownload.forEach(element => {
                    element.style.fontSize = "14px";
                });
            }
        }
    }
}