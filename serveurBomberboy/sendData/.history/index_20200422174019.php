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

echo 'SELECT * FROM utilisateur where player = ' . $_GET['player'];
$statement = $connectionQQM->prepare('SELECT * FROM utilisateur where player = bomberboy1');
$statement->execute();
$allResults = $statement->fetchAll(\PDO::FETCH_ASSOC);
?>

<!DOCTYPE html>

<body>
    <p>
        <?php
        foreach ($allResults as $key => $value) {
            echo "UPDATE utilisateur SET " . $key . " = " . $_GET[$key];
            $statement = $connectionQQM->prepare("UPDATE utilisateur SET " . $key . " = " . $_GET[$key]);
            $statement->execute();
        }
        ?>
    </p>
</body>