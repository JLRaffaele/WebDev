<template>
    <div>
        <h1 class="Table_Header">People Table</h1>
    <table>

        <tr>
            <th>Firstname</th>
            <th>Middle Initial</th> 
            <th>Lastname</th>
        </tr>

        <tr>
            <td>Jill</td>
            <td>A</td> 
            <td>Smith</td>
        </tr>

        <tr>
            <td>Eve</td>
            <td>F</td> 
            <td>Jackson</td>
        </tr>

        <tr>
            <td>Beth</td>
            <td>S</td> 
            <td>Wallace</td>
        </tr>

            <td>John</td>
            <td>L</td> 
            <td>Sullivan</td>
        </tr>

        </tr>
            <td>Frank</td>
            <td>T</td> 
            <td>Max</td>
        </tr>


        </table>
    </div>
</template>

<script>
export default {
  name: 'Students',
  data () {
    return {
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