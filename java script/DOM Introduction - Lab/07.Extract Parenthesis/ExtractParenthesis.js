function extract(content) {

    const elementToSearch = document.getElementById(content);
    const matches = elementToSearch.textContent.matchAll(/\(([^)]+)\)/g) ;

    const result = Array
        .from(matches)
        .map(match => match[1])
        .join('; ');
    
    return result;
}