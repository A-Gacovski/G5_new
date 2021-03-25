console.log('---------------HOMEWORK#1--------------------------');

function Concatination(Array){
    for (let i = 0; i < Array.length; i++){
        if (typeof (Array[i]) === 'string'){
            console.log(Array[i]);
        }else{
            continue;
        }
    }
}
Concatination(['Hello' + ' ' +'there ' + 'students '+ '\n' + 'of ' + 'SEDC' + '!']);

console.log('---------------HOMEWORK#2--------------------------');

let upNum = [];
    
    for (let i = 0; i < 20; i++){
        upNum[i] = i + 1;

        if (upNum[i] % 2 === 0){
            console.log(upNum[i] + '\n' );
        }else{
            console.log(upNum[i] + ' ' );
        }
    }


console.log('---------------HOMEWORK#3--------------------------');



function arrayCheck(arr){
    max = -Infinity;
    min = +Infinity;

    for(let i = 0; i < arr.length; i++){
        if (arr[i] > max){
            max = arr[i];
        }if (arr[i] < min){
            min = arr[i];
        }else{
            continue;
        }
    }
    let sum = max + min;
    console.log(`Max: ${max},  Min: ${min},  Sum:${sum}`);
}

arrayCheck([3, 5, 6, 8, 11]);



console.log('---------------HOMEWORK#3 bonus---------------------');

function newArrayCheck(newArr){
    newMax = -Infinity;
    newMin = +Infinity;

    for(let i = 0; i < newArr.length; i++){
        if (typeof (newArr[i]) === 'number'){
        }else{
        continue;
        }
        if (newArr[i] > newMax){
            newMax = newArr[i];
        }
        if (newArr[i] < newMin){
            newMin = newArr[i];
        }
    }
    let newSum = newMax + newMin;
    console.log(`Max: ${newMax},  Min: ${newMin},  Sum:${newSum}`);
}
newArrayCheck([2, 3, 5, 6,'true', 11, true, 18]);

console.log('---------------HOMEWORK#4--------------------------');


function names(firstName, lastName){
    for(i = 0; i < firstName.length; i++){
        console.log((i+1) + '. ' + firstName[i] + ' ' + lastName[i]);
    }
}
firstName=['Aleks', 'Saska', 'Stefan']
lastName=['Aleksovski', 'Grueva', 'Stefanovski'];
names(firstName,lastName);
