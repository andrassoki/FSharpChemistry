module Query
open FSharp.Data.TypeProviders
open FSharp.Data.Sql
type MyDB = SqlDataConnection<"server=localhost;database=database;Integrated Security=true;">

    let GetElementDataInfo name =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
            where (name = c.Names)
            select (c.Number,c.Names,c.ShortName,c.Weights,c.Density,c.Group_ID,c.Peroid,c.Phase,c.Discovered)
        }
        |> Seq.toList

    let GetSubstanceDataInfo name =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Substance_Table do
            where (name = c.Substance_Name)
            select (c.Substance_ID,c.Substance_Name,c.Substance_Formula,c.Substance_Molar_Mass,c.Substance_Density)
        }
        |> Seq.toList

    let GetHowManySolidPhase phase =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                where (c.Phase = phase)
                select c.Number
        }
        |> Seq.length

    let SearchByNames name =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                where (c.Names.Contains(name))
                select c.Names
        }
        |> Seq.toArray

    let SearchByShortNames name =
        use ctx = MyDB.GetDataContext ()     
        query {
            for c in ctx.Periodic_Table do
                where (c.ShortName.Equals(name))
                select c.Names
        }
        |> Seq.toArray                           

    let GetAllPeriods =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                select c.Peroid
        }
        |> Seq.distinct
        |> Seq.toArray
        
    let FillComboBox =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                select c.Phase
        }
        |> Seq.distinct
        |> Seq.toArray

    let GetComboGroup =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                select c.Group_ID
        }
        |> Seq.distinct
        |> Seq.toArray

    let GetElementByGroup group =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                where (c.Group_ID = group)
                select c.Names
        }
        |> Seq.sort
        |> Seq.toArray

    let GetElementByPhase phase =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                where (c.Phase = phase)
                select c.Names
        }
        |> Seq.sort
        |> Seq.toArray

    let GetElementsByPeriod period =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                where (c.Peroid = period)
                select c.Names
        }
        |> Seq.sort
        |> Seq.toArray

    let GetDiscoveredGreater year =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                where (c.Discovered > year)
                select c.Names
        }
        |> Seq.toArray

    let GetDiscoveredLesser year =
        use ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Periodic_Table do
                where (c.Discovered < year)
                select c.Names
        }
        |> Seq.toArray 

   let GetSubstanceMaxId =
        let ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Substance_Table do
                select c.Substance_ID
            }
            |> Seq.max

    let GetSubstanceIdForDelete name =
        let ctx = MyDB.GetDataContext ()
        query {
            for c in ctx.Substance_Table do
            where (c.Substance_Name = name)
            select c.Substance_ID
            head
        }  