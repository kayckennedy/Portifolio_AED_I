interface ICriptografavel{
  string ChaveCriptografia {get; set;}
  void Criptografar();
  void Descriptografar();
}