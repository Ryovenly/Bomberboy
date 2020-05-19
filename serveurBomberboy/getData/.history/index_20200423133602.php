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

<?php while ($utilisateur = $dataPlayer->fetch()) { ?>
    {
    "player":"<?= $utilisateur['player'] ?>"
    "downControl": "<?= $utilisateur['downControl'] ?>"
    "upControl": "<?= $utilisateur['upControl'] ?>"
    "leftControl": "<?= $utilisateur['leftControl'] ?>"
    "rightControl": "<?= $utilisateur['rightControl'] ?>"
    }
<?php } ?>

<?php while ($player = $dataPlayer->fetch()) { ?>
    {
    "id":"<?= $player['id'] ?>",
    "input_top": "<?= $player['input_top'] ?>",
    "input_bot": "<?= $player['input_bot'] ?>",
    "input_left": "<?= $player['input_left'] ?>",
    "input_right": "<?= $player['input_right'] ?>",
    }
<?php } ?>