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

$statement = $connectionQQM->prepare('SELECT * FROM utilisateur');
$statement->execute();
$allResults = $statement->fetchAll(\PDO::FETCH_ASSOC);
?>

<!DOCTYPE html>

<body>
    <p>
        <?php
        foreach ($allResults as &$value) {
            foreach ($player as $key => $value) {
                echo '<p>',$key,'</p>';
                echo '<p>',$value[$key],'</p>';
            }
        }
        ?>
    </p>
</body>