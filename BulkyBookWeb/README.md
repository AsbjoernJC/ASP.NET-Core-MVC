## Opening up a localDB in SSMS (Sql Server management systeem)
1. Verify that sqllocaldb is installed ```sqllocaldb```
1. Insert this into "Server name:" ```(localdb)\MSSQLLocalDB```

## Generating the SQL database
1. Open the nuget package manager console
1. Run ```add-migration AddCategoryToDatabase``` in the console
1. Run ```update-database```