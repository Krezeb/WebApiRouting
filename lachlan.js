// fetch('https://localhost:7073/ListAllUsers', { method: 'GET' })
//     .then(response => response.json()) //.json() is a function that converts the "response" from the fetch into a JSON object
//     .then(function (data) {
//         appendData(data);
//     })

// const appendData = (data) => {
//     let body = document.getElementById('app')
//     for (var i = 0; i < data.length; i++) {
//         var div = document.createElement("div");
//         div.innerHTML =
//             'User Id : ' + data[i].userId + '<br/>' +
//             'Name    : ' + data[i].name + '<br/>' +
//             'E-Mail  : ' + data[i].email + '<br/>' +
//             'Age     : ' + data[i].age + '<br/>' +
//             'Password: ' + data[i].password + '<br/>' + '<br/>';
//         body.appendChild(div);
//     }
// }

// ListAllUsers();

fetch
    ('https://localhost:7073/GetExpenseForSpecificBudget',
        {
            method: 'POST',
            headers: {'Content-type': 'application/json; charset=UTF-8'},
            body: JSON.stringify({ userId: 1, budgetId: 1 })
        },
    )
    .then(response => response.json()) //.json() is a function that converts the "response" from the fetch into a JSON object
    .then(function (data) {
        appendData(data);
    })

const appendData = (data) => {
    let body = document.getElementById('app')

    for (var i = 0; i < data.length; i++) 
    {
        let div = document.createElement("div");
        
        div.innerHTML =
            'Budget Name : ' + data[i].budgetName + '<br/><br/>' + 'Expenses :' + '<br/>';
            
            body.appendChild(div);
            
            for (var j = 0; j < data[i].expenses.length; j++) 
            {
                let div2 = document.createElement("div");
                div2.innerHTML =
                    'Category Name : ' + data[i].expenses[j].categoryName + '<br/>' +
                    'Amount : ' + data[i].expenses[j].amount + '<br/>' +
                    'Recipient : ' + data[i].expenses[j].recipient + '<br/>' +
                    'Date : ' + data[i].expenses[j].date + '<br/>' +
                    'Comment : ' + data[i].expenses[j].comment + '<br/><br/>'; 
                body.appendChild(div2);
            }
    }
}

// const appendData = (data) => {
//     let body = document.getElementById('app')

//     for (var i = 0; i < data.length; i++) 
//     {
//         var div = document.createElement("div");
//         div.innerHTML =
//             'Budget Name : ' + data[i].budgetName + '<br/>'// +
//             // 'Expenses : ' + data[i].expenses[i].amount;
//             for (var j = 0; j < data.expenses.length; j++) 
//             {
//                 var div2 = document.createElement("div");
//                 div.innerHTML =
//                     'Category Name : ' + data[i].expenses[j].categoryName + '<br/>'// +
//                     // 'Expenses : ' + data[i].expenses[i].amount;
                    
//                 body.appendChild(div2);
//             }
//         body.appendChild(div);
//     }
// }