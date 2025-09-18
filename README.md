# GroceryApp sprint2 

## Docentversie  
In deze versie zijn de wijzigingen doorgevoerd en is de code compleet.  

## Studentversie:  
### UC04 Kiezen kleur boodschappenlijst  
Is compleet.

### UC05 Product op boodschappenlijst plaatsen:   
- `GetAvailableProducts()`  
	De header van de functie bestaat maar de inhoud niet.  
	Zorg dat je een lijst maakt met de beschikbare producten (dit zijn producten waarvan nog voorraad bestaat en die niet al op de boodschappenlijst staat).  
- `AddProduct()`   
	Zorg dat het gekozen beschikbare product op de boodschappenlijst komt (door middel van de GroceryListItemsService).  

### UC06 Inloggen  
Een collega is ziek maar heeft al een deel van de inlogfunctionaliteit gemaakt.  
Dit betreft het Loginscherm (LoginView) met bijbehorend ViewModel (LoginViewModel),  
maar ook al een deel van de authenticatieService (AuthService in Grocery.Core),  
de clientrepository (ClientRepository in Grocery.Core.Data)  
en de client class (Client in Grocery.Core).  
De opdracht is om zelfstandig de login functionaliteit te laten werken.  

*Stappenplan:*  
1. Begin met de Client class en zorg dat er gebruik wordt gemaakt van Properties.  
2. In de ClienRepository wordt nu steeds een vaste client uit de lijst geretourneerd. Werk dit uit zodat de juiste Client wordt geretourneerd.  
3. Werk de klasse AuthService verder uit, zodat daadwerkelijk de controle op het ingevoerde password wordt uitgevoerd.
4. Zorg dat de LoginView.xaml wordt toegevoegd aan het Grocery.App project in de Views folder (Add ExistingItem). De file bevindt zich al op deze plek, maar wordt nu niet meegecompileerd.  
5. In MauiProgramm class van de Grocery.App staan de registraties van de AuthService en de LoginView in comment --> haal de // weg.  
6. In App.xaml.cs staat /*LoginViewModel viewModel*/ haal hier /* en */ weg, zodat het LoginViewModel beschikbaar komt.  
7. In App.xaml.cs staat //MainPage = new LoginView(viewModel); Haal hier de // weg en zet de regel erboven in commentaar, zodat AppShell wordt uitgeschakeld.  
8. Uncomment de route naar het Login scherm in AppShell.xaml.cs: //Routing.RegisterRoute("Login", typeof(LoginView)); 

## Gitflow
- - - 
Voor deze repository wordt **GitFlow** gebruikt om het ontwikkelproces te structureren en overzichtelijk te houden.

### Branches

-  **`main`**  
    - Bevat de stabiele code die volledig getest en gereed is voor productie.
    - Alleen code die via `develop` is goedgekeurd komt uiteindelijk in `main`.


- **`develop`**
  - Hier staat de code die klaar is om getest te worden en als basis dient voor nieuwe features.

  
- **`feature/naam_van_feature`**  
    - Voor elke use case of nieuwe feature wordt een aparte feature branch aangemaakt vanaf `develop`.
    - Na afronding wordt de feature branch terug gemerged naar `develop`.
    - **Belangrijk:** wanneer een feature branch volledig gemerged is, moet deze verwijderd worden om de repository schoon te houden.


### Branch / Commit / Merge Request Conventies
Om ervoor te zorgen dat de github repository overzichtelijk blijft, zijn de volgende naming conventies van kracht:

- Branches:
  - `feature/naam_van_feature`
  - `bugfix/naam_van_bugfix`
  - `hotfix/naam_van_hotfix`


- Commit
  - Geef een duidelijke omschrijving van de commit.


- Merge Request
  - Geef een duidelijke omschrijving van de Merge Request (Pull Request)
  - Assign jezelf als Assignee
  - De reviewer moet de code reviewen en goedkeuren