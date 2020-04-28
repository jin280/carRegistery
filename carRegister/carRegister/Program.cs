using System;
using System.Collections.Generic;

namespace carRegister
{
	class Program
	{
		public static List<string[]> addCar(List<string[]> registry){
			Console.WriteLine("Add vehicle to register.");
			// ask user abouut the information needed to save a car
			// not much error handling here, though it would be needed for better functionality
			Console.WriteLine("Vehicle registration plate:");
			string licenceplate = Console.ReadLine();
			Console.WriteLine("Manufacture:");
			string manufacture = Console.ReadLine();
			Console.WriteLine("Model:");
			string model = Console.ReadLine();
			Console.WriteLine("Year:");
			string year = Console.ReadLine();
			Console.WriteLine("Name of the owner:");
			string ownerName = Console.ReadLine();
			Console.WriteLine("Contact information of the owner:");
			string ownerContact = Console.ReadLine();
			
			//add all the information to an array
			string[] owner = new string[6] { licenceplate,manufacture,model,year,ownerName,ownerContact};
			
			//add information to registry and return registry
			registry.Add(owner);
			return registry;
		}
		
		// displays the current registry list in console
		public static void showRegistry(List<string[]> registry){
			Console.WriteLine("Displaying registry.");
			Console.WriteLine("Plate, Manufacture, Model, Year, Owner, Contact");
			for(int i=0; i<registry.Count; i++){
				for(int a=0; a<6; a++){
					Console.Write(registry[i][a]+", ");
				}
				Console.Write("\n");
			}
		}
		
		public static void searchCar(List<string[]> registry){
			bool match = false; //to check if any registry value match the search word
			Console.WriteLine("Search:");
			string search = Console.ReadLine();
			for(int i=0; i<registry.Count; i++){
				for(int a=0; a<6; a++){
					string car = registry[i][a];
					bool isContained = car.IndexOf(search, StringComparison.OrdinalIgnoreCase)>= 0 ;
					if (isContained){
						for(int b=0; b<6; b++){
							Console.Write(registry[i][b]+" ");
						}
						match = true;
					}
				}
				Console.Write("\n");
			}
			if (match==false){
				Console.WriteLine("No matching car found. Try again.");
			}
		}
		
		public static void Main(string[] args)
		{
			List<string[]> registry = new List<string[]>();
			int i=0;
			Console.Write("Welcome to car registry program. \nYou can add cars to your registry, as well as search and display the registry.\n");
			while (i==0){
				Console.Write("\n");
				Console.WriteLine("Option 1: Add car to registry");
				Console.WriteLine("Option 2: Display registery");
				Console.WriteLine("Option 3: Search in registery");
				Console.WriteLine("Option 4: Exit program");
				Console.WriteLine("Choose:");
				string choice = Console.ReadLine();
				switch(choice)
				{
					case "1":
						registry=addCar(registry);
						break;
					case "2":
						showRegistry(registry);
						break;
					case "3":
						searchCar(registry);
						break;
					case "4":
						i=1;
						Console.WriteLine("Exiting program.");
						break;
					default:
						Console.WriteLine("Wrong choise, choose again!");
						break;
				}

			}
		}
	}
}