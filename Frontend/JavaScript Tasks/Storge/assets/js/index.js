// !task1 & Task2 & Task3===================
const PARENT = document.getElementById("parent");
const NAME   = document.getElementById("name");
const EMAIL  = document.getElementById("email");
const SEARCH = document.getElementById("search");
const CARD   = document.getElementById("card");

// localStorage.clear();


const DISPLAY = (data) => {
  CARD.innerHTML = data
    .map(
      (e) => `
      <div class="d-flex justify-content-between border p-2 mt-2">
        <span>${e.name} - ${e.email}</span>
        <button class="btn btn-danger" data-email="${e.email}">Delete</button>
      </div>`
    )
    .join("");
};

PARENT.addEventListener("click", (e) => {
  if (e.target.id === "btn") {
    if (NAME.value.trim() === "" || EMAIL.value.trim() === "") {
      alert("Invalid value");
      return;
    }
    const DATA = JSON.parse(localStorage.getItem("user")) || [];
    DATA.push({ name: NAME.value.trim(), email: EMAIL.value.trim() });
    localStorage.setItem("user", JSON.stringify(DATA));
    DISPLAY(DATA);
    NAME.value = "";
    EMAIL.value = "";
  }

  if (e.target.classList.contains("btn-danger")) {
    const email = e.target.dataset.email;
    let DATA = JSON.parse(localStorage.getItem("user")) || [];
    DATA = DATA.filter((u) => u.email !== email);
    localStorage.setItem("user", JSON.stringify(DATA));
    const query = SEARCH.value.trim().toLowerCase();
    DISPLAY(query ? DATA.filter(u =>
      u.name.toLowerCase().includes(query) ||
      u.email.toLowerCase().includes(query)
    ) : DATA);
  }
});

SEARCH.addEventListener("input", () => {
  const query = SEARCH.value.trim().toLowerCase();
  const DATA  = JSON.parse(localStorage.getItem("user")) || [];
  DISPLAY(DATA.filter(u =>
    u.name.toLowerCase().includes(query) ||
    u.email.toLowerCase().includes(query)
  ));
});

DISPLAY(JSON.parse(localStorage.getItem("user")) || []);


window.addEventListener("DOMContentLoaded", () => {
  const DATA = JSON.parse(localStorage.getItem("user")) || [];
  DISPLAY(DATA);
});




