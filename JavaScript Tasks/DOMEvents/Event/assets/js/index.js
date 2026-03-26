// !Task1====================================
// TODO:delegation overkillllll
const BTN = document.getElementById("btn");
const PARA = document.getElementById("para");
const PVALUE = PARA.textContent;

BTN.addEventListener("click", (e) => {
  if (e.target.id !== "btn") return;

  const ISACTIVE = e.target.classList.toggle("active");
  e.target.textContent = ISACTIVE ? "Clicked" : "Click";
  PARA.textContent = ISACTIVE
    ? "Just kidding, my mental health can’t handle programming right now..."
    : PVALUE;
});

// !Task2==================================
const INPUT = document.getElementById("text");
const TARGET = document.getElementById("target");

// ?input : live typing
INPUT.addEventListener("input", (e) => {
  TARGET.textContent = e.target.value;
  TARGET.classList.toggle("color");
});

// ?after end typing add text
// INPUT.addEventListener("change", (e) => {
//   TARGET.textContent = e.target.value;
//   TARGET.classList.toggle("color");
// });

// !Task3===================================
// TODO: delegation!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
const DELEGATION = document.getElementById("delegation");
const INPUT3 = document.getElementById("input");
const LIST = document.getElementById("list");

DELEGATION.addEventListener("click", (e) => {
  if (e.target.id === "addBtn") {
    if (INPUT3.value === "") return;

    const LI = document.createElement("li");
    const DELETE = document.createElement("button");

    LI.textContent = INPUT3.value;
    DELETE.textContent = "Delete";
    DELETE.classList.add("btnJ");

    LI.appendChild(DELETE);
    LIST.appendChild(LI);
  }
  if (e.target.classList.contains("btnJ")) {
    e.target.closest("li").remove();
  }
});

// TODO:Not delegation code !!!!!!!!!!!!!!!!!!!!!!
// const INPUT3 = document.getElementById("input");
// const LIST = document.getElementById("list");
// const ADDBTN = document.getElementById("addBtn");

// ADDBTN.addEventListener("click", () => {
//   if (INPUT3.value === "") return;
//   const LI = document.createElement("li");
//   const DELETE = document.createElement("button");

//   LI.textContent = INPUT3.value;
//   DELETE.textContent = "Delete";
//   LIST.appendChild(LI);
//   LI.appendChild(DELETE);
//   DELETE.classList.add("btnJ");

//   DELETE.addEventListener("click", (e) => {
//     e.target.parentElement.remove();
//   });
// });

// !Task4============================================
// *delagation*********************
const CARDS = document.getElementById("cards"); //curent target

CARDS.addEventListener("click", (e) => {
  const CLICKEDCARD = e.target.closest(".card");
  document
    .querySelectorAll(".card")
    .forEach((e) => e.classList.remove("active"));

  CLICKEDCARD.classList.add("active");
});

// !Task5 & Task3 (next5) ===========================================
const HIDE = document.getElementById("hide");
// *Traversing**************************
const PARAHIDE = HIDE.firstElementChild;
const BTNHIDE = HIDE.lastElementChild;

BTNHIDE.addEventListener("click", () => {
  const ISHIDDEN = PARAHIDE.classList.toggle("d-none");
  BTNHIDE.textContent = ISHIDDEN ? "Show" : "Hide";
});

// !Task6=======================================
const PLUS = document.getElementById("plus");
const MINUS = document.getElementById("minus");
const NUMBER = document.getElementById("number");

const UPDATECOUNTER = () => {
  // ?clouser??
  let counter = 0;
  return (value) => {
    counter += value;
    NUMBER.textContent = counter;

    NUMBER.classList.remove("positive", "negative", "zero");
    if (counter > 0) NUMBER.classList.add("postive");
    else if (counter < 0) NUMBER.classList.add("negative");
    else NUMBER.classList.add("zero");
  };
};
const UPDATE = UPDATECOUNTER();
PLUS.addEventListener("click", () => UPDATE(1));
MINUS.addEventListener("click", () => UPDATE(-1));

// TODO:DRY::::::::::::::::::::::::::::::::::
// const COLOR = () => {
//   if (counter > 0) {
//     NUMBER.style.color = "green";
//   } else if (counter < 0) {
//     NUMBER.style.color = "red";
//   } else {
//     NUMBER.style.color = "black";
//   }
// };

// PLUS.addEventListener("click", () => {
//   counter++;
//   NUMBER.textContent = counter;
//   COLOR();
// });

// MINUS.addEventListener("click", () => {
//   counter--;
//   NUMBER.textContent = counter;
//   COLOR();
// });

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
  palestine:
    "https://upload.wikimedia.org/wikipedia/commons/0/00/Flag_of_Palestine.svg",
  Jordan:
    "https://upload.wikimedia.org/wikipedia/commons/c/c0/Flag_of_Jordan.svg",
  kuwait:
    "https://upload.wikimedia.org/wikipedia/commons/a/aa/Flag_of_Kuwait.svg",
};

SELECT.addEventListener("change", () => {
  if (SELECT.value === "") {
    FLAG.src = "";
    return;
  }
  FLAG.src = flages[SELECT.value];
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
