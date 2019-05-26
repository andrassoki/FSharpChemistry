module Function
open Query

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
        
    let SplitSubstance (name : string) (index : string) =
        let record = (GetSubstanceDataInfo name).ToString().Split(',')
        let mutable RecordList = [ ]
        for i in record do
            RecordList <- [i] |> List.append RecordList
        let recordLength = RecordList.Item(index |> int).Length
        let mutable record = (RecordList.Item(index |> int).ToString().Remove(0,1))
        match index with
            | "0" -> record <- record.Remove(0,1)   | "2" -> record <- record
            | "1" -> record <- record               | "3" -> record <- record                      
            | "4" -> record <- (RecordList.Item(index |> int).ToString().Remove(recordLength-2,2)).Remove(0,1)
        record |> string
        
    let atomicDivide (m : double) (M : double) =
        let result = (m/M) |> string
        result
        
    let Formula (name: string) (x: double) (y: double) (f: double) =
        let result = (f + (x*y)) |> string
        result    
    
    let whichPhase phase =
        let mutable unitType = ""
        match phase with
            | "liquid" -> unitType <- "ml"  | "solid" -> unitType <- "g"  | "gas" -> unitType <- "g"           
        unitType