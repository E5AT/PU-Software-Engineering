using System;

namespace GameStudio;

public class GameStudio
{
    public string Name
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    private Dictionary<string, GameProject> _gameProjects = new();
    private List<Designer> _designers = new();
    private int TotalDeveloperCount => _gameProjects.Values.Sum(p => p.GetDeveloperCount);

    public GameStudio(string name)
    {
        Name = name;
    }

    public void AddProject(string name)
    {
        if(_gameProjects.ContainsKey(name))
            throw new InvalidOperationException();
        
        _gameProjects.Add(name, new(name));
    }

    public void AddProject(string name, GameEngine gameEngine)
    {
        if(_gameProjects.ContainsKey(name))
            throw new InvalidOperationException();
        
        _gameProjects.Add(name, new(name, gameEngine));
    }

    public void AddDesigner(Designer designer)
    {
        if(designer is null || _designers.Contains(designer))
            throw new InvalidOperationException();
        
        _designers.Add(designer);
    }

    public void AddGameAsset(GameAsset gameAsset, string projectName)
    {
        if(!_gameProjects.ContainsKey(projectName))
            throw new InvalidOperationException();

        _gameProjects[projectName].AddGameAsset(gameAsset);
    }

    public void AddDeveloper(Developer developer, string projectName)
    {
        if(!_gameProjects.ContainsKey(projectName))
            throw new InvalidOperationException();

        _gameProjects[projectName].AddDeveloper(developer);
    }
}
