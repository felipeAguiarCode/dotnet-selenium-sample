```bash
# cria uma solução
dotnet new sln --name "Selenium.app"

# cria um global json
dotnet new globaljson

# cria um projeto
dotnet new console -o "Selenium.App"

# referencia na solução
dotnet sln add "Selenium.App/Selenium.App.csproj"

# rodando o projeto
dotnet run --project Selenium.App

# adiciona pacotes
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
```
