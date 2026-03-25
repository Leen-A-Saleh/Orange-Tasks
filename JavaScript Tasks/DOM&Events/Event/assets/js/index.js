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

// !Task5 & Task3 (next5) ===========================================
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

// TODO::::::::::::::::::::::::::::::::::::::::::::::::
// !Task1==============================================
const BOX = document.getElementById("box");

BOX.addEventListener("mouseenter", () => {
  BOX.classList.add("hover");
});

BOX.addEventListener("mouseleave", () => {
  BOX.classList.remove("hover");
});

// !Task2=============================================
const SELECT = document.getElementById("select");
const FLAG = document.getElementById("flag");
let flages = {
  Palestine:
    "https://upload.wikimedia.org/wikipedia/commons/0/00/Flag_of_Palestine.svg",
  Jordan:
    "https://upload.wikimedia.org/wikipedia/commons/c/c0/Flag_of_Jordan.svg",
  Kuwait:
    "https://upload.wikimedia.org/wikipedia/commons/a/aa/Flag_of_Kuwait.svg",
};

SELECT.addEventListener("change", () => {
  let country = SELECT.value;
  FLAG.src = flages[country];
});

// !Task4 & Task5============================================
const TEXTAREA = document.getElementById("textarea");

const FONTFAMILY = document.getElementById("fontSelect");
const FONTSIZE = document.getElementById("sizeSelect");

const ITALIC = document.getElementById("Italic");
const BOLD = document.getElementById("Bold");
const UNDERLINE = document.getElementById("Undeline");

// font family
FONTFAMILY.addEventListener("change", () => {
  TEXTAREA.style.fontFamily = FONTFAMILY.value;
});

// font size
FONTSIZE.addEventListener("change", () => {
  TEXTAREA.style.fontSize = FONTSIZE.value;
});

// font style
ITALIC.addEventListener("change", () => {
  TEXTAREA.style.fontStyle = ITALIC.checked ? "italic" : "normal";
});

BOLD.addEventListener("change", () => {
  TEXTAREA.style.fontWeight = BOLD.checked ? "bold" : "normal";
});

UNDERLINE.addEventListener("change", () => {
  TEXTAREA.style.textDecoration = UNDERLINE.checked ? "underline" : "none";
});

// ?animation?????????
setInterval(() => {
  TEXTAREA.classList.toggle("active");
}, 1000);
