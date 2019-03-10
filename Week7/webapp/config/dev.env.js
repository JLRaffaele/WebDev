'use strict'
const merge = require('webpack-merge')
const prodEnv = require('./prod.env')

module.exports = merge(prodEnv, {
  NODE_ENV: '"development"',
  STUDENT_API: '"http://192.168.99.100/api/student"',
  PERSON_API: '"http://192.168.99.100/api/person"'
})
