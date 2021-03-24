console.log(`-------------------homework #2--------------------------`);

// vlezni podatoci
let Year=prompt (`vnesi godina na ragjanje`);
let parsedYear=parseInt(Year);

//pocetna if funkcija
if (parsedYear>=1920 && parsedYear<=2021){

// presmetka
    let yearValue1=(parsedYear-4);
    let yearValue2=(yearValue1%12);
// resenie
    if (yearValue2==0){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na staorecot`);
    }else if(yearValue2==1){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na bivolot`);
    }else if(yearValue2==2){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na tigarot`);
    }else if(yearValue2==3){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na zajakot`);
    }else if(yearValue2==4){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na zmejot`);
    }else if(yearValue2==5){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na zmijata`);
    }else if(yearValue2==6){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na konjot`);
    }else if(yearValue2==7){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na kozata`);
    }else if(yearValue2==8){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na majmunot`);
    }else if(yearValue2==9){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na petelot`);
    }else if(yearValue2==10){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na kuceto`);
    }else if(yearValue2==11){
        alert(`Vie ste rodeni vo ${Year}godina koja e godina na svinjata`);

    }else{
    alert(`vnesovte pogresna godina na ragjanje, obidete se povtorno!`);

    }
}else{
    alert(`vnesovte pogresna godina na ragjanje, obidete se povtorno!`);
}
