<?php
    namespace InitiationObjets;
    require('./personne.php');
?>
<!DOCTYPE HTML>
<html lang="fr">
	<head>
		<meta charset="UTF-8"/>
		<title>Initiation Objet</title>
	</head>
	<body>
		<h1 style="text-align: center;">Bienvenue sur ma démo sur les objet en PHP</h1>
		<p>
		<?php 
		
		    $personne1 = new Personne('nicolas', 'thouvenot','mon_mail@mail.com', 'mon_adresse');
		    $personne1->SetEmail('nicolas.thouvenot@mail.com');
		    $personne1->SetAdresse('2 Rue General de Gaulle 52630 Grandchamp');
		    echo 'donnée de personne 1 :'.$personne1->GetPersonne().'<br>';
		    echo 'affichage de l\'objet personne1 :<br>';
		    var_dump($personne1);
        ?>
        </p>
	</body>
</html>
