console.log('-----------------EXERCISE#1--------------------');

let account = array => {
    let sum = 0;
    for (const element of array) {
        sum += element;
    }
    console.log(sum);
}

account([1,2,3,4,5]);

console.log('----------------EXERCISE#2----------------------');

let Btn = document.getElementById('press');

Btn.addEventListener('click', function(){
    console.log('geting input data, please wait...');
    fetch ("http://api.open-notify.org/astros.json")
    .then (response => response.json())
    .then (result => console.log(result))
    .catch(error => console.log(`there has been an error${error}`));
});


// console.log('----------------EXERCISE#3----------------------');

// let convertButton = document.getElementById("convert");
// let chooseCurr = document.getElementById("currency");

// convertButton.addEventListener('click', function(){
//     let input = valElement => {      
//         let money = 0;
//             if (chooseCurr.value === "MKD"){
//                 money = valElement;
//                 console.log(`You have inserted ${money}MKD`);
//             }else if (chooseCurr.value === "EUR"){
//                 money = valElement / 62;
//                 console.log(`You have inserted ${money}EUR`);
//             }else if (chooseCurr.value === "USD"){
//                 money = valElement / 50;
//             }       
//     }
// });

// input(60);
// input(100);
