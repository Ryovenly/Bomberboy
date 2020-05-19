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

$statement= $db->query('SELECT * FROM player');
// ?>

<?php while ($player = $statement->fetch()) { ?>
    <div><?= $player['player'] ?></div>
    <?= $player["downControl"] ?>
    <?= $player['upControl'] ?>
    <?= $player['leftControl'] ?>
    <?= $player['rightControl'] ?>
<?php } ?>