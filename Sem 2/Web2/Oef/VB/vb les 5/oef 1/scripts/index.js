
const setup = () =>{
    const inputEl = document.getElementById("text");
    inputEl.value ="jarne"
    console.log(inputEl.value)
}
const kopieer = () =>{
    const inputEl = document.getElementById("text");
    console.log(inputEl.value)
}
window.addEventListener("load",setup);
let btnKopieer = document.getElementById("btn")
btnKopieer.addEventListener("click",kopieer)
