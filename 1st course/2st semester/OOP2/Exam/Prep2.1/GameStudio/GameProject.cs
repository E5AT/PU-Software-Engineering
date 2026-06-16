using System;

namespace GameStudio;

public class GameProject
{
    public string Name
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentOutOfRangeException(nameof(value));
            field = value;
        }
    }

    private GameEngine? _gameEngine ;
    private List<GameAsset> _gameAssets = new();
    private List<Developer> _developers = new();

    public int GetGameAssetsCount => _gameAssets.Count;
    public int GetDeveloperCount => _developers.Count;

    public GameProject(string name)
    {
        Name = name;
        _gameEngine = default(GameEngine);
    }

    public GameProject(string name, GameEngine gameEngine)
    {
        Name = name;
        _gameEngine = gameEngine;
    }

    public void AddGameAsset(GameAsset gameAsset)
    {
        if(gameAsset is null || _gameEngine is null ||GetGameAssetsCount == _gameEngine.Capacity)
            throw new InvalidOperationException();
        
        _gameAssets.Add(gameAsset);
    }

    public void AddDeveloper(Developer developer)
    {
        if(developer is null)
            throw new InvalidOperationException();

        _developers.Add(developer);
    }

    public override bool Equals(object? obj)
    {
        if(obj is GameProject otherProject)
            return this.Name.Equals(otherProject.Name);
        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
