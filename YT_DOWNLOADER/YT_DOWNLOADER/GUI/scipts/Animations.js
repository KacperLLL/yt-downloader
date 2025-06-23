document.addEventListener('DOMContentLoaded', function() {

    // Animacja sortowanej listy pobieranych filmów
    new Sortable(document.getElementById('queue'), {
        animation: 150,
        ghostClass: 'sortable-ghost'
    });


    // Animacja strzałki do rozsuwania panelu pobierania
    const downBar = document.getElementById('down_bar');
    const arrow = document.querySelector('.download-tab-arrow');

    if(downBar&&arrow)
    {
        arrow.addEventListener('click', function() {
            if (downBar.style.display === 'none' || downBar.style.display === '') {
                downBar.style.display = 'block';
                arrow.classList.add('active');
                arrow.style.right = '320px';
                arrow.style.backgroundImage = 'url(styles/src/arrow_button_icon_CLOSE.svg)';
                arrow.style.animationName = 'arrowJump';
            } else {
                downBar.style.display = 'none';
                arrow.style.right = '10px';
                arrow.classList.remove('active');
                arrow.style.backgroundImage = 'url(styles/src/arrow_button_icon_OPEN.svg)';
                arrow.style.animationName = 'arrowJumpLeft';
            }
        });

        arrow.addEventListener('mouseover', function() {
            if (downBar.style.display === 'none' || downBar.style.display === '') {
                arrow.style.backgroundImage = 'url(styles/src/arrow_button_icon_OPEN_SELECTED.svg)';
                
            } else {
                arrow.style.backgroundImage = 'url(styles/src/arrow_button_icon_CLOSE_SELECTED.svg)';
                
            }

        });

        arrow.addEventListener('mouseout', function() {
            if (downBar.style.display === 'none' || downBar.style.display === '') {
                arrow.style.backgroundImage = 'url(styles/src/arrow_button_icon_OPEN.svg)';
                
            } else {
                arrow.style.backgroundImage = 'url(styles/src/arrow_button_icon_CLOSE.svg)';
                
            }

        });
    }


    //const list = document.getElementById("queue"); 
                
});