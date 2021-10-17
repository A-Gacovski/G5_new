
let userNameField = document.getElementById("userName");
let passwordField = document.getElementById("password");
let firstNameField = document.getElementById("firstName");
let lastNameField = document.getElementById("lastName");
let favouriteGenreField = document.getElementById("favouriteGenre");
let inputUserButton = document.getElementById("createUserBtn");

inputUserButton.addEventListener("click", function(){
    let user = {
        UserName = userNameField.value,
        Password = passwordField.value,
        FirstName = firstNameField.value,
        LastName = lastNameField.value,
        FavouriteGenre = favouriteGenreField.value
        }
    var options = {
         headers: {
             'Content-Type': 'application/json'
         },
         body: JSON.stringify(user)
    }

     fetch('https://localhost:5001/api/user/adduser', options)
     .then(response => response.json())
     .then(data => console.log(data))
     .catch(err => {
         console.log("There has been an error!")
         console.warn(err)
     })
})

