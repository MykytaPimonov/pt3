using pt3;

Work work = new Work();

Company? c2 = work.get();

Console.WriteLine(c2);

Company c1 = new Company(
    "Google",
    "USA",
    "Techno",
    1000, 
    38484538568542345L
);

work.save(c1);