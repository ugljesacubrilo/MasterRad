using MasterProjekat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;

namespace MasterProjekat.ViewModel
{
	public class DataImport : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private RelayCommand importXMLCommand;
		private bool canReadElements = false;

		public bool CanReadElements
		{
			get { return canReadElements; }
			set { canReadElements = value; }
		}

		public RelayCommand ImportXMLCommand
		{
			get
			{
				if (importXMLCommand == null)
					importXMLCommand = new RelayCommand(param => ImportXMLFile(param));
				return importXMLCommand;
			}
			set { importXMLCommand = value; OnPropertyChanged("ImportXMLCommand"); }
		}

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private void ImportXMLFile(object parameter)
		{
			string path = @"E:\GraphicData";
			ReadXMLFile(path);
		}

		private void InstatiateObjectsFromFile(XmlReader reader)
		{
			if (reader.Name == "Switch")
			{
				Switch sw = new Switch();
				while (reader.Read())
				{
					switch (reader.NodeType)
					{
						case XmlNodeType.Element:
							break;
						case XmlNodeType.Text:
							break;
						case XmlNodeType.XmlDeclaration:
						case XmlNodeType.ProcessingInstruction:
							break;
						case XmlNodeType.Comment:
							break;
						case XmlNodeType.EndElement:
							break;
					}
				}
			}
			else if (reader.Name == "Substation")
			{ }
			else if (reader.Name == "Section")
			{ }
			else if (reader.Name == "BusNode")
			{ }
		}

		private void ReadXMLFile(string path)
		{

			using (XmlReader reader = XmlReader.Create(path))
			{
				while (reader.Read())
				{
					switch (reader.NodeType)
					{
						case XmlNodeType.Element:
							//writer.WriteStartElement(reader.Name);
							InstatiateObjectsFromFile(reader);
							break;
						case XmlNodeType.Text:
							//writer.WriteString(reader.Value);
							break;
						case XmlNodeType.XmlDeclaration:
						case XmlNodeType.ProcessingInstruction:
							//writer.WriteProcessingInstruction(reader.Name, reader.Value);
							break;
						case XmlNodeType.Comment:
							//writer.WriteComment(reader.Value);
							break;
						case XmlNodeType.EndElement:
							//writer.WriteFullEndElement();
							break;
					}
				}

			}
		}

		private void CheckStartXMLElement(XmlReader element)
		{
			if (element.Name.Equals("Elements"))
			{
				CanReadElements = true;
			}
		}

		private void ReadElements(XmlReader element)
		{
			if (CanReadElements)
			{
				if (element.Name == "Switch")
				{

				}
				else if (element.Name == "Substation")
				{
				}
				else if (element.Name == "Section")
				{
				}
				else if (element.Name == "BusNode")
				{
				}
			}
		}
	}
}
