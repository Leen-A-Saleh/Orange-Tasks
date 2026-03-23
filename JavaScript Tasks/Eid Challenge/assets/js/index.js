// ! Log Compression System==================================
let Eid1 = [
  { event: "click", time: 1 },
  { event: "click", time: 2 },
  { event: "scroll", time: 3 },
  { event: "scroll", time: 4 },
  { event: "click", time: 5 },
];

const COMPRESSIONSYSTEM = (T) => {
  let c = 1,
    res = [];
  // return T.reduce((acc, cur) => {}, []);
  for (let i = 0; i < T.length; i++) {
    if (i === T.length - 1) {
      res.push({ event: T[i].event, count: c });
      break;
    }

    if (T[i].event === T[i + 1].event) c++;
    else {
      res.push({ event: T[i].event, count: c });
      c = 1;
    }
  }

  return res;
};

console.log(COMPRESSIONSYSTEM(Eid1));

// ! Subarray with Given Sum==============================
let Eid2 = [5, 3, 8],
  target = 8;

const SUBARRAY = (T, Target) => {
  let sum = 0,
    start = 0,
    end = 0;
  while (end < T.length) {
    if (sum < Target) {
      sum += T[end];
      end++;
    } else if (sum > Target) {
      sum -= T[start];
      start++;
    } else if (sum === Target) {
      return `start = ${start} , end = ${--end}`;
    }
  }
  return -1;
};

console.log(SUBARRAY(Eid2, target));

// !Maximum Profit=========================================
let Eid3 = [7, 1, 5, 3, 6, 4];

const PROFIT = (T) => {
  let minPrice = T[0];
  let maxProfit = 0;

  for (let i = 0; i < T.length; i++) {
    if (T[i] < minPrice) minPrice = T[i];

    let profit = T[i] - minPrice;
    if (profit > maxProfit) maxProfit = profit;
  }

  return maxProfit;
};

console.log(PROFIT(Eid3));

// !Trap Rain Water=========================================
// TODO (I got it ,soooo I can't write logic code)
let Eid4 = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];

const TRAPRAIN = (T) => {
  let tatal = 0;
  for (let i = 1; i < T.length - 2; i++) {}
};

console.log(TRAPRAIN(Eid4));

// !Longest Unique Subarray================================
let Eid5 = [1, 2, 3, 1, 2];
// TODO: fix it (I can'ttttttttttttttttt)
const LONGESTSUBARRAY = (T) => {
    res = [];
  for (let i = 0; i < T.length; i++) {
    while (res.includes(T[i])) res.shift();
    res.push(T[i]);
  }
  return res;
};

console.log(LONGESTSUBARRAY(Eid5));

// !Product of Array Except Self============================
// TODO
let Eid6 = [1, 2, 3, 4];

const PRODUCTOFARRAY = (T) => {
  let L = 1,
    R = 1,
    res = Array(T.length).fill(1);

  return res;
};

console.log(PRODUCTOFARRAY(Eid6));

// !Detect Cycle in Array===================================
let Eid9 = [2, -1, 1, 2, 2];

const DETECTCYCLEINARRAY = (T) => {
  let next = 0,
    index = [];
  while (next >= 0 && next < T.length) {
    index.push(next);
    next += T[next];
    if (next >= T.length) return false;
    if (index.includes(next)) return true;
  }
  return false;
};

console.log(DETECTCYCLEINARRAY(Eid9));

// !Eid10 - Reconstruct Queue ==============================
let Eid10 = [
  { height: 7, inFront: 0 },
  { height: 4, inFront: 4 },
  { height: 7, inFront: 1 },
  { height: 5, inFront: 0 },
  { height: 6, inFront: 1 },
  { height: 5, inFront: 2 },
];

const RECONSTRUCTQUEUE = (T) => {
  T.sort((x, y) => {
    if (x.height !== y.height) return y.height - x.height;
    else return x.inFront - y.inFront;
  });
  let res = [];
  for (let i = 0; i < T.length; i++) res.splice(T[i].inFront, 0, T[i]);

  return res;
};

console.log(RECONSTRUCTQUEUE(Eid10));
