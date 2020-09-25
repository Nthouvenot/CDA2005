<?php 
    namespace InitiationObjets;
    require './personne.php';
    class employe extends personne {
        private int $_numEmp;
        
        function __construct($nom, $prenom, $email, $adresse, $numEmp) {
            parent::__construct($nom, $prenom, $email, $adresse);
            $this->_numEmp = $numEmp;
        }
        
        function GetEmploye() {
            echo $this->GetPersonne().' numero employé: '.$this->_numEmp;
        }
        
        function GetAdresse() {
            return $this->_adresse;
        }
        
        /* nous avons pas besoins de réecrire la méthode SetAdresse elle est disponible directement dans la classe employee car
        celle-ci herite de personne **/
        
        function GetNum() {
            return $this->_numEmp;
        }
        
        function SetNum($numEmp) {
            $this->_numEmp = $numEmp;
        }
    }

?>;