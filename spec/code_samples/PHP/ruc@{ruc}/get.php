$ruc = '20000000001';
$token = 'YOUR-TOKEN';

$json = file_get_contents('http://consulta.pe/api/v1/ruc/'.$ruc.'?token='.$token);

$company = json_decode($json);
