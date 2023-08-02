namespace ConvertisseurRomain
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
                < 9 => "V" + Convertir(chiffreArabe - 5),
                9 => "IX",
                10 => "X",
                11 => "XI",
                12 => "XII",
                _ => "XIII"
            };
        }
    }
}