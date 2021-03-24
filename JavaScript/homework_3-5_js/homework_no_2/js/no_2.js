console.log('---------------------HOMEWORK#5----------------------')

// headingThree
let headingThree = document.querySelector('h3');
console.log(headingThree);
headingThree.innerText = '';
headingThree.innerText = 'Bye Bye';
console.log(headingThree.innerText);


// textelement
let textElement = document.querySelector('text');
console.log(textElement);
textElement.innerText = '';
textElement.innerText = 'Selecting and adding is interesting';
console.log(textElement.innerText);


// parahraphs
let paragraphs = document.querySelectorAll('p');
console.log(paragraphs);

let firstParagraph = paragraphs[0];
firstParagraph.innerText = '';
firstParagraph.innerText = 'Yes it is';
console.log(firstParagraph.innerText);


let secondParagraph = paragraphs[1];
secondParagraph.innerText = '';
secondParagraph.innerText = 'It is all about coding';
console.log(secondParagraph.innerText);


// headersOne
let headingsOne = document.querySelectorAll('h1');
console.log(headingsOne);

let firstHeadingOne = headingsOne[0];
firstHeadingOne.innerText = '';
firstHeadingOne.innerText = 'Good job';
console.log(firstHeadingOne.innerText);

let secondHeadingOne = headingsOne[1];
secondHeadingOne.innerText = '';
secondHeadingOne.innerText = 'See you around';
console.log(secondHeadingOne.innerText);


console.log('----------------------HOMEWORK#6---------------------')

let numbersArray = [1,2,3,4,5,6,7,8,9,10];

let listing = document.getElementById('homework');
console.log(listing);

function fillUp(numArr){
    listing.innerHTML = '';
    listing.innerHTML = '<ul>';
    let sum = 0;
    for(let i = 0; i < numArr.length; i++){
        listing.innerHTML += `<li>${numArr[i]}</li>`;
        sum += numArr[i];
    }

    listing.innerHTML += '</ul>';
    listing.innerHTML += '<br />';
    listing.innerHTML += `</p>the sum is: ${sum}</p>`;
}
fillUp(numbersArray);

console.log('----------------------HOMEWORK#6--bonus---------------------')

let newList = document.getElementById('homeworkbonus');
console.log(newList);

function fillUpNew(numDownArr){
    newList.innerHTML = '';
    newList.innerHTML += '<p>';
    let Newsum = 0;
    for(let i = 0; i < numDownArr.length - 1; i++){
        newList.innerHTML += numDownArr[i] + ' + ';
        Newsum += numDownArr[i];
    }
    newDownSum = Newsum + numDownArr[numDownArr.length-1];
    
    newList.innerHTML += numDownArr[numDownArr.length-1];
    newList.innerHTML += ' = ' + newDownSum;

    newList.innerHTML += '</p>';
    newList.innerHTML += `</p>bonus</p>`;
}
fillUpNew(numbersArray);
