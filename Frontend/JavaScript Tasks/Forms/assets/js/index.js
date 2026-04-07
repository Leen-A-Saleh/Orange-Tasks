// !input!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
const F_NAME = document.getElementById("Fname");
const L_NAME = document.getElementById("Lname");
const EMAIL = document.getElementById("email");
const PHONE = document.getElementById("phone");
const PASS = document.getElementById("pass");
const CONFIRM_PASS = document.getElementById("confirmPass");

// !error msg!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
const F_NAME_ERROR = document.getElementById("Fname-error");
const L_NAME_ERROR = document.getElementById("Lname-error");
const EMAIL_ERROR = document.getElementById("email-error");
const PHONE_ERROR = document.getElementById("phone-error");
const PASS_ERROR = document.getElementById("pass-error");
const CONFIRM_PASS_ERROR = document.getElementById("confirmPass-error");


// !Submitted Data!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
const TARGET_FNAME = document.getElementById("targetFname");
const TARGET_LNAME = document.getElementById("targetLname");
const TARGET_EMAIL = document.getElementById("targetEmail");
const TARGET_PHONE = document.getElementById("targetPhone");
const TARGET_PASS = document.getElementById("targetPass");

document.getElementById("form").addEventListener("submit", (e) => {
  e.preventDefault();
  let isValid = true;

  // TODO: reset errors:::::::::::::::::::::::::::::::::::
  F_NAME_ERROR.textContent = "";
  L_NAME_ERROR.textContent = "";
  EMAIL_ERROR.textContent = "";
  PHONE_ERROR.textContent = "";
  PASS_ERROR.textContent = "";
  CONFIRM_PASS_ERROR.textContent = "";

  // TODO: validation (regex)::::::::::::::::::::::::::::::
  // !name!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
  let firstName = [], lastName = [];

  const VALIDATION_NAME = (name, error, target) => {
    error.length = 0;

    if (name.trim() === "") {
      target.textContent = "Required field";
      isValid = false;
      return "";
    }

    if (!/^[A-Za-z\s]+$/.test(name.trim())) {
      error.push("Only letters allowed");
      isValid = false;
    }

    if (name.trim().length < 4) {
      error.push("Must be at least 4 character");
      isValid = false;
    }

    if (error.length > 0) {
      target.innerHTML = error.join(`<br>`);
      isValid = false;
    } else {
      target.textContent = "";
    }
    return name.trim();
  }

  const F_VALUE = VALIDATION_NAME(F_NAME.value, firstName, F_NAME_ERROR);
  const L_VALUE = VALIDATION_NAME(L_NAME.value, lastName, L_NAME_ERROR);

  //!email!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
  const EMAIL_PATTERN = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  if (EMAIL.value.trim() === "") {
    EMAIL_ERROR.textContent = "Required field";
    isValid = false;
  } else if (!EMAIL_PATTERN.test(EMAIL.value.trim())) {
    EMAIL_ERROR.textContent = "Email not valid";
    isValid = false;
  }

  // !phone!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
  const PHONE_PATTERN = /^(079|078|077)\d{7}$/;
  if (PHONE.value.trim() === "") {
    PHONE_ERROR.textContent = "Required field";
    isValid = false;
  } else if (!PHONE_PATTERN.test(PHONE.value.trim())) {
    PHONE_ERROR.textContent = "Invalid Jordanian number";
    isValid = false;
  }

  // !password!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
  let passError = [];
  if (PASS.value.trim() === "") {
    PASS_ERROR.textContent = "Required field";
    isValid = false;
  }

  if (PASS.value.trim().length < 8 || PASS.value.trim().length > 32)
    passError.push("At least 8 characters");

  if (!/[A-Z]/.test(PASS.value.trim())) passError.push("One uppercase letter");

  if (!/\d/.test(PASS.value.trim())) passError.push("One number");

  if (passError.length > 0) {
    PASS_ERROR.innerHTML = passError.join("<br>");
    isValid = false;
  } else {
    var visible = PASS.value.trim().slice(0, 2);
    var hidden = "*".repeat(PASS.value.trim().length - 2);
  }
  // !confirm password!!!!
  if (CONFIRM_PASS.value.trim() === "") {
    CONFIRM_PASS_ERROR.textContent = "Required field";
    isValid = false;
  } else if (CONFIRM_PASS.value.trim() !== PASS.value.trim()) {
    CONFIRM_PASS_ERROR.textContent = "Passwords do not match";
    isValid = false;
  }


  // TODO:submitted name :::::::::::::::::::::::::::::::::::::::
  if (isValid) {
    TARGET_FNAME.textContent = `First Name : ${F_VALUE}`;
    TARGET_LNAME.textContent = `Last Name : ${L_VALUE}`;
    TARGET_EMAIL.textContent = `Email : ${EMAIL.value.trim()}`;
    TARGET_PHONE.textContent = `Phone : ${PHONE.value.trim()}`;
    TARGET_PASS.textContent = `Password : ${visible + hidden}`
  }
});
