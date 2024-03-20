function colorize() {
    // TODO
    const evenRowsElement = document.querySelectorAll('tr:nth-child(even)');

    for (const row of evenRowsElement) {
        row.style.background = 'teal';
    }
}