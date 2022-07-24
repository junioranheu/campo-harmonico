List<string> campoHarmonicoA = new(new string[] { "A", "Bm", "C#m", "D", "E", "F#" });
List<string> campoHarmonicoB = new(new string[] { "B", "C#m", "D#m", "E", "F#", "G#m" });
List<string> campoHarmonicoC = new(new string[] { "C", "Dm", "Em", "F", "G", "Am" });
List<string> campoHarmonicoD = new(new string[] { "D", "Em", "F#m", "G", "A", "Bm" });
List<string> campoHarmonicoE = new(new string[] { "E", "F#m", "G#m", "A", "B", "C#m" });
List<string> campoHarmonicoF = new(new string[] { "F", "Gm", "Am", "A#", "C", "Dm" });
List<string> campoHarmonicoG = new(new string[] { "G", "Am", "Bm", "C", "D", "Em" });
List<List<string>> listaCamposHarmonicos = new(new List<string>[] { campoHarmonicoA, campoHarmonicoB, campoHarmonicoC, campoHarmonicoD, campoHarmonicoE, campoHarmonicoF, campoHarmonicoG });

foreach (var campo in listaCamposHarmonicos)
{
    Console.WriteLine($"Campo harmonico de {campo[0]}");

    // foreach (var nota in campo.OrderBy(a => Guid.NewGuid()).ToList())
    foreach (var nota in campo)
    {
        Console.WriteLine(nota);
    }
}

Console.ReadKey();