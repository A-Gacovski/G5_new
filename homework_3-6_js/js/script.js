console.log('--------------------HOMEWORK#6----------------------');

let rowInput = document.getElementById('newRow');
let columnInput = document.getElementById('newColumn');
let buttonCatch = document.getElementById('press');
let tableResult = document.getElementById('result');

function printTable(rows, columns){
    if(rows !== "" &&  columns !== ""){
        tableResult.innerHTML = "";
        for(let i = 1; i <= rows; i++ ){
            let tr = document.createElement('tr');
            for(let j = 1; j <= columns; j++ ){
                let td = document.createElement('td');
                tr.appendChild(td);
               td.innerText = `row ${i}, column ${j}`;
            }
            tableResult.appendChild(tr);
        }
    }else{
        alert('You must insert valid input data');
    }   
}
buttonCatch.addEventListener('click', function(){
    let rows = rowInput.value;
    let columns = columnInput.value;
    printTable(rows,columns);
})