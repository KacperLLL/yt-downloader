class QueueElement{
  constructor(url, duration, title, author)
  {
    this.url = url;
    this.duration = duration;
    this.title = title;
    this.author = author;
    this.queue = document.getElementById("queue");
  }

  addToQueue() {
    const tile = document.createElement("li");
    tile.innerHTML = `<div class="queue-item">
                        <div class="QuTitle">${this.title}}</div>
                        <div class="QuAuthor">${this.author}</div>
                        <div class="btn_trash"></div>
                    </div>`;
    this.queue.appendChild(tile);
    const trash = tile.querySelector(".btn_trash");
    trash.addEventListener("click", () => {
      this.removeFromQueue();
    });
    queueList.push(this);
    tile.dataset.index = queueList.length;
  }

  removeFromQueue() {
    const index = queueList.indexOf(this);
    if (index > -1) {
      queueList.splice(index, 1);
      this.queue.removeChild(this.queue.children[index]);
    }
  }
}