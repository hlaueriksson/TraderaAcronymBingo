window.fireworks = () => {
    // https://github.com/catdad/canvas-confetti
    var duration = 15 * 1000;
    var animationEnd = Date.now() + duration;
    var defaults = { startVelocity: 30, spread: 360, ticks: 60, zIndex: 0 };

    function randomInRange(min, max) {
        return Math.random() * (max - min) + min;
    }

    var interval = setInterval(function () {
        var timeLeft = animationEnd - Date.now();

        if (timeLeft <= 0) {
            return clearInterval(interval);
        }

        var particleCount = 50 * (timeLeft / duration);
        // since particles fall down, start a bit higher than random
        confetti(Object.assign({}, defaults, { particleCount, origin: { x: randomInRange(0.1, 0.3), y: Math.random() - 0.2 } }));
        confetti(Object.assign({}, defaults, { particleCount, origin: { x: randomInRange(0.7, 0.9), y: Math.random() - 0.2 } }));
    }, 250);
};

window.bingo = () => {
    // https://www.epidemicsound.com/track/U2FA2J8h8r/
    new Audio('https://dkihjuum4jcjr.cloudfront.net/ES_ITUNES/Voice%20Clip%20Male%208/ES_Voice%20Clip%20Male%208.mp3').play();
};
