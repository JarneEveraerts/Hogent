
const setup = () =>{
    console.log("dom active")
    let btnCss = document.getElementById("div")
    const kopieer = () =>{
        console.log("klik")
    }
    const bgChange =() =>{
        const rndCol = "red";
        return rndCol;
    }

    const color = document.getElementById("div");
    color.addEventListener("click", event => {
        event.target.style.backgroundColor = bgChange();
    })
    btnCss.addEventListener("click",kopieer)

}

window.addEventListener("load",setup);

