var x = "e";
let y = 10;
const z = x + y;

function myFunction() {
  changeText();
}

// function sum(a, b) {
//   return a + b;
// }

let sum = (a, b) => {
  return a + b;
};

function changeText() {
  let element = document.getElementById("text");
  element.innerHTML = "Paragraph changed.";
  element.className = "changed";
}

function changeByClass() {
  let elements = document.getElementsByClassName("someClass");

  for (let i = 0; i < elements.length; i++) {
    elements[i].innerHTML = "Changed by class name.";
  }
}

function createElement() {
  let newEl = document.createElement("Button");
  newEl.innerHTML = "This is a new button.";
  document.body.appendChild(newEl);
}
