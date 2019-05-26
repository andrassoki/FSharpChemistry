module Logic
open UI
open System.Windows.Forms
open FSharp.Data.TypeProviders
open System
open FSharp.Charting
open FSharp.Data.Sql
open Query
open Function
open System.Data.Linq
type MyDB = SqlDataConnection<"server=localhost;database=database;Integrated Security=true;">
      
[<EntryPoint>]
let main argv =   
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault false
    let form = new MainForm()
    let form2 = new AddForm()   
    
    let year y =
        if (form.rdbGreater.Checked) then
            form.lstBox.DataSource <- GetDiscoveredGreater y           
        if (form.rdbLesser.Checked) then
            form.lstBox.DataSource <- GetDiscoveredLesser y   

    let MolarUpOrDown state =
        if (state = "up") then
            form.txtMolarUp.Clear()
            form.lblMolarUp.Text <- "-"
            form.lblMolarUpUnitType.Text <- "-"
        else
            form.txtMolarDown.Clear()
            form.lblMolarDown.Text <- "-"
            form.lblMolarDownUnitType.Text <- "-"
  
    form.cmbFilter.SelectedIndexChanged.Add
        <| fun arg ->
            let phase = form.cmbFilter.SelectedValue.ToString()
            form.lstBox.DataSource <- GetElementByPhase phase
            ()

    form.cmbPeriod.SelectedIndexChanged.Add
        <| fun arg ->
            let period = form.cmbPeriod.SelectedValue |> string
            form.lstBox.DataSource <- GetElementsByPeriod (period |> int)
            ()           

    form.cmbGroup.SelectedIndexChanged.Add
        <| fun arg ->
            let group = form.cmbGroup.SelectedValue.ToString()
            form.lstBox.DataSource <- GetElementByGroup group
            ()

    form.btnExit.Click.Add
        <| fun arg ->
            Application.Exit()

    form.btnMinimize.Click.Add
        <| fun arg ->
            form.WindowState <- FormWindowState.Minimized 
      
    form.txtSearch.TextChanged.Add
        <| fun arg ->
            if (form.txtSearch.Text = "" && form.chkShortName.Checked = true) then
                let empty = form.txtSearch.Text
                form.lstBox.DataSource <- SearchByNames empty
            else
                if (form.chkShortName.Checked = false) then
                    let name = form.txtSearch.Text
                    form.lstBox.DataSource <- SearchByNames name
                else if (form.chkShortName.Checked = true) then
                    let shortName = form.txtSearch.Text
                    form.lstBox.DataSource <- SearchByShortNames shortName
     
    form.numYear.ValueChanged.Add
        <| fun arg ->
            let y = form.numYear.Value |> int
            year y

    form.rdbGreater.CheckedChanged.Add
        <| fun arg ->
            let y = form.numYear.Value |> int
            year y

    form.Load.Add
        <| fun arg ->
            form.cmbFilter.DataSource <- FillComboBox
            form.cmbGroup.DataSource <- GetComboGroup
            form.cmbPeriod.DataSource <- GetAllPeriods
            form.cmbGroup.SelectedIndex <- 0
            form.rdbGreater.Checked <- true
            form.txtMolarUp.Enabled <- false
            form.txtMolarDown.Enabled <- false
   
    form.btnAddUp.Click.Add
        <| fun arg ->
            let name = form.lstBox.SelectedValue |> string          
            form.lblMolarUpUnitType.Text <- whichPhase (SplitRecord name "7")
            
            if (name <> form.lblMolarUp.Text && name <> form.lblMolarDown.Text) then
                    form.txtMolarUp.Text <- (SplitRecord name "3").ToString()
                    form.lblMolarUp.Text <- SplitRecord name "1"
            else
                form.DialogResult <- MessageBox.Show("The element is already added!")

    form.btnAddDown.Click.Add
        <| fun arg ->
            let name = form.lstBox.SelectedValue |> string          
            form.lblMolarDownUnitType.Text <- whichPhase (SplitRecord name "7")          

            if (name <> form.lblMolarUp.Text && name <> form.lblMolarDown.Text) then
                form.txtMolarDown.Text <- SplitRecord name "3"
                form.lblMolarDown.Text <- SplitRecord name "1"
            else
                form.DialogResult <- MessageBox.Show("The element is already added!")   

    form.lstBox.SelectedIndexChanged.Add
        <| fun arg ->
            let name = form.lstBox.SelectedValue |> string
            let atomicWeight = SplitRecord name "4"
            form.txtAtomicNumber.Text <- SplitRecord name "0"
            form.txtShortName.Text <- SplitRecord name "2"
            form.txtAtomicWeight.Text <- String.Format("{0} g/mol", SplitRecord name "3")
            form.txtDensity.Text <- SplitRecord name "4"
            form.txtGroup.Text <- SplitRecord name "5"
            form.txtPeriod.Text <- SplitRecord name "6"
            form.txtPhase.Text <- SplitRecord name "7"
            form.txtYearDiscovered.Text <- SplitRecord name "8"
            form.txtCalc_n.Clear()
            form.txtCalc_m.Clear()
            form.lblM.Text <- "M= " + String.Format("{0} g/mol",atomicWeight)
            form.lblSelectedName.Text <- form.lstBox.SelectedValue |> string
            form.chkRound.Checked <- false
                      
    form.txtCalc_m.TextChanged.Add
        <| fun arg ->
            let name = form.lstBox.SelectedValue |> string
            form.lblSelectedName.Text <- name
            let atomicWeight = SplitRecord name "3"
            form.lblM.Text <- "M= " + String.Format("{0} g/mol",atomicWeight)
            try
            let m = form.txtCalc_m.Text |> double
            let M = (SplitRecord name "3") |> double
            form.txtCalc_n.Text <- atomicDivide m M      
            with
                | :? System.FormatException -> form.txtCalc_n.Clear()
                
    form.chkRound.CheckStateChanged.Add
        <| fun arg ->
            try
            let name = form.lstBox.SelectedValue |> string
            let m = form.txtCalc_m.Text |> double
            let M = (SplitRecord name "3") |> double

            if (form.chkRound.Checked = false) then
                form.txtCalc_n.Text <- atomicDivide m M          
            else                
                form.txtCalc_n.Text <- Math.Round((atomicDivide m M) |> double, 2) |> string
            with
                | :? System.FormatException -> form.txtCalc_n.Clear()
            if (form.txtCalc_n.Text = "" && form.chkRound.CheckState = CheckState.Checked) then
                form.DialogResult <- MessageBox.Show("Can't round empty value!")
                form.chkRound.CheckState <- CheckState.Unchecked

    form.pnlTop.DoubleClick.Add
        <| fun arg ->
            if (form.WindowState = FormWindowState.Normal) then
                form.WindowState <- FormWindowState.Maximized
            else
                form.WindowState <- FormWindowState.Normal
            
    form.chkShortName.CheckedChanged.Add
        <| fun arg ->
            form.txtSearch.Clear()  

    form.btnFormulaAdd.Click.Add
        <| fun arg ->
            let name = form.lstBox.SelectedValue |> string
            let multiply = form.numFormula.Value |> string
            if (multiply |> int > 1) then
                form.txtFormula.Text <- form.txtFormula.Text + (SplitRecord name "2") + multiply 
            else
                form.txtFormula.Text <- form.txtFormula.Text + (SplitRecord name "2")               
            let formula = form.txtFormulaResult.Text |> double
            let name = form.lstBox.SelectedValue |> string
            let x = form.numFormula.Value |> double
            let y = SplitRecord name "3" |> double
            form.txtFormulaResult.Text <- Formula name x y formula
            
    form.btnFormulaClear.Click.Add
        <| fun arg ->
            form.txtFormula.Clear()
            form.txtFormulaResult.Text <- "0"          

    form.btnMolarUpClear.Click.Add
        <| fun arg ->
            MolarUpOrDown "up"
    form.btnMolarDownClear.Click.Add
        <| fun arg ->
            MolarUpOrDown "down"

    form.btnChart.Click.Add
        <| fun arg ->
            if (form.txtMolarUp.Text <> "" && form.txtMolarDown.Text <> "") then
               
                let a = form.lblMolarUp.Text
                let aNum = form.txtMolarUp.Text |> double
                let b = form.lblMolarDown.Text
                let bNum = form.txtMolarDown.Text |> double
                Chart.Column([ a, aNum; b, bNum;]).ShowChart().Visible <- true
            else
                form.DialogResult <- MessageBox.Show("You have to select two elements!")          

    form.btnAddSubstance.Click.Add
        <| fun arg ->
            form2.Show()

    form2.Load.Add
        <| fun arg ->
            form2.btnModify.Enabled <- false

    form2.btnExit.Click.Add
        <| fun arg ->
            form2.Hide()

    form2.btnMinimize.Click.Add
        <| fun arg ->
            form2.WindowState <- FormWindowState.Minimized  
    
    form2.Load.Add
        <| fun arg ->
            let db = MyDB.GetDataContext()
            form2.txtID.Text <- GetSubstanceMaxId+1 |> string
            form2.lstBox.DataSource <- query {for c in db.Substance_Table do
                                    select c.Substance_Name
                                    }
                                    |> Seq.toArray

    form2.btnCommit.Click.Add
        <| fun arg ->
            let db = MyDB.GetDataContext()      
            let id = form2.txtID.Text
            let name = form2.txtName.Text
            let formula = form2.txtFormula.Text
            let molar = form2.txtMolarMass.Text
            let density = form2.txtDensity.Text          
            try
                db.DataContext.ExecuteCommand("INSERT INTO Substance_Table VALUES (" + id + ",'" + name + "','" + formula + "'," + molar + "," + density + ")") |> ignore                              
            with
                | exn -> form.DialogResult <- MessageBox.Show("Exception: " + exn.Message)                   
            form2.lstBox.DataSource <- query {for c in db.Substance_Table do
                                    select c.Substance_Name
                                    }
                                    |> Seq.toArray

            form2.txtID.Text <- ((form2.txtID.Text |> int) + 1).ToString()

    form2.btnModify.Click.Add
        <| fun arg ->          
            let db = MyDB.GetDataContext()
            let table1 = db.Substance_Table
            let name = form2.lstBox.SelectedValue |> string
            let id = SplitSubstance name "0" |> int32
            let name = form2.txtNameMod.Text
            let formula = form2.txtFormulaMod.Text
            let molar = form2.txtMolarMod.Text |> double
            let density = form2.txtDensityMod.Text |> double

            query { for row in table1 do
                where (row.Substance_ID = id)
                select row }
                |> Seq.iter (fun row ->
                    row.Substance_Name <- name
                    row.Substance_Formula <- formula
                    row.Substance_Molar_Mass <- molar
                    row.Substance_Density <- density)
            try
                db.DataContext.SubmitChanges()
                form.DialogResult <- MessageBox.Show("Successfully updated the rows.")
            with
                | exn -> form.DialogResult <- MessageBox.Show("Exception: " + exn.Message) 

    form2.btnRefresh.Click.Add
        <| fun arg ->
        let db = MyDB.GetDataContext()    
        form2.lstBox.DataSource <- query {for c in db.Substance_Table do
                                    select c.Substance_Name
                                    }
                                    |> Seq.toArray

    form2.btnDelete.Click.Add
        <| fun arg ->
        let db = MyDB.GetDataContext()
        let name = form2.lstBox.SelectedValue.ToString()
        let id = GetSubstanceIdForDelete name
        let deleteRowsFrom (table:Table<_>) rows = table.DeleteAllOnSubmit(rows)

        query {for i in db.Substance_Table do
                where (i.Substance_ID = id)
                select i
        }
        |> deleteRowsFrom db.Substance_Table
        try
            db.DataContext.SubmitChanges()
            form.DialogResult <- MessageBox.Show("Record was succesfully deleted from the datebase.")
        with
            | exn -> form.DialogResult <- MessageBox.Show("Exception: " + exn.Message)
        form2.lstBox.DataSource <- query {for c in db.Substance_Table do
                                    select c.Substance_Name
                                    }
                                    |> Seq.toArray
       
    form2.lstBox.SelectedIndexChanged.Add
        <| fun arg ->
            let db = MyDB.GetDataContext()
            let name = form2.lstBox.SelectedValue |> string
            form2.txtIdMod.Text <- SplitSubstance name "0"
            form2.txtNameMod.Text <- SplitSubstance name "1"
            form2.txtFormulaMod.Text <- SplitSubstance name "2"
            form2.txtMolarMod.Text <- SplitSubstance name "3"
            form2.txtDensityMod.Text <- SplitSubstance name "4"

    form2.addFormTabControl.SelectedIndexChanged.Add
        <| fun arg ->         
            if (form2.addFormTabControl.SelectedIndex = 0) then
                form2.btnModify.Enabled <- false
                form2.btnCommit.Enabled <- true
            else if (form2.addFormTabControl.SelectedIndex = 1) then
                form2.btnModify.Enabled <- true
                form2.btnCommit.Enabled <- false
    
    Application.Run(form)
    0 // return an integer exit code