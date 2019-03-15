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
                    <tr v-for="student in students":key="student.studentID">
                        <td>{{ student.studentId }}</td>
                        <td>{{ student.email_address }}</td>
                    </tr>
                </tbody>
            </table>
    </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        name: 'Students',
        data () {
            return {
                students: []
            }
        },
        methods: {
            getStudents: function() {
                let studentsApi = process.env.STUDENT_API;
                Vue.axios.get(studentsApi).then(
                    (response) => {
                        console.log(response)
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },
        mounted() {
            this.getStudents();
        }
    }

   
    </script>


<style>

</style>