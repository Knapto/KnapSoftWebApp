document.addEventListener('DOMContentLoaded', () => {
    const logo = document.getElementById('animated-logo');
    const content = document.getElementById('dashboard-content');
    const loader = document.getElementById('loader');
    const finalLogoContainer = document.getElementById('animated-logo-container');
    const fixedLogo = document.getElementById('animated-logo-fixed');

    const isFirstVisit = !localStorage.getItem('visited');

    if (!logo || !content || !loader) return;

    // Nastavíme loga
    const text1 = "Knap";
    const text2 = "Software";
    const typingSpeed = 100;
    let index = 0;

    if (isFirstVisit) {
        logo.innerHTML = "<span class='knap'></span><span class='soft'></span>";
        const knapSpan = document.querySelector('.knap');
        const softSpan = document.querySelector('.soft');

        knapSpan.style.color = "#ffffff";
        softSpan.style.color = "#FFD700";
        knapSpan.style.fontFamily = "'Poppins', sans-serif";
        softSpan.style.fontFamily = "'Poppins', sans-serif";

        // Spuštění psaní
        function typeText() {
            if (index < text1.length) {
                knapSpan.textContent += text1[index];
            } else if (index < text1.length + text2.length) {
                softSpan.textContent += text2[index - text1.length];
            } else {
                logo.classList.add('flash');
                setTimeout(() => {
                    loader.classList.add('fade-out');
                    setTimeout(() => {
                        loader.style.display = 'none';
                        finalLogoContainer?.classList.remove('d-none');
                        finalLogoContainer?.classList.add('logo-move-animation'); // animace pouze poprvé
                        content.classList.remove('d-none');
                        content.classList.add('fade-in');
                        localStorage.setItem('visited', 'true'); // uložíme návštěvu
                    }, 1000);
                }, 1200);
                return;
            }
            index++;
            setTimeout(typeText, typingSpeed);
        }

        setTimeout(typeText, 300);

    } else {
        // Běžný návrat - bez animace
        loader.style.display = 'none';
        finalLogoContainer?.classList.remove('d-none');
        content.classList.remove('d-none');
        content.classList.add('fade-in');
    }
});
