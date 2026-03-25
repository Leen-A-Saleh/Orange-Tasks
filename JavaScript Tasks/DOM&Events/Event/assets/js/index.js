// !Task1====================================
const BTN = document.getElementById("btn");
const PARA = document.getElementById("para");
const PVALUE = PARA.textContent;

BTN.addEventListener("click", () => {
  //   BTN.classList.toggle("active");
  //   PARA.classList.toggle("color");
  if (BTN.textContent === "Click") {
    BTN.textContent = "Clicked";
    BTN.classList.add("active");
    PARA.textContent =
      "Just kidding, my mental health can’t handle programming right now, so I'm officially retiring from it.";
    PARA.classList.add("color");
  } else {
    BTN.textContent = "Click";
    BTN.classList.remove("active");
    PARA.textContent = PVALUE;
    PARA.classList.remove("color");
  }
});

// !Task2==================================
const INPUT = document.getElementById("text");
const TARGET = document.getElementById("target");

INPUT.addEventListener("input", (e) => {
  TARGET.textContent = e.target.value;
});

// !Task3===================================
const INPUT3 = document.getElementById("input");
const LIST = document.getElementById("list");
const ADDBTN = document.getElementById("addBtn");

ADDBTN.addEventListener("click", () => {
  if (INPUT3.value === "") return;
  const LI = document.createElement("li");
  const DELETE = document.createElement("button");

  LI.textContent = INPUT3.value;
  DELETE.textContent = "Delete";
  LIST.appendChild(LI);
  LI.appendChild(DELETE);
  DELETE.classList.add("btnJ");

  DELETE.addEventListener("click", (e) => {
    e.target.parentElement.remove();
  });
});

// !Task4============================================
const CARDS = document.getElementById("cards");

CARDS.addEventListener("click", (e) => {
  const CLICKEDCARD = e.target.closest(".card");
  document.querySelectorAll(".card").forEach((e) => {
    e.classList.remove("active");
  });
  CLICKEDCARD.classList.add("active");
});

// !Task5===========================================
const HIDE = document.getElementById("hide");
const PARAHIDE = HIDE.firstElementChild;
const BTNHIDE = HIDE.lastElementChild;

BTNHIDE.addEventListener("click", () => {
  PARAHIDE.classList.toggle("d");
  if (PARAHIDE.classList.contains("d")) {
    BTNHIDE.textContent = "Show";
  } else {
    BTNHIDE.textContent = "Hide";
  }
});

// !Task6=======================================
const PLUS = document.getElementById("plus");
const MINUS = document.getElementById("minus");
const NUMBER = document.getElementById("number");
let counter = 0;

const COLOR = () => {
  if (counter > 0) {
    NUMBER.style.color = "green";
  } else if (counter < 0) {
    NUMBER.style.color = "red";
  } else {
    NUMBER.style.color = "black";
  }
};
PLUS.addEventListener("click", () => {
  counter++;
  NUMBER.textContent = counter;
  COLOR();
});

MINUS.addEventListener("click", () => {
  counter--;
  NUMBER.textContent = counter;
  COLOR();
});
