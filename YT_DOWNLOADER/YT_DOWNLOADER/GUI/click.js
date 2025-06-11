const serach = document.getElementById('search-button');

serach.addEventListener('click', function()
{
    if(serach)
    {
        window.chrome.webviev.postMessage("search");
        alert('work');
    }
    else
    {
        console.error('Search not found');
    }
});

function Test(data)
{
    alert('data recived' + data);
}