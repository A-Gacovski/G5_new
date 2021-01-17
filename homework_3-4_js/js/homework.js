console.log('------------------HOMEWORK#1-------------------');

function tellStory(strings){
    console.log(`This is ${strings[0]}. ${strings[0]} is a good person. \n He is ${strings[1]}. He is ${strings[2]} all day`);
}
tellStory(['Stef', 'happy', 'running']);

console.log('------------------HOMEWORK#2-------------------');

function number(num){
    let sum = 0
    for (let i = 0; i < 5; i++ ){
        sum = sum + num[i];
    }
console.log (sum);
}
number([1,2,3,4,5]);

console.log('------------------HOMEWORK#2_Bonus-------------------');


function validateNumber(Array){
    for( i = 0; i <= Array.length; i++){
        if(Array.length === i){
            console.log(`all numbers are valid`);  
        } else if (typeof Array[i] === 'number'){
            continue;
        }else {
            console.log(`Number you have insert ${Array[i]} is not valid`);
            break;
        }   
    }
} 

validateNumber([1, 2, 3,  4, 5]);
validateNumber([1, 2, 'no', 4, 5]);
validateNumber([1, 2, 3, 4, 5, 6, 10]);
validateNumber([1, 2, 'yes', 4, 5]);

