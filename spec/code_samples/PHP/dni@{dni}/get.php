$dni = '00000001';
$token = 'YOUR-TOKEN';

$json = file_get_contents('http://consulta.pe/api/v1/dni/'.$dni.'?token='.$token);

$person = json_decode($json);
