// Your JavaScript code here
console.log('Hello, World!');
function updateGame() {
    let progress = document.getElementById("progress");
    let status = document.getElementById("status");
    let width = 0;

    status.innerText = "Đang cập nhật...";

    let interval = setInterval(function () {
        if (width >= 100) {
            clearInterval(interval);
            status.innerText = "Cập nhật hoàn tất!";
        } else {
            width++;
            progress.style.width = width + "%";
        }
    }, 40);
}

function playGame() {
    alert("Đang mở game...");
    window.location.href = "game.exe"; // đổi thành file game thật
}

function openSettings() {
    alert("Settings sẽ mở ở đây!");
}