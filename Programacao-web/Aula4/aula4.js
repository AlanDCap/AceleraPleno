
document.getElementById('texto').addEventListener('keyup', (e) => {
    var counter = 0;
    let texto = document.getElementById('texto').value;
    
    document.getElementById('total-palavras').innerText = 'Total de palavra(s) digitada(s): ' 
    + texto
    .replaceAll('\n', ' ')
    .split(' ')
    .filter(item => item != '')
    .filter(item => item.length > 1).length;

});
    
// var num  = 0;
// var counter = 0;
// var results = [];

// while (true) {
    
//     num += Math.floor(Math.random() * 10);
//     results.push(num);
//     //console.log(num);
//     if (num > 100) {
//         console.log(`Iterações: ${results.length}`);
//         break;
//     }
// }

// //FizzBuzz Challenge
// for (let i = 1; i <= 100; i++) {
//     if (i % 2 == 0) {
//         console.log("Fizz");
//     }
//     if (i % 3 == 0) {
//         console.log("Buzz");
//     }
//     if (i % 3 != 0 && i % 2 !== 0) {
//         console.log(i);
//     }
// }