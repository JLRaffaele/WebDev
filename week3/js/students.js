function initializeStudents() {
    var data = getTestStudents();
    displayStudents(data.students);
}

function getTestStudents() {
    return JSON.parse(testStudents);
}

function displayStudents(students) {

    for(i = 0; i < students.length; i++) {

        console.log('name: ' + students[i].studentID);
        
        var studentID = students[i].studentID;
        var email = students[i].email;
        var markup = "<tr><td>" + studentID + "</td><td>" + email + "</td><td>";

        $("table tbody").append(markup);
        
    }
}

var testStudents = '{"students": [{"studentID": "1","email": "ASmith@email.com"},{"studentID": "2","email": "AnEmail@mail.com"}]}'