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
// ?>

<?php while ($player = $dataPlayer->fetch()) { ?>
    {
    "player":"<?= $player['player'] ?>"
    "downControl": "<?= $player['downControl'] ?>"
    "upControl": "<?= $player['upControl'] ?>"
    "leftControl": "<?= $player['leftControl'] ?>"
    "rightControl": "<?= $player['rightControl'] ?>"
    }
<?php } ?>
