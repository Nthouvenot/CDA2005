<?php 
    namespace InitiationObjets;
    class personne {
        private string $_nom;
        private string $_email;
        protected string $_prenom;
        protected string $_adresse;
    
        public function __construct($nom, $prenom, $email, $adresse) {
            $this->_nom = $nom;
            $this->_prenom = $prenom;
            $this-> _email = $email;
            $this->_adresse = $adresse;
        }
    
        public function SetAdresse($adresse) {
            $this->_adresse = $adresse;
        }
    
        public  function SetEmail($email) {
            $this->_email = $email;
        }
    
        public function GetPersonne() {
            echo 'nom: '.$this->_nom.' prenom: '.$this->_prenom.' adresse: '.$this->_adresse.' email: '.$this->_email;
        }
    
        public function __destruct() {
            echo 'L\'objet de type personne a bien été détruit<br>';
        }
    }
?>
