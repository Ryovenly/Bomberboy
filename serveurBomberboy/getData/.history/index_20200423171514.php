<?php
$hostname = 'localhost:3308';
$username = 'root';
$password = 'root';
$database = 'bomberboy';

try {
    $connectionQQM = new PDO('mysql:host=' . $hostname . '; dbname=' . $database, $username, $password);
} catch (PDOException $e) {
    echo '<h1>Une erreur s\'est produite<h1><pre>', $e->getMessage(), '</pre>';
}

$statement = $connectionQQM->prepare("SELECT * FROM utilisateur WHERE player = " . "'" . $_GET['player'] . "'");
$statement->execute();
$utilisateur = $statement->fetchAll(\PDO::FETCH_ASSOC);
// 
?>

<?php

foreach (var array_expression as $utilisateur[0]){
    //commandes
}
foreach (array_expression as $key => $value){
    //commandes
}
echo
        $utilisateur[0]['player'] .
        $utilisateur[0]['downControl'] .
        $utilisateur[0]['upControl'] .
        $utilisateur[0]['leftControl'] .
        $utilisateur[0]['rightControl']

?>


