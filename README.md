Checkpoint realizado por Vicenzo Castelli e Guilherme Miguel


docker run --name database-mysql -e MYSQL_ROOT_PASSWORD=123 -p 3306:3306 -d mysql
//
docker run --name redis -p 6379:6379 -d redis
