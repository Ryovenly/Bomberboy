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
echo "à" . $utilisateur[0]['player'] . "à";
echo $utilisateur[0]['downControl'] . "à";
echo $utilisateur[0]['upControl'] . "à";
echo $utilisateur[0]['leftControl'] . "à";
echo $utilisateur[0]['rightControl'] . "à";
echo $utilisateur[0]['dropControl'];
?>

