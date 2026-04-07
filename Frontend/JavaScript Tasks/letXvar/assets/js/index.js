// TODO /////////////////////////////////////////////////////// TODO: Objectives
// TODO: Test deep understanding of scope
// TODO: Identify common **interview traps
// TODO: Master **hoisting, closures, and async behavior
// TODO /////////////////////////////////////////////////////

// !Hoisting Trap===================================
console.log(a);
var a = 10;

//? output : undefined (print befor assignment variabl)
//? var is hoisted : declaration to the top , assignment stay in place

// !Temporal Dead Zone=============================
// console.log(b);
let b = 10;

//? output : error (let is TDZ : cann't access before init )
//?let isn't hoisted

// !Function vs Block Scope======================
var c = 1; //global
function test() {
  if (true) {
    var c = 2; //functional
  }
  console.log(c);
}
test(); //2 (local ignor global)
console.log(c); //1

//!Shadowing + TDZ Trap===========================
let d = 10;

function test1() {
  console.log(d);
  let d = 20;
}

test1();
// ?output : error(let in function scope is LDZ)

// !Classic Closure Problem (var)===================
for (var i = 0; i < 3; i++) {
  setTimeout(() => console.log(i), 0);
}
// ?var is functional => for all iteration(one callback=i)
// ?output : 3 3 3 => setTimeout(async function) not print i in time(delay) =>(callback queue)
// ?loop finish when i=3 =>callback (print i for i times)

// !Classic Closure Problem (let)===================
for (let i = 0; i < 3; i++) {
  setTimeout(() => console.log(i), 0);
}
// ?let is scoped => for each iteration callback
// ?output : 0 1 2 => {let i = 0;setTimeout(() => console.log(i), 0);}

/* function test() {
  if (true) {
    var x = 10;
  }
  console.log(x);//10 (var not just for if is on test function)
}

  function test() {
  if (true) {
    let x = 10;
  }(x dead here after scope it's not a functional)
  console.log(x); //error 
}*/

// !Nested Scope (Closure)======================
var e = 1;

function outer() {
  var e = 2;

  function inner() {
    console.log(e);
  }

  inner();
}

outer(); //2

// !Re-declaration Error=====================
var f = 10;
let f = 20;

// ?output : error (can't redeclaration the same variable using let)

// !Function Hoisting vs Variable Hoisting============
console.log(foo);
// *consol.log(foo()) =>200

var foo = 10;

function foo() {
  return 20;
}

// ?output : function foo(){return 20;} (function hoisting stronger)
// ?function hoisting (declaration + body) | var hoisting (just declaration)
/*==================================================
function foo() {
  return 20;
}

var foo;

console.log(foo);

foo = 10;
===================================================*/

// !Scope + Mutation=============================
let h = 10;

function testh() {
  h = 20; //(reassignment not redeclaration)
}

testh();
console.log(h); //20

// !Block Scope Leakage (var)===================
{
  var t = 10;
}

console.log(t);
// ?output : 10 (var is global)

// !!Block Scope Leakage (let)===================
{
  let tt = 10;
} //*tt dead here (end of scope)

console.log(tt);
// ?ouput : not defined

// !Parameter Shadowing==================
let s = 5;

function tests(s) {
  console.log(s); //10 (parameter)
}

tests(10);

// ! Closure + Async Trap===============
function testo() {
  for (var i = 0; i < 3; i++) {
    setTimeout(() => console.log(i), 100);
  }
}
testo(); //3 3 3

// !IIFE Fix (Advanced)==================
// ?Immediately Invoked Function Expression??

for (var i = 0; i < 3; i++) {
  (function (j) {
    setTimeout(() => console.log(i), 0);
  })(i);
}
// ?callback every iteration
