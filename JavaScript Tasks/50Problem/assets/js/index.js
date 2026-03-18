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
