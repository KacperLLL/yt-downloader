document.addEventListener('DOMContentLoaded', function() {
  new Sortable(document.getElementById('queue'), {
    animation: 150,
    ghostClass: 'sortable-ghost'
  });



    const downBar = document.getElementById('down_bar');
    const arrow = document.querySelector('.download-tab-arrow');

    if(downBar&&arrow)
    {
        arrow.addEventListener('click', function() {
            if (downBar.style.display === 'none' || downBar.style.display === '') {
                downBar.style.display = 'block';
                arrow.classList.add('active');
                arrow.style.right = '320px';
                arrow.style.backgroundImage = 'url(src/arrow_button_icon_CLOSE.svg)';
                arrow.style.animationName = 'arrowJump';
            } else {
                downBar.style.display = 'none';
                arrow.style.right = '10px';
                arrow.classList.remove('active');
                arrow.style.backgroundImage = 'url(src/arrow_button_icon_OPEN.svg)';
                arrow.style.animationName = 'arrowJumpLeft';
            }
        });

        arrow.addEventListener('mouseover', function() {
            if (downBar.style.display === 'none' || downBar.style.display === '') {
                arrow.style.backgroundImage = 'url(src/arrow_button_icon_OPEN_SELECTED.svg)';
                
            } else {
                arrow.style.backgroundImage = 'url(src/arrow_button_icon_CLOSE_SELECTED.svg)';
                
            }

        });

        arrow.addEventListener('mouseout', function() {
            if (downBar.style.display === 'none' || downBar.style.display === '') {
                arrow.style.backgroundImage = 'url(src/arrow_button_icon_OPEN.svg)';
                
            } else {
                arrow.style.backgroundImage = 'url(src/arrow_button_icon_CLOSE.svg)';
                
            }

        });
    }

/*
    const list = document.getElementById("queue"); 

        let tittleQ = "oto jak straciłem ponad 100.000 PLN..."
        let authorQ = "Karol Friz Wiśniewski"
        let durationQ = "21:16";



            if (!list) {
            console.error("Download container not found");}

                for (let i = 1; i <= 6; i++) {
                const tile = document.createElement("li");
                tile.className = "queue-item";
                tile.innerHTML = `<li class="queue-item"><div><h1 class="QuTitle">${tittleQ}</h1><h4 class="QuAuthor">${authorQ}<br>${durationQ}</h4></div><div class="btn_trash"></div></li>
`;
                tile.dataset.index = i;
                list.appendChild(tile);
                }*/
});