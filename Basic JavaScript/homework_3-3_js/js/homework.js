
// // Homework Part 1

// function varCheck(input){
//     console.log(input, typeof input);
// }

// varCheck(null);
// varCheck(true);
// varCheck(25);
// varCheck("dog");
// varCheck();

// // Homework Part 2

// function human(humanYears){
//     let dogYears= humanYears*7;
//     console.log(dogYears);
// }

// human(10);
// human(20);

// // Homework Part 2 bonus

// function dog(dogYears){
//     let humanYears=dogYears/7;
//     console.log(humanYears);
// }

// dog(20);
// dog(49);

// // Homework Part 3

// function money(moneyAmount){
//     let saveings=5500;
//     if (moneyAmount<=saveings){
//         let moneyLeft=saveings-moneyAmount;
//         console.log(`You have withdrawn ${moneyAmount}$ and you have ${moneyLeft}$ left on your bank account`);
//     } else {
//         console.log(`Not enough money`);
//     }
// }

// money(500);
// money(5500);
// money(6000);

// Homework Part 3 bonus

function money(){
    let moneyAmount= prompt(`How much money would you like to withdraw`);
    let saveings=5500;
    if (moneyAmount<=saveings){
        let moneyLeft=saveings-moneyAmount;
        console.log(`You have withdrawn ${moneyAmount}$ and you have ${moneyLeft}$ left on your bank account`);
    } else {
        console.log(`Not enough money`);
    }
}

money();
money();
money();