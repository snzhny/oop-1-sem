using System;
using System.Collections.Generic;
namespace laba_6;

public class Gym : Controller
{
    private readonly int _budget;
    private readonly int _inventoryCapacity;
    public string type { get; set; }
    public List<Inventory> gymInventory { get; private set; }
    public int currentCapacity { get;  set; }
    public int currentBudget { get; private set; }
    public Gym()
    {
        _budget = currentBudget = 100000;
        _inventoryCapacity = 10;
        currentCapacity = 0;
        gymInventory = new List<Inventory>();
    }

    public Gym(int budget)
    {
        _budget = currentBudget = budget;
        _inventoryCapacity = 10;
        currentCapacity = 0;
        gymInventory = new List<Inventory>();
    }

    public Gym(int budget, int inventoryCapacity, params Inventory[]items)
    {
        _budget = budget;
        _inventoryCapacity = inventoryCapacity;
        if(inventoryCapacity>_inventoryCapacity) throw new Exception("The amount of the desired inventory exceeds the budget of the gym!");
        var inverntoryList = items.ToList();
        
        int items_cost = items.Sum(item => item.cost);
        if(items_cost > budget) throw new Exception("The amount of the desired inventory exceeds the budget of the gym!");

        currentBudget = _budget - items_cost;
        gymInventory = inverntoryList;
        currentCapacity = items.Length;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Gym Info: Budget: {_budget}, current budget: {currentBudget}, inventory amount: {currentCapacity}");
        Console.WriteLine("Inventory List");
        foreach (var i in gymInventory) { Console.WriteLine(i.ToString()); }
    }

    public void InventorySort()
    {
        gymInventory = gymInventory.OrderBy(i=> i.cost).ToList();
    }

    public void Add(Inventory item)
    {
        if(item.cost > _budget) throw new Exception("The amount of the desired inventory exceeds the budget of the gym!");
        gymInventory.Add(item);
        currentBudget -= item.cost;
        currentCapacity++;
        InventorySort();
    }
    
    public void Delete(Inventory item)
    {
        gymInventory.Remove(item);
        currentBudget += item.cost;
        currentCapacity--;
        InventorySort();
    }

    
}