console.log('-----------------EXERCISE#1--------------------');

let unSumedArr = [1,2,3,4,5];

let sumOfArray = unSumedArr.reduce((acc, cur) => {
    return acc + cur;
});
console.log(sumOfArray);



console.log('----------------EXERCISE#2----------------------');

let Btn = document.getElementById('press');

Btn.addEventListener('click', function(){
    console.log('geting input data, please wait...');
    fetch ("http://api.open-notify.org/astros.json")
    .then (response => response.json())
    .then (result => console.log(result))
    .catch(error => console.log(`there has been an error${error}`));
});


console.log('----------------EXERCISE#3----------------------');

let convertButton = document.getElementById("convert");
let chooseCurr = document.getElementById("currency");

convertButton.addEventListener('click', function(event){
    event.preventDefault();
    let newCurrency = chooseCurr.value;
    input(60,newCurrency);
    input(100, newCurrency);
    input(124,newCurrency);
});

let input = (valElement, newCurrency) => {      
    let money = 0;
        if (newCurrency === "MKD"){
            money = valElement;
            console.log(`You have inserted ${money.toFixed(2)} MKD`);
        }else if (newCurrency === "EUR"){
            money = valElement / 62;
            console.log(`You have inserted ${money.toFixed(2)} EUR`);
        }else if (newCurrency === "USD"){
            money = valElement / 50;
            console.log(`You have inserted ${money.toFixed(2)} USD`);
        }       
};