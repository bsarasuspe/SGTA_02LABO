Module ProbatuDatuAtzipena

    Sub Main()

        Console.WriteLine("Konexioa egin:")
        DatuAtzipenekoak.DatuAtzipena.Konektatu()

        Console.WriteLine("Erabiltzailea sartu:") 'KOMENTATUTA DAGO DAGOENEKO TXERTATUTA DAGOELAKO
        Console.WriteLine(DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaTxertatu("popeye2@gmail.com", "Popeye2", "None", "Kaixo", "Erantzuna", "72593749", "123", "0", "A", "B", "Erab", "Pass"))

        Console.WriteLine("Erabiltzailea lortu:")
        Console.WriteLine(DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaLortu("popeye@gmail.com"))

        Console.WriteLine("Erabiltzailea egiaztatu:")
        Console.WriteLine(DatuAtzipenekoak.DatuAtzipena.ErabiltzaileaEgiaztatu("popeye@gmail.com"))

        Console.WriteLine("Erabiltzailearen pasahitza aldatu:")
        Console.WriteLine(DatuAtzipenekoak.DatuAtzipena.ErabiltzailearenPasahitzaAldatu("popeye@gmail.com", "Pass2"))

        Console.WriteLine("Konexioa itxi:")
        DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()

    End Sub

End Module
