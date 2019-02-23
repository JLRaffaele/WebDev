<template>
    <div>
        <h1 class="Table_Header">People Table</h1>
    <table>

        <thead>
                <tr>
                    <th>Firstname</th>
                    <th>Lastname</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="person in persons">
                        <td>{{ person.firstname }}</td>
                        <td>{{ person.lastname }}</td>
                    </tr>
                </tbody>


        </table>
    </div>
</template>

<script>
import Vue from 'vue';

export default {
  name: 'Persons',
  data () {
    return {
        persons: []
    }
  },
  methods: {
      getPersons: function() {
                let personsApi = process.env.PERSON_API;
                Vue.axios.get(personsApi).then(
                    (response) => {
                        console.log(response)
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
  },
  mounted() {
      this.getPersons();
  }
}
</script>


<style>
.Table_Header {
    color: red;
}

#Main_Header {
    background-color: blue;
}

h2 {
    text-shadow: 2px 2px #000000;
}
</style>