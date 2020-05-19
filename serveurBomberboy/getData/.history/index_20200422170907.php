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
        foreach ($allResults as $key => $value){
            echo $key;
        }
        foreach ($allResults as &$value) {
            echo '<p>id</p>';
            echo '<p>', $value['id'], '</p>';
            echo '<p>player</p>';
            echo '<p>', $value['player'], '</p>';
            echo '<p>downControl</p>';
            echo '<p>', $value['downControl'], '</p>';
            echo '<p>upControl</p>';
            echo '<p>', $value['upControl'], '</p>';
            echo '<p>leftControl</p>';
            echo '<p>', $value['leftControl'], '</p>';
            echo '<p>rightControl</p>';
            echo '<p>', $value['rightControl'], '</p>';
            echo '<p>dropControl</p>';
            echo '<p>', $value['dropControl'], '</p>';
        }
        ?>
    </p>
</body>