# API_Juntos
Migrations:
dotnet ef --startup-project ./API_e-commerce_Juntos/API_e-commerce_Juntos.csproj  migrations add TabelaClientes -p ./API_Juntos.Infra/API_Juntos.Infra.csproj

dotnet ef database update --project ./API_e-commerce_Juntos 