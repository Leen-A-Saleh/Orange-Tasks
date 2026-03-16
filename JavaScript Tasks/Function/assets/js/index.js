// !T1====================
let T1 = [1, 2, 3, 4, 5];

const FIRSTANDLAST = (T) => {
  let s = T.length;
  return s === 0
    ? []
    : s === 1
      ? T.slice(0, 1)
      : T.slice(0, 1).concat(T.slice(-1));
};

console.log(FIRSTANDLAST(T1));

// !T2=====================
let T2 = [1, 2, 3, 4, 5];

const REMOVEMIDDLE = (T) => {
  let s = T.length;
  T.splice(Math.trunc(s / 2), 1); //*on origin array
  return T;
};

console.log(REMOVEMIDDLE(T1));

// !T3=========================
let T3 = [1, 2, 3, 4, 5];

// arow function   [x,y]=[y,x]
const SWAPFIRSTLAST = (T) => {
  let s = T.length;

  [T[0], T[s - 1]] = [T[s - 1], T[0]];
  return T;
};

console.log(SWAPFIRSTLAST(T3));

// !T4=======================
let T4 = [1, 2, 3, 4];

const INSERTATMIDDLE = (T) => {
  let s = T.length,
    mid = Math.trunc(s / 2);

  T.splice(mid, 0, 10);
  return T;
};

console.log(INSERTATMIDDLE(T4));

// !T5==========================
let T5 = [1, 2, 3];

const DUPLICATEARRAY = (T) => {
  return T.concat(T);
};

console.log(DUPLICATEARRAY(T5));

// !T6=========================
let T6 = [1, 2, 2, 3, 4, 4, 5];

const REMOVEDUPLICATES = (T) => {
  let T6U = [];
  T.forEach((e) => {
    if (!T6U.includes(e)) T6U.push(e);
  });

  return T6U;
};

console.log(REMOVEDUPLICATES(T6));

// !T7 & T18=======================
let T7 = [4, 9, 2, 10, 6];

// ?T17??????????
const FINDSECONDLARGEST = (T) => {
  T.sort((x, y) => x - y);
  return T[T.length - 2];
};

//??T18????????????
const FINDSECONDSMALLEST = (T) => {
  T.sort((x, y) => x - y);
  return T[1];
};

console.log(FINDSECONDLARGEST(T7));
console.log(FINDSECONDSMALLEST(T7));

// !T9 & T10 ==========================
let T9 = [10, 5, 20, 3, 8];

//?T19?????????????????
const REMOVEGREATERTHAN = (T) => {
  return T.filter((e) => e < 10);
};

//?T20???????????
const REMOVELESSTHAN = (T) => {
  return T.filter((e) => e >= 10);
};

console.log(REMOVEGREATERTHAN(T9));
console.log(REMOVELESSTHAN(T9));

// !T11===========================
let T11 = [1, 2, 3, 2, 4, 2];

const COUNTOCCURRENCES = (T, v) => {
  return T.filter((e) => e === 2).length;
};

console.log(COUNTOCCURRENCES(T11, 2));

// !T12 & T13=====================
let T121 = [1, 2, 3, 4],
  T122 = [3, 4, 5, 6];

//?T12??????????????
const ARRAYINTERSECTION = (T, T1) => {
  return T.filter((e) => T1.includes(e));
};

//?T13????????????
const ARRAYDIFF = (T, T1) => {
  return T.filter((e) => !T1.includes(e)).concat(
    T1.filter((e) => !T.includes(e)),
  );
};

console.log(ARRAYINTERSECTION(T121, T122));
console.log(ARRAYDIFF(T121, T122));

// !T14============================
let T141 = [1, 2, 3],
  T142 = [3, 4, 5];

const UNIQUEMERGE = (T, T1) => {
  return T.filter((e) => !T1.includes(e)).concat(
    T1.filter((e) => !T.includes(e)),
  );
};

console.log(UNIQUEMERGE(T141, T142));

// !T15==============================
let T15 = [5, -2, 10, -3, 7];

const REMOVENEGATIVENUMBER = (T) => {
  return T.filter((e) => e > 0);
};

console.log(REMOVENEGATIVENUMBER(T15));

// !T16 & T18 & T19 & T20==========================
let T16 = ["alex", "mohammad", "ali", "sara"];

// TODO: T16 === T19 (the same output)
const WORDLONGERTHAN = (T) => {
  return T.reduce((acc, curr) => (acc.length > curr.length ? acc : curr));
};

//?T18??????????????
const REMOVESHORTEORDS = (T) => {
  let short = T.reduce((acc, curr) => (acc.length < curr.length ? acc : curr));
  // T.splice(T.indexOf(short), 1);
  return T.filter((e) => e !== short);
};

// ?T20????????????????
// const FINDLONGESTWORDS = (T)=>{
//   return REMOVESHORTEORDS();
// }

console.log(WORDLONGERTHAN(T16));
console.log(REMOVESHORTEORDS(T16));
// !T17=============================
let T17 = ["apple", "banana", "car", "dog"];

const COUNTLETTERINEORDS = (T, L) => {
  return T.filter((e) => e.includes(L)).length;
};

console.log(COUNTLETTERINEORDS(T17, "a"));

// !T21==============================
let T20 = ["apple", "hi", "banana"];

const SORTBYLENGTH = (T) => {
  return T.sort((x, y) => x.length - y.length);
};

console.log(SORTBYLENGTH(T20));

// !T22===================
let T22 = [1, 2, 3, 4, 5, 6];

const REMOVEEVERYSECOND = (T) => {
  return T.filter((e, i) => i % 2 === 0); //even index
};

console.log(REMOVEEVERYSECOND(T22));

// !T23 & T24=======================
let T23 = [1, 2, 3, 4, 5, 6];

// ?T23???????????????????????
const SUMEVENNUMBER = (T) => {
  // return T.filter((e) => e % 2 === 0).reduce((x, y) => x + y,0);
  let s = 0;
  T.reduce((sum, e) => (e % 2 === 0 ? (s += e) : s));
  return s;
};

// ?T24??????????????????????
const SUMODDINDEX = (T) => {
  let s = 0;
  T.reduce((sum, e, i) => (i % 2 !== 0 ? (s += e) : s));
  return s;
};

console.log(SUMEVENNUMBER(T23));
console.log(SUMODDINDEX(T23));

// !T25=======================
let T25 = [1, 2, 3, 4];

const REVERSEWITHOUTREVERSE = (T) => {
  let res = [];
  for (i = T.length; i > 0; i--) {
    res.push(i);
  }
  return res;
};

console.log(REVERSEWITHOUTREVERSE(T25));

// !T26======================
let T26 = [1, 2, 3, 5, 6];

const FINDMISSINGNUMBER = (T) => {
  T.sort((x, y) => x - y);
  let i;
  for (i = 0; i < T.length - 1; i++) {
    if (T[i + 1] - T[i] !== 1) return T[i] + 1;
  }
};

console.log(FINDMISSINGNUMBER(T26));

// !T27======================
let T27 = [2, 7, 11, 15];

const PAIRSUM = (T, target) => {
  // T.sort((x, y) => x - y);
  let res = T.filter((e) => e < target);
  for (let i = 0; i < res.length; i++)
    for (let j = i + 1; j < res.length; j++)
      if (res[i] + res[j] === target) return [res[i], res[j]];

  return -1;
};

console.log(PAIRSUM(T27, 9));

// !T28==========================
let T28 = [1, 2, 3, 4, 5];

const ROTATEARRAY = (T, target) => {
  let res = T.slice(-target);

  return res.concat(T.slice(0, T.length - target));
};

console.log(ROTATEARRAY(T28, 2));

// !T29==================
let T29 = [1, 2, 3, 4, 5, 6];

const CHUNKARRAY = (T, s) => {
  let res = [];
  for (let i = 0; i < T.length; i += s) res.push(T.slice(i, i + s));
  return res;
};

console.log(CHUNKARRAY(T29, 2));

// !T30==================
let T30 = ["hi", "cat", "dog", "apple"];
let res = {};
const GROUPBYLENGTH = (T) => {
  T.forEach((e) => {
    let s = e.length;
    if (!res[s]) res[s] = [];
    res[s].push(e);
  });
  return res;
};

console.log(GROUPBYLENGTH(T30));
