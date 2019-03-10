import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Persons from '@/components/Persons'
import Students from '@/components/Students'
import Callback from '@/components/Callback'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/callback',
      component: Callback
    },
    {
      path: '/home',
      component: Home
    },
    {
      path: '/student',
      name: 'Student',
      component: Students
    },
    {
      path: '/person',
      name: 'Person',
      component: Persons
    }
  ]
})
