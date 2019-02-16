<template>
    <div>
        <h1 class="Table_Header">Student Table</h1>
            <table>
                
                <thead>
                    <tr>
                        <th>StudentID</th>
                        <th>Email</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="student in students">
                        <td>{{ student.studentID }}</td>
                        <td>{{ student.email }}</td>
                    </tr>
                </tbody>
            </table>
    </div>
</template>

<script>
export default {
  name: 'Students',
  mounted() {
      this.students = getStudents();
  },
  data () {
    return {
        students: []
    }
  }
}

function initializeStudents() {
    var data = getStudents();
    displayStudents(data.students);
}

function getStudents() {
    return JSON.parse(testStudents).students;
}

var testStudents = '{"students": [{"studentID": "1","email": "ASmith@email.com"},{"studentID": "2","email": "AnEmail@mail.com"}]}'
</script>


<style>

</style>