namespace EvalConsoleAppTest
{
    public static class Convertisseur
    {
        public static string Convertir(int chiffreArabe)
        {
            switch (chiffreArabe)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                default:
                    return "I";
            }
        }
    }

    public class UnitTest1
    {
        [Fact(DisplayName = "ETANT DONNE le chiffre 1 " +
                                "QUAND je le convertis en nombres romains " +
                                "ALORS j'obtiens I")]
        public void Test1()
        {
            const int chiffreArabe = 1;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("I", nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 2 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens II")]
        public void Test2()
        {
            const int chiffreArabe = 2;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("II", nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 3 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens III")]
        public void Test3()
        {
            const int chiffreArabe = 3;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("III", nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre IV " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens IV")]
        public void Test4()
        {
            const int chiffreArabe = 4;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("IV", nombreRomain);
        }
    }
}