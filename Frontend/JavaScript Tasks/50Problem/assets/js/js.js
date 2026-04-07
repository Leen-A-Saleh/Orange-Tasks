// !p1===================
let res = [];
for (let i = 1; i <= 10; i++) res.push(i);
document.querySelector("p").innerHTML = res.join("-");

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
let pp = "";
let char = "A";
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= 5; j++) {
    if (j <= 5 - i) {
      pp += char + " ";
    } else {
      pp += String.fromCharCode(char.charCodeAt(char) + (i - 1)) + " ";
    }
  }
  pp += `<br>`;
}
document.querySelector("p").innerHTML = pp;
// !p6==================
let p = "";
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= 5; j++) {
    if (j <= 5 - i) {
      p += 1 + " ";
    } else {
      p += i + " ";
    }
  }
  p += `<br>`;
}
document.querySelector("p").innerHTML = p;

// !p7==================
for (let i = 1; i <= 5; i++) {
  for (j = 1; j <= 5; j++) {
    if (i == j) document.querySelector("p").innerHTML += i + " ";
    else document.querySelector("p").innerHTML += 0 + " ";
  }
  document.querySelector("p").innerHTML += `<br>`;
}

// !p8===================
let c = 1;
for (let i = 1; i <= 5; i++) {
  c *= i;
}
document.querySelector("p").innerHTML = c;

// ?P8?????????????????????????????
let x = Number(prompt());
let y = 1;
function fac(n) {
  for (let i = 1; i <= x; i++) y *= i;
  return y;
}
console.log(fac(x));

// !p9===========================
let fib = [0, 1];
for (let i = 2; i <= 10; i++) {
  fib[i] = fib[i - 1] + fib[i - 2];
  document.querySelector("p").innerHTML = fib.join(" ");
}
// !p10=======================
let s = "Orange Coding School";
let counter = s.split("").filter((c) => c.toLowerCase() === "c").length;
// let counter = 0;
// for (let i = 0; i < s.length; i++) {
//   if (s[i] == "C" || s[i] == "c") counter++;
// }
document.querySelector("p").innerHTML = counter;

// !p11==============================
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= 5; j++) {
    document.querySelector("p").innerHTML += `${i} * ${j} = ${i * j} &nbsp`;
  }
  document.querySelector("p").innerHTML += `<br>`;
}
// !p12==================
// let t = "";
// let arr = [5][5];
// arr[1][1]=1;
// for (let i = 2; i <= 5; i++) {
//   for (let j = 2; j <= i; j++) {
//     arr[i][j]=arr[i]
//   }
//   t += `<br>`;
// }
// document.querySelector("p").innerHTML = t;

let t = "",
  o = 1;
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= i; j++) {
    t += o + " ";
    o++;
  }
  t += `<br>`;
}
document.querySelector("p").innerHTML = t;
// !p13================================
for (let i = 1; i <= 100; i += 7)
  document.querySelector("p").innerHTML += i + " ";
// ?P13????????????????????????????
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
  document.querySelector("p").innerHTML += i * i + " ";
}
// ?P15????????????????????????
for (let i = 1; i <= 10; i++) {
  document.querySelector("p").innerHTML += Math.pow(i, 2) + " ";
}

// !p16============================
for (let i = 1; i <= 30; i++) {
  if (i % 3 === 0 && i % 5 === 0) {
    document.querySelector("p").innerHTML += "FiZZBuzz ";
  } else if (i % 3 === 0) {
    document.querySelector("p").innerHTML += "FiZZ ";
  } else if (i % 5 === 0) {
    document.querySelector("p").innerHTML += "BuZZ ";
  } else {
    document.querySelector("p").innerHTML += i + " ";
  }
}

// !p17================================
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= i; j++) {
    document.querySelector("p").innerHTML += `*`;
  }
  document.querySelector("p").innerHTML += `<br>`;
}

// !p18===============================
for (let i = 1; i <= 5; i++) {
  for (let j = 5; j >= i; j--) {
    document.querySelector("p").innerHTML += `*`;
  }
  document.querySelector("p").innerHTML += `<br>`;
}
// !p19==============================
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= i; j++) {
    document.querySelector("p").innerHTML += j + "";
  }
  document.querySelector("p").innerHTML += `<br>`;
}

// !p20==========================
for (let i = 1; i <= 5; i++) {
  for (let j = 1; j <= i; j++) {
    document.querySelector("p").innerHTML += i + " ";
  }
  document.querySelector("p").innerHTML += `<br>`;
}

// !p21===============
let xx = "";
for (let i = 10; i <= 200; i++) {
  let n = i;
  let y = 0;
  while (n > 0) {
    y += n % 10;
    n = Math.trunc(n / 10);
  }
  if (y === 5) xx += i + " ";
}
document.querySelector("p").innerHTML = xx;

// !p22=====================
for (let i = 1; i <= 100; i++) {
  if (i % 10 < Math.trunc(i / 10))
    document.querySelector("p").innerHTML += i + " ";
}

// !p23====================
for (let i = 10; i <= 100; i++) {
  //   if (i < 10) continue;
  if (i % 10 === Math.trunc(i / 10)) console.log(i);
}
// ?STRING p23???????????????????????????????
for (let i = 1; i <= 100; i++) {
  let s = i.toString();
  if (s.length == 1) continue;
  else {
    let f = Number(s[0]);
    let l = Number(s[s.length - 1]);
    if (f === l) document.querySelector("p").innerHTML += i + " ";
  }
}
// !p24=====================
for (let i = 10; i <= 300; i++) {
  let n = i;
  let d = 1;
  while (n > 0) {
    d *= n % 10;
    n = Math.trunc(n / 10);
  }
  if (i % d === 0 && d !== 0) document.querySelector("p").innerHTML += i + "  ";
}

// !P25=====================
for (let i = 1; i <= 100; i++) {
  if ((Math.trunc(i / 10) * i) % 10 === Math.trunc(i / 10) + (i % 10))
    document.querySelector("p").innerHTML += i + " ";
}

// !P26=========================
for (let i = 1; i <= 500; i++) {
  if (i % 3 !== 0 && i < 10) {
    continue;
  } else {
    let s = i.toString();
    s = s.split("").reverse().join("");
    document.querySelector("P").innerHTML += s + " ";
  }
}
// for (let i = 1; i <= 500; i++) {
//   if (i % 3 !== 0 || i < 10) continue;
//   else {
//     let n = i;
//     let rev = 0;
//     while (n > 0) {
//       rev = rev * 10 + (n % 10);
//       n = Math.trunc(n / 10);
//     }
//   }
// }

// !P27========================
let v = "";
function diff(i) {
  //10 100
  let f = i % 10,
    s = Math.trunc(i / 10) % 10;
  if (i < 100) {
    if (Math.abs(f - s) == 2) v += i + " ";
  } else {
    let th = Math.trunc(i / 100);
    if (Math.abs(f - s) === 2 || Math.abs(s - th) === 2) v += i + " ";
  }
}
for (let i = 10; i <= 200; i++) {
  diff(i);
}
document.querySelector("p").innerHTML = v;

// !p28==================
let w = "";
function asc(i) {
  let f = Math.trunc(i / 10) % 10,
    s = i % 10;
  if (i < 100) {
    if (f - s == -1) w += i + " ";
  } else {
    let th = Math.trunc(i / 100);
    if (f - s === -1 || s - th === -1) w += i + " ";
  }
}
for (let i = 10; i <= 500; i++) {
  asc(i);
}
document.querySelector("p").innerHTML = w;
// !p29==================
let vw = "";
function desc(i) {
  let f = Math.trunc(i / 10) % 10,
    s = i % 10;
  if (i < 100) {
    if (f - s == 1) vw += i + " ";
  } else {
    let th = Math.trunc(i / 100);
    if (f - s === 1 || s - th === 1) vw += i + " ";
  }
}
for (let i = 10; i <= 500; i++) {
  desc(i);
}
document.querySelector("p").innerHTML = vw;

// !P30====================
//134     134%10=4 134/10=13
for (let i = 100; i <= 300; i++) {
  if (i % 10 === (Math.trunc(i / 10) % 10) + Math.trunc(i / 100))
    document.querySelector("p").innerHTML += i + " ";
}

// !P31======================
let l = "";
function sumDigit(n) {
  let s = 0;
  while (n > 0) {
    s += n % 10;
    n = Math.trunc(n / 10);
  }
  return s > 10;
}
for (let i = 10; i <= 200; i++) {
  if (sumDigit(i)) l += i + " ";
}
document.querySelector("p").innerHTML = l;

// !P32=========================
let ll = "";
function sumDigit(n) {
  let s = 0;
  while (n > 0) {
    s += n % 10;
    n = Math.trunc(n / 10);
  }
  return s;
}

function prime(s) {
  let c = 0;
  for (let i = 1; i <= s; i++) if (s % i === 0) c++;
  return c == 2;
}

for (let i = 10; i <= 500; i++) {
  if (prime(sumDigit(i))) ll += i + " ";
}
document.querySelector("p").innerHTML = ll;

// !P33========================
let g = "";
for (let i = 10; i <= 300; i++) {
  //10 100
  if (i < 100) {
    if (i % 10 === Math.trunc(i / 10)) g += i + " ";
  } else {
    let f = i % 10,
      s = Math.trunc(i / 10) % 10,
      th = Math.trunc(i / 100);
    if (f === s || f === th || s === th) g += i + " ";
  }
}
document.querySelector("p").innerHTML = g;

// !P34=======================
let m = "";
for (let i = 10; i <= 200; i++) {
  let rev = Number(i.toString().split("").reverse().join(""));
  if (rev > i) m += i + " ";
}
document.querySelector("p").innerHTML = m;
// !P35=====================
let p = "";
for (let i = 10; i <= 500; i++) {
  let d = 1,
    n = i;
  while (n > 0) {
    d *= n % 10;
    n = Math.trunc(n / 10);
  }
  if (d % 5 === 0) p += i + " ";
}
document.querySelector("p").innerHTML = p;
// !P36====================
let pp = "";
for (let i = 1; i <= 300; i++) {
  let s = 0,
    c = 0;
  n = i;
  while (n > 0) {
    s += n % 10;
    c++;
    n = Math.trunc(n / 10);
  }
  if (s === c * 5) pp += i + " ";
}
document.querySelector("p").innerHTML = pp;
// !P37=======================
let h = "";
function isEven(i) {
  let f = Number(i.toString()[0]);
  if (f % 2 == 0) h += i + " ";
}
for (let i = 1; i <= 500; i++) isEven(i);
document.querySelector("p").innerHTML = h;

// !P38=====================
let hh = "";
function square(i) {
  i = i.toString();
  let f = Number(i[0]),
    l = Number(i[i.length - 1]);
  l *= l;

  if (f === l) hh += i + " ";
}
for (let i = 10; i <= 300; i++) square(i);
document.querySelector("p").innerHTML = hh;

// !P39=====================
let r = "";
function divisible(n) {
  let n = i,
    s = 0,
    c = 0;
  while (n > 0) {
    s += n % 10;
    c++;
    n = Math.trunc(n / 10);
  }
  if (s % c === 0) r += i + " ";
}
for (let i = 10; i <= 500; i++) {
  divisible(i);
}
document.querySelector("p").innerHTML = r;
// !P40==========================
let rr = "";
function sum(i) {
  let n = i,
    s = 0;
  while (n > 0) {
    s += n % 10;
    n = Math.trunc(n / 10);
  }
  if (s === 15) rr += i + " ";
}

for (let i = 10; i <= 1000; i++) {
  sum(i);
}
document.querySelector("p").innerHTML = rr;
// !P41====================
let a = "";
for (let i = 10; i <= 1000; i++) {
  let n = i,
    s = 0,
    d = 1;
  while (n > 0) {
    s += n % 10;
    d *= n % 10;
    n = Math.trunc(n / 10);
  }
  if (s === d) a += i + " ";
}
document.querySelector("p").innerHTML = a;

// !P42======================
let b = "";
for (let i = 10; i <= 1000; i++) {
  let rev = i.toString();
  rev = Number(rev.split("").reverse().join(""));
  if (rev === i + 9) b += i + " ";
}
document.querySelector("p").innerHTML = b;

// !P43======================
let e = "";
for (let i = 10; i <= 1000; i++) {
  let sq = i * i;
  if (sq.toString().endsWith(i.toString())) e += i + " ";
}
document.querySelector("p").innerHTML = e;

// !P44=======================
let s1s = "";
for (let i = 1; i <= 1000; i++) {
  let rev = i.toString();
  rev = Number(rev.split("").reverse().join(""));
  if (Math.abs(i - rev) % 9 == 0) s1s += i + " ";
}
document.querySelector("p").innerHTML = s1s;

// !45============================
let ss = "";
for (let i = 1; i <= 1000; i++) {
  let c = 0;
  let s = 0;
  let n = i;
  while (n > 0) {
    s += n % 10;
    n = Math.trunc(n / 10);
    c++;
  }
  if (s === c) ss += i + " ";
}
document.querySelector("p").innerHTML = ss;
// !46=====================
let rss = "";
for (let i = 1; i <= 1000; i++) {
  let n = i;
  let s = 0;
  while (n > 0) {
    s += n % 10;
    n = Math.trunc(n / 10);
  }
  if (i == Math.pow(s, 2)) rss += i + " ";
}
document.querySelector("p").innerHTML = rss;

// !47=====================
let ress = "";
for (let i = 1; i <= 1000; i++) {
  let n = i;
  let s = 0;
  while (n > 0) {
    s += Math.pow(n % 10, 3);
    n = Math.trunc(n / 10);
  }
  if (s === i) ress += i + " ";
}
document.querySelector("p").innerHTML = ress;

// !48================
function isPrime(n) {
  let c = 0;
  for (let i = 1; i <= 1000; i++) {
    if (n % i == 0) c++;
  }
  return c == 2;
}

let res2 = "";
for (let i = 1; i <= 1000; i++) {
  let s = i.toString();
  s = Number(s.split("").reverse().join(""));
  if (isPrime(s)) document.querySelector("p").innerHTML += `${i} is prime <br>`;
}

// !49===================
for (let i = 10; i <= 1000; i++) {
  let s = 0;
  let d = 1;
  let n = i;
  while (n > 0) {
    s += n % 10;
    d *= n % 10;
    n = Math.trunc(n / 10);
  }
  if (d === Math.pow(s, 2)) document.querySelector("p").innerHTML += i + " ";
}
// !50==================
let result = " ";
for (let i = 1; i <= 1000; i++) {
  if (i < 10) continue;
  let s = i.toString();
  s = Number(s.split("").reverse().join(""));
  if ((s * i) % 10 == 1) result += i + " ";
}
document.querySelector("p").innerHTML += result;
