using System;

public class Treinador : Pessoa {
    
        private string licencaCBF;
        private int anosExperiencia;
        
        public string LicencaCBF {
            get { return this.licencaCBF; }
            set { this.licencaCBF = value; }
        }
        
        public int AnosExperiencia {
            get { return this.anosExperiencia; }
            set { this.anosExperiencia = value; }
        }
        
}