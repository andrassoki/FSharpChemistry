# Periodic Table – F Sharp

This project was made to get an introduction into F# programming language. We are two students and this is our first programming project that we want to share with the GitHub community. Any feedbacks are welcome and would be appreciate so maybe we can learn from you and improve our skills. Please note that the periodic table is still unfinished.

**About**

This project is a simple demonstration on how you can handle databases with F# logic on a WinForms UI.

This is the main window of the application. On the left side you can browse the elements of the periodic table. If you choose an element from the list you can see the data of that under the „Data" group. You can even search between the elements and filter them by certain values. You are able to make calculations aswell.
![alt text][01]

You can add custom substances to the database aswell. You can delete or modify any records.
![alt text][02]

You can create charts with the application as well.
![alt text][03]

**Setup**

You need to install Microsoft SQL Server 2017 and SQL Server Management Studio v18.0 in order to be able to set up your server on your own PC.
Follow the instructions on this [link.](https://www.youtube.com/watch?v=yasfZuou3zI)

Start Microsoft SQL Server Management Studio. The sign-in window will appear. At the „Server name"; type „localhost" because in the code, the server name is referenced to this. If any problem occurs and you are not able to change the default server name just let it default then. In this case you have to change the connection string in the code too. Click on the „Connect" button.

On the left side you can see the „Object Explorer" under the server name there is a folder named „Databases" click on it with right mouse button and choose „New Database..".

On the next window you need to give a name to your database at „Database name". Type „database" in the „Database name" section, this how it is referenced in our project. Of couse you can type any name but than don't forget to modify it in the project. Click on „OK" button.

Now you can see your newly created database in the „Object Explorer" under the „Datebase" folder.

Open the sql file that is included in the project. Click on „File" then click on „Open" and finally „File..." and browse the .sql file.

After it is opened in a new tab you will see the sql code.

Click on „Execute" and it will create the tables and it will insert the proper datas.

You will get a message at the bottom of the screen: „Query executed successfully". Now if you go on the „database" in the „Object Explorer" and click on „Tables" folder you can see the added tables. Their name: dbo.Periodic_Table and dbo.Substance_Table.

Now everything is set to build the project on your machine. Start Visual Studio, browse the project files and build the application.

If you need to change de connection string in the code then just copy your default server name from the SQL Server Management Studio. In the code itself you have to change it in the Query.fs and Program.fs.

Search the line type MyDB = SqlDataConnection<"server=localhost;database=database;Integrated Security=true;"> in both files and change the „localhost" to your default server name.

**Challanges**

Our application mainly uses database operations. There are a lot of records to be retrieved from the database. The problem was that different records mean different querys in theory. Most of the querys are almost the same except one certain word or line.

```fsharp
    let GetElementDataInfo name =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
            where (name = c.Names)
            select (c.Phase)
        }
        |> Seq.toList
```

```fsharp
    let GetElementDataInfo name =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
            where (name = c.Names)
            select (c.Weights)
        }
        |> Seq.toList
```

We created a function that uses only one query to select one expected row and adds it to a list but the whole row then will be one item of the that list. In addition, some unwanted characters are inserted into the list items. We handled this problem with string operations for example Remove() or Split().  The function goes through the row and splits that into another list and then removes the unwanted brackets.

```fsharp
    let SplitRecord (name : string) (index : string) =
        let record = (GetElementDataInfo name).ToString().Split(',')       
        let mutable RecordList = [ ]
        for i in record do
            RecordList <- [i] |> List.append RecordList        
        let recordLength = RecordList.Item(index |> int).Length
        let mutable record = (RecordList.Item(index |> int).ToString().Remove(0,1))
        match index with
            | "0" -> record <- record.Remove(0,1)   | "3" -> record <- record   | "6" -> record <- record
            | "1" -> record <- record               | "4" -> record <- record   | "7" -> record <- record
            | "2" -> record <- record               | "5" -> record <- record   
            | "8" -> record <- (RecordList.Item(index |> int).ToString().Remove(recordLength-2,2)).Remove(0,1)
        record |> string
```

Summing, we managed to solve the data retrieving with only one query and one function that has one argument, a number. From that number it returns only one record of a specific row and that was exactly what we needed.

Another challange was to use querys properly to get back the proper data. [MSDN](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/query-expressions) helped the a lot with it.

**Remaining challanges**

One of the main challanges is to finish and extend the database records. Furthermore, we want to adapt the whole application under WPF UI and later the application might be ported to android phones. One thing that we should have done differently is the version control. Since we worked in a team on this application it would helped us a lot if we used GitHub but we discovered too late how useful that is. In our future projects we will definitely use some sort of version control.

**Final words**

We have learned a lot by creating this application. We really like the syntax and the philosophy behind F#. We learned to work with different languages in the same project and by using F# for months our way of thinking in the coding has changed.

F# as a language has a really great learning curve. I encourage everyone who likes to try out new languages to learn F#. Hope that our project will help you to get know with the basics.

[01]: https://i.imgur.com/NwvB9Me.png "001"
[02]: https://i.imgur.com/IyqS56G.png "002"
[03]: https://i.imgur.com/qbvHGK7.png "003"