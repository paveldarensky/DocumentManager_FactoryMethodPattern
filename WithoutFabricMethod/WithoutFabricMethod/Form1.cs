using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithoutFabricMethod
{
    public partial class Form_main : Form
    {
        private List<Document> documents;
        private ImageList imageList;

        public Form_main()
        {
            InitializeComponent();

            documents = new List<Document>();

            // icons
            imageList = new ImageList();
            imageList.ImageSize = new Size(48, 48);
            imageList.Images.Add("Letter", Properties.Resources.letter);
            imageList.Images.Add("Order", Properties.Resources.order);
            imageList.Images.Add("BusinessTripOrder", Properties.Resources.business_trip_order);

            imageList.ColorDepth = ColorDepth.Depth32Bit;
            listView_Documents.LargeImageList = imageList;
            listView_Documents.View = View.Tile;

            GenerateDocuments(25);
            UpdateDocumentList();
        }

        private void GenerateDocuments(int count)
        {
            Random random = new Random();

            string[] departments = { "Отдел кадров", "Бухгалтерия", "Маркетинг", "ИТ-отдел", "Продажи" };
            string[] names = { "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов" };
            string[] destinations = { "Москва", "Санкт-Петербург", "Екатеринбург", "Омск", "Новосибирск" };
            string[] periods = { "1 неделя", "2 недели", "3 недели", "Месяц" };
            string[] types = { "Входящее", "Исходящее" };
            string[] doc_content = { "ПИСЬМО...ООО «ТехИнновация»\r\nг. Москва, ул. Технологическая, д. 10\r\nТел.: +7 (495) 123-45-67, Email: info@techinnovation.ru\r\n\r\nИсх. № 102/К\r\nот 18.02.2025\r\n\r\nГенеральному директору\r\nАО «Инженерные Решения»\r\nИванову А.В.\r\nг. Санкт-Петербург, ул. Индустриальная, д. 25\r\n\r\nУважаемый Андрей Викторович!\r\n\r\nНастоящим письмом уведомляем Вас о направлении в служебную командировку сотрудника Петрова Сергея Владимировича, занимающего должность ведущего инженера в ООО «ТехИнновация», в период с 19.02.2025 по 23.02.2025.\r\n\r\nЦель командировки: участие в техническом совещании и проверке оборудования в рамках проекта модернизации автоматизированных систем контроля.\r\n\r\nПросим Вас оказать содействие в организации рабочих встреч, предоставлении доступа к необходимой технической документации и оборудованию.\r\n\r\nС уважением,\r\nГенеральный директор ООО «ТехИнновация»\r\nСидоров А.Н.\r\n(подпись)", "ПРИКАЗ...ООО «ТехИнновация»\r\nПРИКАЗ\r\n№ 45/К\r\nот 18.02.2025\r\n\r\nО направлении в командировку\r\n\r\nВ связи с необходимостью выполнения служебных обязанностей и в соответствии с утвержденным планом работ ПРИКАЗЫВАЮ:\r\n\r\nНаправить в служебную командировку Петрова Сергея Владимировича, ведущего инженера ООО «ТехИнновация», в г. Санкт-Петербург, АО «Инженерные Решения», на период с 19.02.2025 по 23.02.2025.\r\nЦель командировки: проведение технического совещания и проверка оборудования в рамках модернизации автоматизированных систем контроля.\r\nКомандировочные расходы, включая проезд, проживание и суточные, оплатить за счет средств ООО «ТехИнновация».\r\nПо возвращении представить отчет о командировке в срок до 26.02.2025.\r\nОснование: служебное задание от 16.02.2025, приглашение от АО «Инженерные Решения» № 18/П от 14.02.2025.\r\n\r\nГенеральный директор ООО «ТехИнновация»\r\nСидоров А.Н.\r\n(подпись)", "РАСПОРЯЖЕНИЕ...ООО «ТехИнновация»\r\nРАСПОРЯЖЕНИЕ\r\n№ 12/К\r\nот 18.02.2025\r\n\r\nО направлении в командировку\r\n\r\nВ целях выполнения договорных обязательств и проведения запланированных работ РАСПОРЯЖАЮСЬ:\r\n\r\nПетрову Сергею Владимировичу, ведущему инженеру ООО «ТехИнновация», выехать в командировку в г. Санкт-Петербург, АО «Инженерные Решения», с 19.02.2025 по 23.02.2025.\r\nОбеспечить согласование всех рабочих вопросов с принимающей стороной и соблюдать установленные требования по технике безопасности.\r\nКонтроль за исполнением настоящего распоряжения возложить на руководителя технического отдела Смирнова В.В.\r\nГенеральный директор ООО «ТехИнновация»\r\nСидоров А.Н.\r\n(подпись)" };

            for (int i = 0; i < count; i++)
            {
                int docType = random.Next(3); // 0 - Letter, 1 - Order, 2 - BusinessTripOrder
                Document doc;

                switch (docType)
                {
                    case 0:
                        doc = new Letter
                        {
                            Number = $"№{documents.Count + 1}",
                            Date = DateTime.Now,
                            Content = doc_content[0],
                            Type = types[random.Next(types.Length)],
                            Correspondent = names[random.Next(names.Length)]
                        };
                        break;

                    case 1:
                        doc = new Order
                        {
                            Number = $"№{documents.Count + 1}",
                            Date = DateTime.Now,
                            Content = doc_content[1],
                            Department = departments[random.Next(departments.Length)],
                            Executor = names[random.Next(names.Length)],
                            Deadline = DateTime.Now.AddDays(random.Next(1, 31))
                        };
                        break;

                    case 2:
                        doc = new BusinessTripOrder
                        {
                            Number = $"№{documents.Count + 1}",
                            Date = DateTime.Now,
                            Content = doc_content[2],
                            Employee = names[random.Next(names.Length)],
                            Period = periods[random.Next(periods.Length)],
                            Destination = destinations[random.Next(destinations.Length)]
                        };
                        break;

                    default:
                        throw new Exception("Неизвестный тип документа");
                }

                documents.Add(doc);
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
        string DocumentContent = $"Распоряжение о командировке: {Number}\r\nСотрудник: {Employee}\r\nПериод командировки: {Period}\r\nСодержание: {Content}\r\nМесто назначения: {Destination}\r\nДата оповещения: {Date}";
        return DocumentContent;
    }

    public override string GetImageKey() => "BusinessTripOrder";
}