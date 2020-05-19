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
echo $utilisateur[0]['downControl'] . "toreplace";
echo $utilisateur[0]['upControl'] . "toreplace";
echo $utilisateur[0]['leftControl'] . "toreplace";
echo $utilisateur[0]['rightControl'] . "toreplace";
echo $utilisateur[0]['dropControl'] . "toreplace";
?>


