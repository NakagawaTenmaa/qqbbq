var mysql = require('mysql');

connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'tenko',
    database : 'qqbbq',
    password : 'tenko117'
 });
  
 exports.connection = connection;