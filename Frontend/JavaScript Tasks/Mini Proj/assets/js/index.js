// !clear localstorge & session
localStorage.clear();
sessionStorage.clear();

// !global var
let DATA = [];
const PARENT = document.getElementById("row");
// ?search???????????
const SEARCH_INPUT = document.getElementById("inputSearch");
const SEARCH_BTN = document.getElementById("btn")
// ?clear???????????
const CLEAR_BTN = document.getElementById("clear");
// ?slider????????????
const SLIDER_ITEM = document.getElementById("slider-item");
const NEXT = document.getElementById("next");
const PREV = document.getElementById("prev");

// TODO:handle localstorge:::::::::::::::::::::::::::::
// !fetch data!!!!!!!!!!!!!!!!!!!!!!!
const GET_DATA = async () => {
  try {
    const REQUEST = await fetch(`https://jsonplaceholder.typicode.com/users`);
    const RESPONSE = await REQUEST.json();

    return RESPONSE;

  } catch (error) {
    alert(error);
  }
}

// !localstorge!!!!!!!!!!!!!!!!!!!!!!
const STORGE = async () => {
  const users = await GET_DATA();
  localStorage.setItem("users", JSON.stringify(users));
  DATA = users;

}


// !check localstorge!!!!!!!!!!!!!!!!
const CHECK = async () => {
  let user = JSON.parse(localStorage.getItem("users"));
  if (user) {
    DATA = user;
  }
  else {
    await STORGE();
    // console.log("fetch from check");
  }
  CARD_DOM(DATA);
  SLIDER_DOM();
}

// TODO:handle session:::::::::::::::::::::::::::::
// !save session
const SESSION = () => {
  let flag = sessionStorage.getItem("isActive") === "true";
  // if (flag) return alert("Session already active");

  sessionStorage.setItem("isActive", true);
  // alert("session started");
}
SESSION();

// TODO:DOM  Card:::::::::::::::::::::::::::::::
const CARD_DOM = (data) => {
  console.log(PARENT);

  PARENT.innerHTML = data.map(user => {
    return `
                  <div class="col-12 col-md-6 col-lg-4">
                    <div class="card">
                        <div class="card-header d-flex justify-content-between align-items-center">
                          <div>
                            <h2 class="fs-4 fw-semibold pt-2">${user.name}</h2>
                            <span class="ms-1 fw-semibold">${user.username}</span>
                          </div>
                          <button class="btn" data-id=${user.id}>Details</button>
                        </div>
                        <div class="card-body">
                            <p class="py-1 px-2"><i class="fa-solid fa-envelope me-2"></i>${user.email}</p>
                            <hr>
                            <p class="py-1 px-2"><i class="fa-solid fa-briefcase me-2"></i>${user.company?.name || "No company"}</p>
                            <hr>
                            <p class="py-1 px-2"><i class="fa-solid fa-location-dot me-2"></i>${user.address?.city || "Empity value"}</p>
                        </div>
                    </div>
                </div>
  `;
  }).join("");
}

// !call!!!!!!!!!!!!!!!!!
CHECK();

// TODO:search:::::::::::::::::::::::::::::::::::::::
// !search!!!!!!!!!!!!!!!!!!!!!!!!!!!!
SEARCH_BTN.addEventListener("click", () => {
  if (!DATA.length) return;

  let resultValue = SEARCH_INPUT.value.toLowerCase().trim();

  localStorage.setItem("lastSearch", resultValue);

  if (resultValue === "") {
    CARD_DOM(DATA);
    return;
  }

  let searchFilter = DATA.filter(user => user.name.toLowerCase().includes(resultValue) ||
    user.username.toLowerCase().includes(resultValue));
  if (!searchFilter.length) alert("NOT Found");
  CARD_DOM(searchFilter);
})

// !clear!!!!!!!!!!!!!!!!!!!!!!!!
CLEAR_BTN.addEventListener("click", () => {
  SEARCH_INPUT.value = "";
})

// !slider!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
let currentIndex = 0;

const SLIDER_DOM = () => {
  if (!DATA.length) return;
  if (currentIndex >= DATA.length) currentIndex = 0;
  if (currentIndex < 0) currentIndex = DATA.length - 1;

  let user = DATA[currentIndex];
  SLIDER_ITEM.innerHTML = `
  <p>${user.name}</p>
  <span>${user.company?.name || "No company Nmae"}</span>
  `;
}

NEXT.addEventListener("click", () => {
  currentIndex++;
  SLIDER_DOM();
})

PREV.addEventListener("click", () => {
  currentIndex--;
  SLIDER_DOM();
})




