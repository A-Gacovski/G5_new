console.log(`--------------------HOMEWORK#1---------------------------`);

let unchangedArr = [1,3,5,7,9];

const changedArr = unchangedArr.map ((element) => (element * 10));
console.log(unchangedArr);
console.log(changedArr);

console.log(`--------------------HOMEWORK#1_bonus---------------------`);

let number = 20;

const changedArrNew = unchangedArr.map ((element) => (element * number));
console.log(unchangedArr);
console.log(changedArrNew);

console.log(`--------------------HOMEWORK#2----------------------------`);

let unfilteredNums = [3,9,27,81,100,102,107];
let filteredNums = [];

const filteredNumsNew = (unfilteredNums, devisionNumber) => {
    for (const newElement of unfilteredNums) {
        if (newElement % devisionNumber === 0){
            filteredNums.push (newElement);
        }else{
            continue;
        }
    }
    console.log(filteredNums);
}

filteredNumsNew(unfilteredNums, 3);

console.log(`--------------------HOMEWORK#2_bonus-----------------------`);

filteredNums.sort ((a,b) => b-a);
console.log(filteredNums);