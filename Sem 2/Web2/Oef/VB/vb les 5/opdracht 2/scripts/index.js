
const setup = () =>{
    const pElements = document.getElementsByClassName("belangrijk");
    for (let index = 0; index < pElements.length; index++) {
        const element = pElements[index];
        element.classList.add("opvallend");
    }
    
}

window.addEventListener("load",setup);

