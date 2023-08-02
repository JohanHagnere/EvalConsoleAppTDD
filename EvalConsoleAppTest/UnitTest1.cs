using ConvertisseurRomain;

namespace EvalConsoleAppTest
{

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

        [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 5 et 8 " +
                              "QUAND je le convertis en nombres romains " +
                              "ALORS j'obtiens V plus <(nombreUnités-5)> fois I")]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestCinqPlusUnité(int nombreUnités)
        {
            var nombreRomain = Convertisseur.Convertir(nombreUnités);

            var suiteDeI = new string('I', nombreUnités - 5);
            Assert.Equal("V" + suiteDeI, nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 9 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens IX")]
        public void TestNeuf()
        {
            const int chiffreArabe = 9;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("IX", nombreRomain);
        }

        [Theory(DisplayName = "ETANT DONNE un nombre <nombreUnités> compris entre 10 et 13 " +
                              "QUAND je le convertis en nombres romains " +
                              "ALORS j'obtiens X plus <(nombreUnités-10)> fois I")]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        public void TestDixPlusUnité(int nombreUnités)
        {
            var nombreRomain = Convertisseur.Convertir(nombreUnités);

            var suiteDeI = new string('I', nombreUnités - 10);
            Assert.Equal("X" + suiteDeI, nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 14 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens XIV")]
        public void TestQuatorze()
        {
            const int chiffreArabe = 14;
            var nombreRomain = Convertisseur.Convertir(chiffreArabe);
            Assert.Equal("XIV", nombreRomain);
        }
    }
}