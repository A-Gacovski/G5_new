console.log(`-----------------------Assignment#01---------------------------`);

let car1 = {
    brand: 'VW',
    type: 'Polo',
    engine: '1300cm3',
    kw: 70,
    doors: 3
};

let car2 = {
    brand: 'VW',
    type: 'Tuareg',
    engine: '2000cm3',
    doors: 5,
    color: 'white'
};
console.log(car1);
console.log(car2);

let newCar = Object.assign(car1,car2);

console.log(newCar);

console.log(`-----------------------Assignment#01_bonus---------------------`);

const audi = {model: 'A6'}
const mitsubishi = {kw: 70};
const opel = {doors: 4};
const ford = {color: 'white'};

let allObjects = Object.assign(audi,mitsubishi,opel,ford);

console.log(allObjects);

console.log(`-----------------------Assignment#02---------------------------`);

function Trainer(firstName, lastName, currentSubject, street, number, city){
    this.firstName = firstName;
    this.lastName = lastName;
    this.currentSubject = currentSubject;
    this.street = street;
    this.number = number;
    this.city = city;
    this.getFullName = function(){
        return `The trainer ${this.firstName} ${this.lastName}`;
    }
    this.getAddress = function(){
        return `The Address ${this.city}, ${this.street} ${this.number}`;
    }
}

let martin = new Trainer('Martin','Panovski','AJS', 'Leninova', 25, 'Skopje');
let ivan = new Trainer('Ivan','Lazarevski', 'AJS', 'Atinska', '44/1-1', 'Skopje');
let angela = new Trainer('Angela','Kostadinova','BJS','Ankarska', 45, 'Skopje');

console.log(`${martin.getFullName()} lives on ${martin.getAddress()}`);
console.log(`${ivan.getFullName()} lives on ${ivan.getAddress()}`);
console.log(`${angela.getFullName()} lives on ${angela.getAddress()}`);

console.log(`-----------------------Assignment#03---------------------------`);

let newRecepe = document.getElementById('name');
let newIngredients = document.getElementById('ingredients');
let newInstructions = document.querySelector('#instructions');
let newBth = document.getElementById('submit');

newBth.addEventListener('click', function(event){
    event.preventDefault();
    let name = newRecepe.value;
    let ingredients = newIngredients.value;
    let instructions = newInstructions.value;
    
    printFunc(name, ingredients, instructions);
});

let recepiesArray = [];

let printFunc = (name, ingredients, instructions) => {
    
    let recipe = {
        newName: name,
        newIngredients: ingredients,
        newInstructions: instructions,
    }
    let recepieObj = Object.create(recipe);
    recepiesArray.push = (recepieObj);
    console.log(recepiesArray);
};

