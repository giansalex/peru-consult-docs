$ruc  = '20000000001';
$user = 'MODDATOS';
$token = 'YOUR-TOKEN';

$json = file_get_contents("http://consulta.pe/api/v1/user-sol/$ruc/$user?token=$token");

$isValid = json_decode($json);
