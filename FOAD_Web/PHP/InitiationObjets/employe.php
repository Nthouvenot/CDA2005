<?php 
    namespace InitiationObjets;
    require_once './personne.php';
    class employe extends personne {
        private int $_numEmp;
        
        public function __construct($nom, $prenom, $email, $adresse) {
            parent::__construct($nom, $prenom, $email, $adresse);
            $this->_numEmp = 0;
        }
        
        public function GetEmploye() {
            echo $this->GetPersonne().' numero employé: '.$this->_numEmp;
        }
        
        public function GetAdresse() {
            return $this->_adresse;
        }
        
        /* nous avons pas besoins de réecrire la méthode SetAdresse elle est disponible directement dans la classe employee car
        celle-ci herite de personne **/
        
        public function GetNum() {
            return $this->_numEmp;
        }
        
        public function SetNum($numEmp) {
            $this->_numEmp = $numEmp;
        }
        
        public function __destruct() {
            echo 'L\'objet de type employe a bien été détruit<br>';
        }
    }

?>;