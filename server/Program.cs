WebApplication app = WebApplication.Create(args);

List<Stacks> Feast = [
    new(){Name = "Rlvl1", amount =1, hp=80},
    new(){Name = "Rlvl2", amount =1, hp=120},
    new(){Name = "Rlvl3", amount =1, hp=160}


];


app.MapGet("/", Hello);
app.MapGet("/cho", GimmeStacks);

app.Run();


List<Stacks> GimmeStacks()
{

    return Feast;
    

}

static string Hello()
{
    return "Hello";
}
static string NomNomNom()
{
    return "Cho'gath solo bolo";
}