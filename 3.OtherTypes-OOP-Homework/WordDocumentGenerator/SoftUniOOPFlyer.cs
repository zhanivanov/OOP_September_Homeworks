using Novacode;
using System;
using System.Diagnostics;
using System.Drawing;

class SoftUniOOPFlyer
{
    private string fileName;

    public SoftUniOOPFlyer(string fileName)
    {
        this.FileName = fileName;
    }

    public string FileName 
    {
        get { return this.fileName; } 
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("File name cannot be empty string!!!");
            }
            else
            {
                this.fileName = value;
            }
        }
    }

    public void CreateFlyer()
    {
        var doc = DocX.Create(this.fileName);

        var headLineText = "SoftUni OOP Game Contest";
        var headlineFormat = new Formatting();
        headlineFormat.Size = 18D;
        headlineFormat.FontFamily = new System.Drawing.FontFamily("Arial Black");

        Paragraph headLine = doc.InsertParagraph(headLineText, false, headlineFormat);
        headLine.Alignment = Alignment.center;

        Paragraph imageParagraph = doc.InsertParagraph();
        Novacode.Image img = doc.AddImage("rpg-game.png");
        imageParagraph.InsertPicture(img.CreatePicture(230,600));

        Paragraph emptyLine = doc.InsertParagraph();
        Paragraph firstParagraph = doc.InsertParagraph();
        firstParagraph.Append("SoftUni is organizing a contest for the best ").Font(new System.Drawing.FontFamily("Calibri")).FontSize(9d)
            .Append("role playing game").Bold().Font(new System.Drawing.FontFamily("Calibri")).FontSize(9d)
            .Append(" from the OOP teamwork projects. The winning teams will receive a ").Font(new System.Drawing.FontFamily("Calibri")).FontSize(9d)
            .Append("grand prize").UnderlineStyle(UnderlineStyle.singleLine).Bold().Font(new System.Drawing.FontFamily("Calibri")).FontSize(9d)
            .Append(" !").Font(new System.Drawing.FontFamily("Calibri")).FontSize(9d);

        Paragraph secondParagraph = doc.InsertParagraph("This game should be:").Font(new System.Drawing.FontFamily("Calibri")).FontSize(9d);

        List list = doc.AddList(null, 0, ListItemType.Bulleted);
        doc.AddListItem(list, "Properly structured and follow all good OOP practices", 0, ListItemType.Bulleted);
        doc.AddListItem(list, "Awesome", 0, ListItemType.Bulleted);
        doc.AddListItem(list, "..Very Awesome", 0, ListItemType.Bulleted);
        doc.InsertList(list);
        
        Table table = doc.AddTable(4, 3);
        table.Alignment = Alignment.center;

        for (int i = 0; i < 3; i++)
			{
			    table.Rows[0].Cells[i].FillColor = Color.RoyalBlue; 
			}

        table.Rows[0].Cells[0].InsertParagraph("Team").Color(Color.White).Bold().Alignment = Alignment.center;
        table.Rows[0].Cells[1].InsertParagraph("Game").Color(Color.White).Bold().Alignment = Alignment.center;
        table.Rows[0].Cells[2].InsertParagraph("Points").Color(Color.White).Bold().Alignment = Alignment.center;

        for (int i = 1; i < table.RowCount; i++)
        {
            for (int j = 0; j < table.ColumnCount; j++)
            {
                table.Rows[i].Cells[j].InsertParagraph("-").Bold().Alignment = Alignment.center;
            }
        }

        doc.InsertParagraph();
        doc.InsertTable(table);

        doc.InsertParagraph();
        Paragraph preFinal = doc.InsertParagraph();
        preFinal.Append("The top 3 teams will receive a ").Append("SPECTACULAR").Bold().Append(" prize:").Alignment = Alignment.center;
        doc.InsertParagraph("A HANDSHAKE FROM NAKOV").Bold().UnderlineStyle(UnderlineStyle.singleLine).Color(Color.DarkBlue).FontSize(20D).Alignment = Alignment.center;
        
        doc.Save();

        Process.Start("WINWORD.EXE", this.fileName);
    }
}