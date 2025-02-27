using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FabricMethod
{
    public partial class Form_main : Form
    {
        private List<DocumentFactory> factories;
        private List<Document> documents;
        private ImageList imageList;

        public Form_main()
        {
            InitializeComponent();

            factories = new List<DocumentFactory>
            {
                new LetterFactory(),
                new OrderFactory(),
                new BusinessTripOrderFactory()
            };

            documents = new List<Document>();

            // icons
            imageList = new ImageList();
            imageList.ImageSize = new Size(48, 48);
            imageList.Images.Add("Letter", Properties.Resources.letter);
            imageList.Images.Add("Order", Properties.Resources.order);
            imageList.Images.Add("BusinessTripOrder", Properties.Resources.business_trip_order);

            GenerateDocuments(8);

            imageList.ColorDepth = ColorDepth.Depth32Bit;
            listView_Documents.LargeImageList = imageList;
            listView_Documents.View = View.Tile;

            UpdateDocumentList();
        }


        private void GenerateDocuments(int count)
        {

            var docContentDictionary = new Dictionary<Type, string>
            {
                { typeof(Letter), "ПИСЬМО...ООО «ТехИнновация»\r\nг. Москва, ул. Технологическая, д. 10\r\nТел.: +7 (495) 123-45-67, Email: info@techinnovation.ru\r\n\r\nИсх. № 102/К\r\nот 18.02.2025\r\n\r\nГенеральному директору\r\nАО «Инженерные Решения»\r\nИванову А.В.\r\nг. Санкт-Петербург, ул. Индустриальная, д. 25\r\n\r\nУважаемый Андрей Викторович!\r\n\r\nНастоящим письмом уведомляем Вас о направлении в служебную командировку сотрудника Петрова Сергея Владимировича, занимающего должность ведущего инженера в ООО «ТехИнновация», в период с 19.02.2025 по 23.02.2025.\r\n\r\nЦель командировки: участие в техническом совещании и проверке оборудования в рамках проекта модернизации автоматизированных систем контроля.\r\n\r\nПросим Вас оказать содействие в организации рабочих встреч, предоставлении доступа к необходимой технической документации и оборудованию.\r\n\r\nС уважением,\r\nГенеральный директор ООО «ТехИнновация»\r\nСидоров А.Н.\r\n(подпись)" },

                { typeof(Order), "ПРИКАЗ...ООО «ТехИнновация»\r\nПРИКАЗ\r\n№ 45/К\r\nот 18.02.2025\r\n\r\nО направлении в командировку\r\n\r\nВ связи с необходимостью выполнения служебных обязанностей и в соответствии с утвержденным планом работ ПРИКАЗЫВАЮ:\r\n\r\nНаправить в служебную командировку Петрова Сергея Владимировича, ведущего инженера ООО «ТехИнновация», в г. Санкт-Петербург, АО «Инженерные Решения», на период с 19.02.2025 по 23.02.2025.\r\nЦель командировки: проведение технического совещания и проверка оборудования в рамках модернизации автоматизированных систем контроля.\r\nКомандировочные расходы, включая проезд, проживание и суточные, оплатить за счет средств ООО «ТехИнновация».\r\nПо возвращении представить отчет о командировке в срок до 26.02.2025.\r\nОснование: служебное задание от 16.02.2025, приглашение от АО «Инженерные Решения» № 18/П от 14.02.2025.\r\n\r\nГенеральный директор ООО «ТехИнновация»\r\nСидоров А.Н.\r\n(подпись)" },

                { typeof(BusinessTripOrder), "РАСПОРЯЖЕНИЕ...ООО «ТехИнновация»\r\nРАСПОРЯЖЕНИЕ\r\n№ 12/К\r\nот 18.02.2025\r\n\r\nО направлении в командировку\r\n\r\nВ целях выполнения договорных обязательств и проведения запланированных работ РАСПОРЯЖАЮСЬ:\r\n\r\nПетрову Сергею Владимировичу, ведущему инженеру ООО «ТехИнновация», выехать в командировку в г. Санкт-Петербург, АО «Инженерные Решения», с 19.02.2025 по 23.02.2025.\r\nОбеспечить согласование всех рабочих вопросов с принимающей стороной и соблюдать установленные требования по технике безопасности.\r\nКонтроль за исполнением настоящего распоряжения возложить на руководителя технического отдела Смирнова В.В.\r\nГенеральный директор ООО «ТехИнновация»\r\nСидоров А.Н.\r\n(подпись)" }
            };

            foreach (var factory in factories)
            {
                for (int i = 0; i < count; i++)
                {
                    var doc = factory.FactoryMethod_CreateDocument();
                    doc.Number = $"№{documents.Count + 1}";
                    doc.Date = DateTime.Now;
                    doc.Content = docContentDictionary.TryGetValue(doc.GetType(), out var content) ? content : "";

                    documents.Add(doc);
                }
            }
        }

        private void UpdateDocumentList()
        {
            listView_Documents.Items.Clear();

            foreach (var doc in documents)
            {
                ListViewItem item = new ListViewItem(doc.Number);

                item.ImageKey = doc.GetImageKey();

                listView_Documents.Items.Add(item);
            }
        }

        private void listView_Documents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Documents.SelectedItems.Count > 0)
            {
                string selectedNumber = listView_Documents.SelectedItems[0].Text;

                var doc = documents.FirstOrDefault(d => d.Number == selectedNumber);

                if (doc != null)
                {
                    textBox_DocumentInfo.Text = doc.DisplayInfo();
                }
                else
                {
                    textBox_DocumentInfo.Text = "Документ не найден";
                }
            }
        }
    }
    }


    // ----------------------------------------------------- //
    abstract class Document
{
    public string Number { get; set; } // номер документа
    public DateTime Date { get; set; } // дата (пусть будет создания)
    public string Content { get; set; } // краткая информация о содержании

    public abstract string DisplayInfo(); // показать инфо о доке
    public abstract string GetImageKey(); // для иконки
}

class Letter : Document
{
    public string Type { get; set; }          // входящее/исходящее
    public string Correspondent { get; set; } // корреспондент

    public override string DisplayInfo()
    {
        string DocumentContent = $"Письмо {Number}\r\nТип: {Type}\r\nКорреспондент: {Correspondent}\r\nСодержание: {Content}\r\nДата оповещения: {Date}";
        return DocumentContent;
    }

    public override string GetImageKey() => "Letter";
}

class Order : Document
{
    public string Department { get; set; }  // подразделение
    public DateTime Deadline { get; set; }  // срок выполнения
    public string Executor { get; set; }    // ответственный исполнитель

    public override string DisplayInfo()
    {
        string DocumentContent = $"Приказ: {Number}\r\nПодразделение: {Department}\r\nОтветственный: {Executor}\r\nСодержание: {Content}\r\nДата выполнения: {Deadline}\r\nДата оповещения: {Date}";
        return DocumentContent;
    }

    public override string GetImageKey() => "Order";
}

class BusinessTripOrder : Document
{
    public string Employee { get; set; }   // сотрудник
    public string Period { get; set; }     // период командировки
    public string Destination { get; set; }  // место назначения

    public override string DisplayInfo()
    {
        string DocumentContent = $"Распоряжение о командировке: {Number}\r\nСотрудник: {Employee}\r\nПериод командировки: {Period}\r\nСодержание: {Content}\r\nМесто назначения: {Destination  }\r\nДата оповещения: {Date}";
        return DocumentContent;
    }

    public override string GetImageKey() => "BusinessTripOrder";
}

abstract class DocumentFactory
{
    // Фабричный метод
    public abstract Document FactoryMethod_CreateDocument();
}

class LetterFactory : DocumentFactory
{
    Random random = new Random();
    public override Document FactoryMethod_CreateDocument()
    {
        return new Letter
        {
            Type = new[] { "Входящее", "Исходящее" }[random.Next(2)],
            Correspondent = new[] { "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов" }[random.Next(5)]
        };
    }
}

class OrderFactory : DocumentFactory
{
    Random random = new Random();
    public override Document FactoryMethod_CreateDocument()
    {
        return new Order
        {
            Department = new[] { "Отдел кадров", "Бухгалтерия", "Маркетинг", "ИТ-отдел", "Продажи" }[random.Next(5)],
            Deadline = DateTime.Now.AddDays(random.Next(1, 31)),
            Executor = new[] { "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов" }[random.Next(5)]
        };
    }
}

class BusinessTripOrderFactory : DocumentFactory
{
    Random random = new Random();
    public override Document FactoryMethod_CreateDocument()
    {
        return new BusinessTripOrder
        {
            Employee = new[] { "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов" }[random.Next(5)],
            Period = new[] { "1 неделя", "2 недели", "3 недели", "Месяц" }[random.Next(4)],
            Destination = new[] { "Москва", "Санкт-Петербург", "Екатеринбург", "Омск", "Новосибирск" }[random.Next(5)]
        };
    }
}


