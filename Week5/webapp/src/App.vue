<template>
  <div id="app">
    <span v-on:click='goToHome'>Home</span>
    <span v-on:click='goToPersons'>Persons</span>
    <span v-on:click='goToStudents'>Students</span>
    <br>
    <img src="./assets/image.jpg">
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App',
  methods: {
    goToHome: function() {
      this.$router.push({ path: 'home' })
    },
    goToPersons: function() {
      this.$router.push({ path: 'persons' })
    },
    goToStudents: function() {
      this.$router.push({ path: 'students' })
    }
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
