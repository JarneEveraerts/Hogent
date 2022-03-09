// const helloWorld = (name,firstName) => {

//     let istrue = true
//     let number = 10
//     number === 10 ? console.log("Onze nummer is gelijk aan 10") :console.log("onze nummer is niet gelijk aan 10")
//     console.log(`Hello world ${name.toUpperCase()} ${name.toUpperCase()}`);
//     const person = {
//         firstName: "jarne",
//         lastName: "Everaerts",
//         age : 22,
//         adress: {
//             street: "arbeidstraat",
//             number: 14
//         },
//         likes: ["web2","programm"],
//         name: function(){
//             return this.firstName+this.lastName
//         },
//         getName: () => {
//             return firstName + lastName
//         }
//     }
//     console.log(person.getName())
// };

// helloWorld("everaerts","jarne");

const setup = () => {
    const par = document.getElementById("paragraph1")
par.textContent = "hello bitch"
console.log(par)

const headings = document.getElementsByClassName("headings")
console.log(headings)
for (let index = 0; index < headings.length; index++) {
    headings[index].textContent="penis"
    console.log(headings[index].textContent);
    
}
const alleParagrafen = document.getElementsByTagName("p")
console.log(alleParagrafen)

const par2 = document.getElementById("testTxtContent")
console.log(par2.textContent)
par2.innerHTML = '<a href="google.com"> google</a>'
console.log(par2.innerHTML)

// par2.textContent = "gewijzigd javascript"

}
window.addEventListener("load",setup)