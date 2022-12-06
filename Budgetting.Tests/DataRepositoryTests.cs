namespace Budgetting.Tests;

using Budgetting.Data;
using Budgetting.Models;
using Budgetting.ViewModels;

#nullable disable

[TestFixture]
public class DataRepositoryTests
{
    private DatabaseRepository databaseRepository;

    [SetUp]
    public void Setup()
    {
        databaseRepository = new DatabaseRepository();
    }

    [Test]
    public void GetProfile()
    {
        Profile profile = this.databaseRepository.GetProfile("test","test");

        Assert.NotNull(profile,"Test Profile does not exists");
    }

    [Test]
    public void CannotFindInvalidProfile()
    {
        Profile profile = this.databaseRepository.GetProfile("","");

        Assert.Null(profile,"Invalid profile exists");
    }

    [Test]
    public void CannotFindInvalidProfileById()
    {
        Profile profile = this.databaseRepository.GetProfile(0);

        Assert.Null(profile,"Invalid profile exists");
    }

    [Test]
    public void CreateProfile()
    {
        NewProfile newProfile = new NewProfile()
            {
                Username = this.GenerateRandomString(),
                Password = this.GenerateRandomString()
            };

        Profile profile = this.databaseRepository.CreateProfile(newProfile);

        Assert.NotNull(profile,"Cannot create new profile");
    }

    [Test]
    public void CannotCreateInvalidProfile()
    {
        Profile profile = this.databaseRepository.CreateProfile(
            new NewProfile()
            {
                Username = "",
                Password = ""
            }
        );

        Assert.Null(profile,"Can create invalid profile");
    }

    private string GenerateRandomString()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        var stringChars = new char[25];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        string finalString = new string(stringChars);

        return finalString;
    }
}
