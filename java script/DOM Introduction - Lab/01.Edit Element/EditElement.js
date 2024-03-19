function editElement(element, match, replaycer) {
    
    while(element.textContent.includes(match)) {
        element.textContent = element.textContent.replace(match, replaycer);
    }
}