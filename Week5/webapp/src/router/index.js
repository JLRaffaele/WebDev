import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Persons from '@/components/Persons'
import Students from '@/components/Students'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      path: '/home',
      component: Home
    },
    {
      path: '/students',
      name: 'Students',
      component: Students
    },
    {
      path: '/persons',
      name: 'Persons',
      component: Persons
    }
  ]
})
