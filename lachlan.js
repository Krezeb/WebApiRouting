fetch('https://localhost:7073/ListAllUsers', { method: 'GET' })
    .then(response => response.json()) //.json() is a function that converts the "response" from the fetch into a JSON object
    .then(function (data) {
        appendData(data);
    })

const appendData = (data) => {
    let body = document.getElementById('app')
    for (var i = 0; i < data.length; i++) {
        var div = document.createElement("div");
        div.innerHTML =
            'User Id : ' + data[i].userId + '<br/>' +
            'Name    : ' + data[i].name + '<br/>' +
            'E-Mail  : ' + data[i].email + '<br/>' +
            'Age     : ' + data[i].age + '<br/>' +
            'Password: ' + data[i].password + '<br/>' + '<br/>';
        body.appendChild(div);
    }
}

ListAllUsers();