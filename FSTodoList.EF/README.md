# Generating entities

```bash
cd FSTodoList.EF
dotnet-ef dbcontext scaffold "server=********;user id=********;password=********;database=********;Convert Zero Datetime=True;" Pomelo.EntityFrameworkCore.MySql -o ./Models
```