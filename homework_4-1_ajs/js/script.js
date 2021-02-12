let btnAjax = document.getElementById('newAjax');
let btnFetch = document.getElementById('newFetch');

btnAjax.addEventListener('focus', function(){
    console.log('Getting data, please wait...');
    $.ajax({
        url: 'http://api.open-notify.org/iss-now.json/',
        method: 'GET',
        success: function (response){
            console.log(response);
        },
        error: function (error){
            console.log('There has been an error');
        }
    })
});


btnFetch.addEventListener('click', function(){
    console.log('Getting data..');
    fetch('https://api.openaq.org/v1/cities?country=MK/')
    .then(response => {
        return response.json();
    })
    .then(data => {
        console.log(data); 
    })
    .catch(error => {
        console.log('There has been an error');
        console.log(error);
    })
});

