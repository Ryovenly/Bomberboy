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
?>

<!DOCTYPE html>

<body>
    <p>
        <?php
        foreach ($allResults as &$player) {
            foreach ($player as $key => $value) {
                $statement = $connectionQQM->prepare("UPDATE utilisateur SET ".$key." = ", $_GET[$key], " WHERE player = ", $_GET['player']);
                $statement->execute();
            }
        }
        ?>
    </p>
</body>