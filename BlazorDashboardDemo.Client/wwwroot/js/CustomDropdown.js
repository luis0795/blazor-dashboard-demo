window.showDropdown = (dropdownRef) => {
    const dropdown = dropdownRef.querySelector('.dropdown-list');
    const isVisible = dropdown.style.display === 'block';
    dropdown.style.display = isVisible ? 'none' : 'block';
};

document.addEventListener('click', (event) => {
    const dropdowns = document.querySelectorAll('.custom-dropdown .dropdown-list');
    dropdowns.forEach(dropdown => {
        if (!dropdown.parentElement.contains(event.target)) {
            dropdown.style.display = 'none';
        }
    });
});