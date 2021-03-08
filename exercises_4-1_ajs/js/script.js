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


console.log('----------------EXERCISE#3----------------------');

let convertButton = document.getElementById("convert");
let chooseCurr = document.getElementById("currency");

convertButton.addEventListener('click', function(event){
    event.preventDefault();
    let newCurrency = chooseCurr.value;
    input(60,newCurrency);
    input(100, newCurrency);
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