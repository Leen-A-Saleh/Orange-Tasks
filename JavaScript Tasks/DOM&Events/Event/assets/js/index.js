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

INPUT.addEventListener("input",(e)=>{
    TARGET.textContent = e.target.value;})

