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
console.log(s4.substring(0, 6));

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
let s17="example@email.com";
console.log(s17.includes('@'));

// !P18============================
let s18="This is a bad word";
console.log(s18.replace("bad","good"));

// !P19===========================
// reduce
let s19="aabbc";

// !P20========================
let s20="hello";
console.log(s20.split("").sort().join(""));
