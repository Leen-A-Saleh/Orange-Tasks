// !p1===================
// let res = [];
for (let i = 1; i <= 10; i++) {
  //   res[i] = i;
  if (i == 10) {
    document.querySelector("p").innerHTML += i;
  } else {
    document.querySelector("p").innerHTML += i + " - ";
  }
}
// document.querySelector("p").innerHTML = res.join("-");

// !p2===============
let sum = 0;
for (let i = 0; i <= 30; i++) {
  sum += i;
}
document.querySelector("p").innerHTML = sum;

// !p3================
for (let i = 0; i <= 50; i += 2) {
  document.querySelector("p").innerHTML += i + " ";
}

// !p4===============
for (let i = 10; i > 0; i--) {
  document.querySelector("p").innerHTML += i + " ";
}
// !p5==================
// !p8===================
let c = 1;
for (let i = 5; i > 0; i--) {
  c *= i;
}
document.querySelector("p").innerHTML = c;

// !p9===========================
let fib = [0, 1];
for (let i = 2; i <= 10; i++) {
  fib[i] = fib[i - 1] + fib[i - 2];
  document.querySelector("p").innerHTML = fib.join(" ");
}
// !p10=======================
let s = "Orange Coding School";
let counter = 0;
for (let i = 0; i < s.length; i++) {
  if (s[i] == "C" || s[i] == "c") counter++;
}
document.querySelector("p").innerHTML = counter;

// !p11==============================
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= 5; j++) {
    document.querySelector("p").innerHTML += `${i} * ${j} = ${i * j} &nbsp`;
  }
    document.querySelector("p").innerHTML += `<br>`;
}
// !p13================================
for (let i = 1; i <= 100; i++) {
  if (i % 7 == 0) {
    document.querySelector("p").innerHTML += i + " ";
  } else {
    continue;
  }
}
// !p14=====================
let odd = 0;
for (let i = 1; i <= 100; i += 2) {
  odd += i;
}
document.querySelector("p").innerHTML = odd;
// !p15==============================
for (let i = 1; i <= 10; i++) {
  document.querySelector("p").innerHTML += (i * i) + " ";
}
