using Newtonsoft.Json;

namespace stateGuesser;

class Program {
    public static void Main() {
        Random rand = new Random();
        Console.WriteLine("Shit state guesser gaem");

        //string test = "ok";

        dynamic? stateObj = JsonConvert.DeserializeObject(File.ReadAllText("./states.json"));

        int amount = stateObj?.amount - 1;
        int stateIndex = rand.Next(0, amount);
        string? state = stateObj?.states[stateIndex].state;
        string? st = stateObj?.states[stateIndex].stereotype;

        Console.WriteLine($"Stereotype:\n{st}\n");
        Console.Write("What state is this? >>> ");
        string? guess = Console.ReadLine();

        if (guess?.ToLower() == state) {
            Console.WriteLine($"you are correct!\nState: {state}");
        } else {
            Console.WriteLine($"you are wrong!\nState: {state}");
        }


    }
}