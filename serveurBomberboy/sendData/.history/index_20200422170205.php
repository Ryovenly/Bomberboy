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



$statement = $connectionQQM->prepare("UPDATE utilisateur SET nom_colonne_1 = 'nouvelle valeur' WHERE player=");
$statement->execute();
?>

<!DOCTYPE html>

<body>
    <p>
        <?php
        echo $_GET['player'];
        ?>
    </p>
</body>