using System;
using System.Formats.Asn1;

namespace TechSpace;

public class System
{
    private readonly Dictionary<string, Workspace> workspaces = new();
    private readonly Dictionary<string, Client> clients = new();
    private readonly Dictionary<Client, Workspace> activeRentals = new();
    private decimal totalRevenue;

    public void AddWorkspace(Workspace workspace)
    {
        if(workspace is null)
            throw new InvalidOperationException("Cannot add workspace that's null!");
        else if(workspaces.ContainsKey(workspace.Signature))
            throw new InvalidOperationException("There is already a workspace with the same signature!");
        else
            workspaces.Add(workspace.Signature, workspace);
    }

    public void AddClient(Client client)
    {
        if(client is null)
            throw new InvalidOperationException("Cannot add client that's null!");
        else if(clients.ContainsKey(client.Email))
            throw new InvalidOperationException("There is already a client with the same email!");
        else
            clients.Add(client.Email, client);
    }

    public void RentWorkspace(string signature, string email)
    {
        if (!workspaces.TryGetValue(signature, out Workspace? workspace))
            throw new InvalidOperationException("Workspace not found!");
        if (!clients.TryGetValue(email, out Client? client))
            throw new InvalidOperationException("Client not found!");

        if (activeRentals.ContainsKey(client))
            throw new InvalidOperationException("This client is already occupying a workspace!");

        if (workspace.Status != Status.Free)
            throw new InvalidOperationException("This workspace is not available!");

        workspace.Status = Status.Occupied;
        activeRentals.Add(client, workspace);
    }

    public decimal FreeWorkspace(string signature, int duration)
    {
        if (!workspaces.TryGetValue(signature, out Workspace? workspace))
            throw new InvalidOperationException("Workspace not found!");

        if (workspace.Status == Status.Free)
            throw new InvalidOperationException("Workspace is already free!");
        if (workspace.Status == Status.Renovation)
            throw new InvalidOperationException("Workspace is under renovation!");
        
        Client? client = null;
        foreach(var rental in activeRentals)
        {
            if (rental.Value.Equals(workspace))
            {
                client = rental.Key;
                break;
            }
        }

        if(client is not null)
            activeRentals.Remove(client);

        workspace.Status = Status.Free;

        decimal revenue = workspace.CalculatePrice(duration);
        totalRevenue+=revenue;

        return revenue;
    }

    public decimal GetTotalRevenue()
    {
        return totalRevenue;
    }

    public List<Workspace> GetAreasUnderRenovation()
    {
        return workspaces.Values.Where(w => w.Status == Status.Renovation).ToList();
    }

}
