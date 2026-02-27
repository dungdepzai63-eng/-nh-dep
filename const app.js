const { app, BrowserWindow } = require("electron");
const path = require("path");

function createWindow() {
    const win = new BrowserWindow({
        width: 1100,
        height: 700,
        frame: false,
        webPreferences: {
            nodeIntegration: true,
            contextIsolation: false
        }
    });

    win.loadFile("client/login.html");
}

app.whenReady().then(createWindow);
function login() {
    let user = document.getElementById("username").value;
    let pass = document.getElementById("password").value;

    if(user === "admin" && pass === "123456"){
        window.location.href = "index.html";
    } else {
        alert("Sai tài khoản!");
    }
}
 function updateGame(){
    let bar = document.getElementById("bar");
    let status = document.getElementById("status");
    let width = 0;

    status.innerText = "Updating...";

    let interval = setInterval(() => {
        if(width >= 100){
            clearInterval(interval);
            status.innerText = "Update Complete!";
        } else {
            width++;
            bar.style.width = width + "%";
        }
    }, 30);
}

function playGame(){
    alert("Launching GTA RP...");
}
  