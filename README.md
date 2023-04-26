# Part-1 
A list of how I(Loyiso Ndlovu_ST10161873) compiled the code and what each class has:

Ingredient class:
ToString(): returns a string representation of the ingredient.
Step class:
Constructor: initializes the Description property.
Recipe class:
AddIngredient(string name, double quantity, string unit): creates a new Ingredient object and adds it to the Ingredients list.
AddStep(string description): creates a new Step object and adds it to the Steps list.
PrintRecipe(): prints the recipe to the console.
ScaleRecipe(double factor): scales all the ingredient quantities by the specified factor.
ResetQuantities(): resets all the ingredient quantities to their original values.
Clear(): clears all the ingredients and steps from the recipe.
Program class:
Constructor: creates a new Recipe object.
Run(): runs the program and prompts the user for input.
AddIngredient(): prompts the user for the ingredient's name, quantity, and unit of measurement, and adds it to the recipe.
AddStep(): prompts the user for the step's description and adds it to the recipe.
PrintRecipe(): calls the PrintRecipe method of the Recipe object.
ScaleRecipe(): prompts the user for the scaling factor and calls the ScaleRecipe method of the Recipe object.
ResetQuantities(): calls the ResetQuantities method of the Recipe object.
ClearRecipe(): calls the Clear method of the Recipe object.


Assignment
1. The user shall be able to enter the details for a single recipe:
a. The number of ingredients.
b. For each ingredient: the name, quantity, and unit of measurement. For example, one
tablespoon of sugar.
c. The number of steps.
d. For each step: a description of what the user should do.
2. The software shall display the full recipe, including the ingredients and steps, in a neat 
format to the user.
3. The user shall be able to request that the recipe is scaled by a factor of 0.5 (half), 2 (double) 
or 3 (triple). All the ingredient quantities shall be changed accordingly when the recipe is 
displayed. For example, our one tablespoon of sugar will become two tablespoons of sugar 
if the factor is 2.
4. The user can request that the quantities be reset to the original values.
5. The user shall be able to clear all the data to enter a new recipe.
6. The software shall not persist the user data between runs. The data shall only be stored in 
memory while the software is running.

Non-functional requirements:
1. You are required to use internationally acceptable coding standards. Include 
comprehensive comments explaining variable names, methods, and the logic of 
programming code.
2. You are required to use classes. 
3. Store the ingredients and steps in arrays.
