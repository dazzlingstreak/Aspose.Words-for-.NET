// For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
Document doc = new Document();
DocumentBuilder builder = new DocumentBuilder(doc);

// Insert a table with a width that takes up half the page width.
Table table = builder.StartTable();

// Insert a few cells
builder.InsertCell();
table.PreferredWidth = PreferredWidth.FromPercent(50);
builder.Writeln("Cell #1");

builder.InsertCell();
builder.Writeln("Cell #2");

builder.InsertCell();
builder.Writeln("Cell #3");

dataDir = dataDir + "Table.PreferredWidth_out_.doc";
           
// Save the document to disk.
doc.Save(dataDir);