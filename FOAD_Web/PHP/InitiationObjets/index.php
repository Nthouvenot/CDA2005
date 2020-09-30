<?php
    namespace InitiationObjets;
    require_once ('./personne.php');
    require_once ('./employe.php');
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
		
		    $personne1 = new personne('nicolas', 'thouvenot','mon_mail@mail.com', 'mon_adresse');
		    $personne1->SetEmail('nicolas.thouvenot@mail.com');
		    $personne1->SetAdresse('2 Rue General de Gaulle 52630 Grandchamp');
		    echo '<p>donnée de personne 1 :'.$personne1->GetPersonne().'<br>';
		    echo 'affichage de l\'objet personne1 :<br>';
		    var_dump($personne1);
		    echo '</p>';
		    
		    $employe1 = new employe('mickael', 'devoldére','mon_mail@mail.com', 'mon_adresse');
		    $employe1->SetEmail('mdevoldere@mail.fr');
		    $employe1->SetAdresse('57 rue Albert-Camu 68200 Mulhouse');
		    $employe1->SetNum(1540);
		    echo '<p>donnée de employe 1 :'.$employe1->GetEmploye().'<br>';
		    echo 'affichage de l\'objet personne1 :<br>';
		    var_dump($employe1);
		    echo '</p>';
        ?>
        </p>
	</body>
</html>
