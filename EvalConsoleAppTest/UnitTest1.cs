namespace EvalConsoleAppTest
{
    public static class Convertisseur
    {
        public static string Convertir(int chiffreArabe)
        {
            return chiffreArabe switch
            {
                <= 3 => new string('I', chiffreArabe),
                4 => "IV",
                5 => "V",
                _ => "VI"
            };
        }
    }

    public class UnitTest1
    {
        [Theory(DisplayName = "ETANT DONNE le chiffre <nombreUnités> " +
                              "QUAND je le convertis en nombres romains " +
                              "ALORS j'obtiens <nombreUnités> fois I")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnAQuatre(int nombreUnités)
        {
            var nombreRomain = Convertisseur.Convertir(nombreUnités);

            var résultatAttendu = new string(Enumerable.Repeat('I', nombreUnités).ToArray());
            Assert.Equal(résultatAttendu, nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 4 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens IV")]
        public void TestQuatre()
        {
            const int chiffreArabe = 4;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("IV", nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 5 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens V")]
        public void TestCinq()
        {
            const int chiffreArabe = 5;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("V", nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 6 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens VI")]
        public void TestSix()
        {
            const int chiffreArabe = 6;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("VI", nombreRomain);
        }
    }
}