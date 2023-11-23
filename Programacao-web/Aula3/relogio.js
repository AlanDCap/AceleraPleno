let timer = null;
let started = false;
var intervalId = null;

function clock() {
    function timer() {
        const today = new Date();
        const hours = today.getHours() < 10 ? "0" + today.getHours() : today.getHours(),
        minutes = today.getMinutes() < 10 ? "0" + today.getMinutes() : today.getMinutes(),
        seconds = today.getSeconds() < 10 ? "0" + today.getSeconds() : today.getSeconds();
        return `${hours}:${minutes}:${seconds}:`;
    }
    intervalId =  setInterval(function() {
        document.getElementById('relogio').textContent = timer();
    },1000 );
    return intervalId;
}

function start() {
    if (!started) {
        timer = clock();
        started = true;
    }
}

function stop() {
    document.getElementById('relogio').textContent = clearInterval(intervalId);
    started = false;
}