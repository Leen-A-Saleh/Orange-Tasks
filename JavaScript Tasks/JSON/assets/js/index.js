// !elements===============================
const ROW = document.getElementById("row");
const SEARCH = document.getElementById("search");
const BTN = document.getElementById("btn");
let users = [];
const GET_USERS = async () => {
  // !try/catch API
  try {
    const REQUEST = await fetch(`https://api.github.com/users`);
    const RESPONSE = await REQUEST.json();

    users  = RESPONSE.slice(0, 8);
    ROW.innerHTML = RENDER_DATA(users);

  } catch (error) {
    console.log(error);
  }
}

// !get data
const RENDER_DATA = (response) => {
  let res = ``;

  response.forEach(user => {
    res += `
      <div class=" col-12 col-md-4 col-lg-3">
                        <div class="card text-center py-3 px-2">
                            <div class="img m-auto mb-2">
                                <img src="${user.avatar_url}" alt="${user.login}">
                            </div>
                            <h2>${user.login}</h2>
                            <a class="link text-decoration-none" href="${user.html_url}" target="_blank"><i
                                    class="fa-solid fa-arrow-up-right-from-square fs-6 me-1"></i>View Profile</a>
                        </div>
                    </div>
      `
  });

  return res;
}

// !search========
SEARCH.addEventListener("input", (e) => {
  const VALUE = e.target.value.toLowerCase().trim();
  const FILTER = users.filter(e => e.login.toLowerCase().includes(VALUE));
  ROW.innerHTML = RENDER_DATA(FILTER);
})

// !call function
GET_USERS();


