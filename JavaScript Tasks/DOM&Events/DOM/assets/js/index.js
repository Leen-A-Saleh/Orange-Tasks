// !Bonus !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//*Table************************************
let tableData = [
  {
    id: 1,
    name: "Leen",
    email: "leen@gmail.com",
  },
  {
    id: 2,
    name: "Haneen",
    email: "Haneen@gmail.com",
  },
  {
    id: 3,
    name: "Aya",
    email: "Aya@gmail.com",
  },
];

const TBODY = document.getElementById("tbody");
// ???????????? innerHTML??????????????????
// tableData.forEach((e) => {
//   TBODY.innerHTML += `
//   <tr>
//   <td class="fw-bold">${e.id}</td>
//   <td>${e.name}</td>
//   <td>${e.email}</td>
//   </tr>
//   `;
// });

// ??????????? create ????????????????????
tableData.forEach((e) => {
  const TR = document.createElement("tr");
  const TDID = document.createElement("td");
  const TDNAME = document.createElement("td");
  const TDEMAIL = document.createElement("td");

  TDID.textContent = e.id;
  TDNAME.textContent = e.name;
  TDEMAIL.textContent = e.email;

  TR.appendChild(TDID);
  TR.appendChild(TDNAME);
  TR.appendChild(TDEMAIL);

  TDID.style = "font-weight:900";
  TBODY.appendChild(TR);
});

// !Part1=================================
const PARENT = document.getElementById("info");
const PARA = document.getElementById("target");
console.log(PARENT.children);
console.log(PARENT.firstElementChild);
console.log(PARENT.lastElementChild);
// console.log(PARA.nextElementSibling);
// console.log(PARA.previousElementSibling);
console.log([...PARENT.children].filter((e) => e !== PARA));

// !Part2===================================
// data
let data = {
  title: "Orange Logo",
  description: "crad from javascript",
  Image: "https://upload.wikimedia.org/wikipedia/commons/c/c8/Orange_logo.svg",
};

const HEADER = document.getElementById("header");
// create
const CARD = document.createElement("div");
const TITLE = document.createElement("h2");
const DESC = document.createElement("p");
const IMG = document.createElement("img");

TITLE.textContent = data.title;
DESC.textContent = data.description;
IMG.src = data.Image;
IMG.alt = data.title;

CARD.appendChild(TITLE);
CARD.appendChild(IMG);
CARD.appendChild(DESC);

CARD.classList.add("card");

HEADER.appendChild(CARD);

// !part3=============================================
const LIST = document.getElementById("list");
console.log(LIST.firstElementChild);
console.log(LIST.lastElementChild);
console.log(LIST.firstElementChild.nextElementSibling);
console.log(LIST.lastElementChild.previousElementSibling);

// !part4======================================
const OLDITEM = LIST.firstElementChild;
const NEWITEM = document.createElement("li");

NEWITEM.textContent = "new item 1-js";
LIST.replaceChild(NEWITEM, OLDITEM);

LIST.lastElementChild.textContent = "Update last child";
