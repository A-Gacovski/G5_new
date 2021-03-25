console.log('--------------------EXERCISE#1------------------------');


let namesLengthArr = [];
let namesArr = ["Bill", "Ana", "Josephine", "Elena"];


function counter(arr){
    for(let i = 0; i < arr.length; i++){
        namesLengthArr[i] = namesArr[i].length;
        console.log(namesLengthArr[i],namesArr[i]);
    }
    return namesLengthArr;
}
counter(namesArr);
console.log(`The new array is [${namesLengthArr}]`);


console.log('--------------------EXERCISE#2------------------------');

let numArr = []; 

function account(num){
    let j = 0;
    for(let i = 0; i < num; i++){
        if( (i + 1) % 3 == 0 && (i + 1) % 7 == 0){
            numArr[j] = (i + 1);
            j++;
        }else{
            continue
        }
        
    }
    console.log (`The array is [${numArr}]`);
}
account(100);
account(200);
account(300);




