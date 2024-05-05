document.addEventListener("DOMContentLoaded", function() {
    const toggleSidebar = document.querySelector('.toggleSidebar');
    const closeButton = document.querySelector('.closeSidebar');
    const sidebar = document.querySelector('.sidebar');
    const toggleTopMenu = document.querySelector('.toggleTopMenu');
    const topMenu = document.querySelector('.navbar-top');
    const mainContent = document.querySelector('main');

    toggleSidebar.addEventListener('click', function() {
        sidebar.classList.toggle('open');
        mainContent.classList.toggle('sidebar-open'); // Ajuste adicional
    });

    closeButton.addEventListener('click', function() {
        sidebar.classList.remove('open');
        mainContent.classList.remove('sidebar-open'); // Ajuste adicional
    });

    toggleTopMenu.addEventListener('click', function() {
        sidebar.classList.toggle('open');
        mainContent.classList.toggle('sidebar-open'); // Ajuste adicional
        topMenu.classList.toggle('sidebar-open'); // Ajuste adicional
    });
});
