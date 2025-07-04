// Theme toggle script
(function () {
    const THEME_KEY = 'theme';
    const LIGHT = 'light-theme';
    const DARK = 'dark-theme';

    function setTheme(theme) {
        document.body.classList.remove(LIGHT, DARK);
        document.body.classList.add(theme);
        localStorage.setItem(THEME_KEY, theme);
    }

    function getPreferredTheme() {
        return localStorage.getItem(THEME_KEY) || DARK;
    }

    document.addEventListener('DOMContentLoaded', function () {
        setTheme(getPreferredTheme());
        var btn = document.getElementById('theme-toggle-btn');
        if (btn) {
            btn.addEventListener('click', function () {
                var current = document.body.classList.contains(DARK) ? DARK : LIGHT;
                var next = current === DARK ? LIGHT : DARK;
                setTheme(next);
                btn.innerText = next === DARK ? '🌙' : '☀️';
            });
            // Set correct icon on load
            btn.innerText = getPreferredTheme() === DARK ? '🌙' : '☀️';
        }
    });
})();
