// !P1=========================
let s = "Hello",
  s1 = "World";
console.log(s.concat(" ", s1));

// !P2======================
let s2 = "JAvaScript";
console.log(s2.length);

// !P3========================
let s3 = "Programming";
console.log(s3.charAt(0));

// !P4======================
let s4 = "coding is fun";
console.log(s4.split(" ")[0]);
// slice(0,6)

// !P5=====================
let s5 = "cat";
console.log(s5.replace("a", "e"));

// !P6======================
let s6 = "javascript";
console.log(s6.toUpperCase());

// !P7==========================
let s7 = "apple,banana,orange";
console.log(s7.split(","));

// !P8=============================
let arr = ["hello", "world"];
console.log(arr.join(" "));

// !P9============================
let s9 = " hello world ";
console.log(s9.trim());

// !P10=====================
let s10 = "hello world";
console.log(s10.includes("world"));

// !P11=====================
let s11 = "hello";
console.log(s11.split("").reverse().join(""));

// !P12===================
let s12 = "elephant";
console.log(s12.split("").filter((x) => x === "e").length);

// !P13======================
let s13 = "racecar";
if (s13 === s13.split("").reverse().join("")) console.log("true");
else console.log("false");

// !P14======================
let s14 = "hello world";
let s14U = s14
  .split(" ")
  .map((x) => x.at(0).toLocaleUpperCase() + x.slice(1))
  .join(" ");
console.log(s14U);

// !P15=====================
let s15 = 1234.5678;
console.log(s15.toFixed(2));

// !P16======================
let s16 = "There are 3 apples and 2 oranges";
console.log(s16.match(/\d+/g));

// !P17========================
let s17 = "example@email.com";
let reg = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
console.log(reg.test(s17));

// !P18============================
let s18 = "This is a bad word";
console.log(s18.replace("bad", "good"));

// !P19===========================
// reduce
let s19 = "aabbc";
console.log(s19.split(""));

// !P20========================
let s20 = "hello";
console.log(s20.split("").sort().join(""));

// !P21====================
let s21 = (str) => str.split("").sort().join("");
console.log(s21("listen") === s21("silent"));

// !P22=====================
let s22 = "The quick brown fox";
console.log(s22.split(" ").reverse().join(" "));

// !P23==============
let s23 = "Web development is fascinating";
let s23P = s23
  .split(" ")
  .reduce((acc, cur) => (acc.length < cur.length ? cur : acc));
console.log(s23P);

// !P24==================
let s25 = "A man, a plan, a canal, Panama!";
let s25P = s25.replace(/[^a-z0-9]/gi, "").toLowerCase();
let rev = s25P.split("").reverse().join("");
console.log(s25P === rev);

// !P25==================
// !P26===================
let s26 = "Hello World";
console.log(s26.replaceAll('e',1));

// !P27===================
let s27 = "JavaScript is fun";
console.log(s27.startsWith("Java"));

// !P28====================
let s28 = "image.png";
console.log(s28.endsWith("png"));

// !P29=======================
let s29 = "ha";
console.log(s29.repeat(3));

// !P30=====================
let s30 = "Hello World";
console.log(s30.indexOf("o"));
