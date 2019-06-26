using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace xmlWriteWinApp
{
    /// <summary>
    /// Возвращает строку - описание для xml файла, которое выбирается по ключевым словам в пути к файлу или папке.
    /// </summary>
    class Description
    {
        public static string Show(string folderPath)
        {

            string description = "Прочее";
            string folderName = new DirectoryInfo(folderPath).Name;

            if (folderName.Contains("enum"))
            {
                description = "Классы перечислений";
            }
            if (folderName.Contains("LibTiff"))
            {
                description = "Общие классы, используемые в библиотеке";
            }
            if (folderName.Contains("zLib"))
            {
                description = "Классы потоковые";
            }
            if (folderName.Contains("Properties"))
            {
                description = "Классы свойств";
            }
            if (folderName.Contains("obj"))
            {
                description = "Классы объектов";
            }
            if (folderName.Contains("jpeg"))
            {
                description = "Классы взаимодействия с графикой";
            }
            if (folderName.Contains("Internal"))
            {
                description = "Классы для внутреннего использования";
            }
            if (folderName.Contains("Tiff2Pdf"))
            {
                description = "Классы конвертации в pdf";
            }
            if (folderName.Contains("C#"))
            {
                description = "C# версия классов";
            }
            if (folderName.Contains("WriteTagsBeforeData"))
            {
                description = "Классы тэгов";
            }
            if (folderName.Contains("write"))
            {
                description = "Классы записи файлов";
            }
            if (folderName.Contains("WriteBlackWhiteTiff"))
            {
                description = "Классы записи черно-белых Tiff";
            }
            if (folderName.Contains("using"))
            {
                description = "Классы описания using";
            }
            if (folderName.Contains("TiffWithColorMap"))
            {
                description = "Классы Tiff с цветной палитрой";
            }
            if (folderName.Contains("32Bit"))
            {
                description = "Классы 32-битной  версии";
            }
            if (folderName.Contains("24Bit"))
            {
                description = "Классы 24-битной  версии";
            }
            if (folderName.Contains("TiffTo24BitBitmap"))
            {
                description = "Классы конвертации в 24-битную версию";
            }
            if (folderName.Contains("SimpleTiffCopy"))
            {
                description = "Классы быстрого копирования";
            }
            if (folderName.Contains("RotateTiff"))
            {
                description = "Классы поворота Tiff";
            }
            if (folderName.Contains("rotate"))
            {
                description = "Классы, описывающие вращение";
            }
            if (folderName.Contains("ReadWriteCustomTags"))
            {
                description = "Классы, описывающие чтение/запись кастомных тэгов";
            }
            if (folderName.Contains("ReadUnknownTagValue"))
            {
                description = "Классы, описывающие считывание неизвестных тэгов";
            }
            if (folderName.Contains("ReadSamples"))
            {
                description = "Классы, описывающие считывание образцов";
            }
            if (folderName.Contains("ReadExifMetadata"))
            {
                description = "Классы, описывающие считывание метаданных";
            }
            if (folderName.Contains("ReadBasicProperties"))
            {
                description = "Классы, описывающие считывание базовых свойств";
            }
            if (folderName.Contains("ReadArbitraryScanlines"))
            {
                description = "Классы, описывающие произвольные сканлинии ";
            }
            if (folderName.Contains("Process16BitSamples"))
            {
                description = "Классы, описывающие обработку 16 битных образцов";
            }
            if (folderName.Contains("PrintDirectory"))
            {
                description = "Классы, описывающие печать директории";
            }
            if (folderName.Contains("NumberOfPages"))
            {
                description = "Классы, описывающие число страниц";
            }
            if (folderName.Contains("ImageToBitonalTiff"))
            {
                description = "Классы, описывающие конвертацию изображения в монохромный Tiff";
            }
            if (folderName.Contains("EnumerateTiffTags"))
            {
                description = "Классы, описывающие перечисление тэгов ";
            }
            if (folderName.Contains("DetermineCorruptPage"))
            {
                description = "Классы, описывающие распознавание поврежденной страницы";
            }
            if (folderName.Contains("CreateMultipageTiff"))
            {
                description = "Классы, описывающие создание мультистраничного Tiff";
            }
            if (folderName.Contains("CreateGradientTiff"))
            {
                description = "Классы, описывающие создание векторного Tiff";
            }
            if (folderName.Contains("Create16BitGrayscaleTiff"))
            {
                description = "Классы, описывающие создание 16 битного Tiff (оттенки серого)";
            }
            if (folderName.Contains("ConvertToSingleStripInMemory"))
            {
                description = "Классы, описывающие конвертацию в однополосный тип хранения";
            }
            if (folderName.Contains("ConvertToSingleStrip"))
            {
                description = "Конвертация в однополосный тип хранения";
            }
            if (folderName.Contains("Convert16BitTo8Bit"))
            {
                description = "Конвертация 16 бит в 8 бит";
            }
            if (folderName.Contains("BitonalTiffToBitmap"))
            {
                description = "Конвертация битонального в массив битов ";
            }
            if (folderName.Contains("BitmapTo32BitColorTiff"))
            {
                description = "Конвертация массива в 32 бит цвет";
            }
            if (folderName.Contains("BitmapTo24BitColorTiff"))
            {
                description = "Конвертация массива в 24 бит цвет";
            }
            if (folderName.Contains("AddPageToTiff"))
            {
                description = "Добавить страницу в Tiff";
            }
            if (folderName.Contains("AddCustomTagsToExistingTiff"))
            {
                description = "Добавление кастомных тэгов в существующий Tiff";
            }
            if (folderName.Contains("zLib"))
            {
                description = "zLib библиотека Tiff";
            }
            if (folderName.Contains("LibJpeg"))
            {
                description = "Библиотеки Jpeg";
            }
            if (folderName.Contains("TiffCP"))
            {
                description = "Объединение файлов в многостраничный";
            }
            if (folderName.Contains("UnitTests"))
            {
                description = "Тест кейсы";
            }
            if (folderName.Contains("Samples"))
            {
                description = "Примеры";
            }
            if (folderName.Contains("UsingCustomTiffStream"))
            {
                description = "Кастомные потоки Tiff";
            }
            if (folderName.Contains("UsingSystemIOStream"))
            {
                description = "Работа с IOS потоками";
            }
            if (folderName.Contains("Tiff2Rgba"))
            {
                description = "Конвертация Tiff в RGBA";
            }
            if (folderName.Contains("Debug"))
            {
                description = "Отладка";
            }
            if (folderName.Contains("netcoreapp2.0"))
            {
                description = "Версия .Net 2.0";
            }
            if (folderName.Contains("netstandard1.3"))
            {
                description = "Версия .NET 1.3";
            }
            if (folderName.Contains("Enums"))
            {
                description = "Объекты-перечисления, используемые в библиотеке";
            }
            if (folderName.Contains("NotifyIconWpf"))
            {
                description = "Объекты Wpf, используемые в библиотеке";
            }
            if (folderName.Contains("Interop"))
            {
                description = "Объекты взаимодействия, используемые  в библиотеке";
            }
            if (folderName.Contains("CodeCompletion"))
            {
                description = "Объекты, отвечающие за автозавершение ";
            }
            if (folderName.Contains("Document"))
            {
                description = "Классы, описывающие работу с документами";
            }
            if (folderName.Contains("Highlighting"))
            {
                description = "Объекты, отвечающие за выделение";
            }
            if (folderName.Contains("Folding"))
            {
                description = "Объекты, отвечающие за группировку кода";
            }
            if (folderName.Contains("Editing"))
            {
                description = "Объекты, отвечающие за редактирование";
            }
            if (folderName.Contains("Resources"))
            {
                description = "Объекты ресурсов";
            }
            if (folderName.Contains("Xshd"))
            {
                description = "Объекты, отвечающие за работу с .Xshd файлами";
            }
            if (folderName.Contains("Indentation"))
            {
                description = "Объекты, отвечающие за табуляцию";
            }
            if (folderName.Contains("Rendering"))
            {
                description = "Объекты, отвечающие за рендеринг";
            }
            if (folderName.Contains("Search"))
            {
                description = "Объекты, отвечающие за поиск";
            }
            if (folderName.Contains("Snippets"))
            {
                description = "Объекты - сниппеты";
            }
            if (folderName.Contains("Utils"))
            {
                description = "Утилиты";
            }
            if (folderName.Contains("src"))
            {
                description = "Источник";
            }
            if (folderName.Contains("CsvHelper"))
            {
                description = "Корневая директория";
            }
            if (folderName.Contains("Configuration"))
            {
                description = "Конфигурация";
            }
            if (folderName.Contains("Attributes"))
            {
                description = "Объекты, описывающие атрибуты";
            }
            if (folderName.Contains("Expressions"))
            {
                description = "Объекты, описывающие выражения";
            }
            if (folderName.Contains("TypeConversion"))
            {
                description = "Объекты конвертации типов данных";
            }
            if (folderName.Contains("DocsGenerator"))
            {
                description = "Объекты генерации документов";
            }
            if (folderName.Contains("Formatters"))
            {
                description = "Объекты, отвечающие за форматирование";
            }
            if (folderName.Contains("Generators"))
            {
                description = "Объекты, отвечающие за генерацию";
            }
            if (folderName.Contains("Infos"))
            {
                description = "Объекты - описания";
            }
            if (folderName.Contains("Performance"))
            {
                description = "Объекты, отвечающие за производительность";
            }
            if (folderName.Contains("ITfoxtec.Saml2"))
            {
                description = "Корневой каталог";
            }
            if (folderName.Contains("Binding"))
            {
                description = "Объекты свойств binding";
            }
            if (folderName.Contains("Claim"))
            {
                description = "Объявление типов";
            }
            if (folderName.Contains("Cryptography"))
            {
                description = "Объекты, описывающие работу с шифрованием данных";
            }
            if (folderName.Contains("Extension"))
            {
                description = "Объекты, описывающие расширения";
            }
            if (folderName.Contains("Schema"))
            {
                description = "Схемы данных";
            }
            if (folderName.Contains("Metadata"))
            {
                description = "Объекты, описывающие метаданные";
            }
            if (folderName.Contains("Tokens"))
            {
                description = "Объекты, описывающие токены";
            }
            if (folderName.Contains("Util"))
            {
                description = "Объекты, описывающие утилиты";
            }
            if (folderName.Contains("ITfoxtec.Saml2.Mvc"))
            {
                description = "Объекты MVC";
            }
            if (folderName.Contains("Saml2BindingExtensions"))
            {
                description = "Расширения SAML to Binding";
            }
            if (folderName.Contains("Autodiscover"))
            {
                description = "Объекты, связанные с автообнаружением сервисов";
            }
            if (folderName.Contains("Availability"))
            {
                description = "Объекты, связанные с проверкой доступности сотрудников";
            }
            if (folderName.Contains("PeopleInsights"))
            {
                description = "Сотрудники в поле зрения";
            }
            if (folderName.Contains("Recurrence"))
            {
                description = "Повторное проявление";
            }
            if (folderName.Contains("Pattern"))
            {
                description = "Объекты, описывающие шаблоны";
            }
            if (folderName.Contains("Range"))
            {
                description = "Объекты, описывающие диапазоны значений";
            }
            if (folderName.Contains("TimeZones"))
            {
                description = "Объекты, описывающие настройки часовых поясов";
            }
            if (folderName.Contains("Core"))
            {
                description = "Объекты, связанные с ядром";
            }
            if (folderName.Contains("Request"))
            {
                description = "Объекты, описывающие запросы";
            }
            if (folderName.Contains("Response"))
            {
                description = "Объекты, описывающие ответы";
            }
            if (folderName.Contains("Credentials"))
            {
                description = "Объекты, описывающие разрешения";
            }
            if (folderName.Contains("Dns"))
            {
                description = "Объекты, связанные с DNS объектами";
            }
            if (folderName.Contains("Elc"))
            {
                description = "Объекты, описывающие работу ELC";
            }
            if (folderName.Contains("Enumeration"))
            {
                description = "Описание объектов-перечислений";
            }
            if (folderName.Contains("Exception"))
            {
                description = "Описание объектов-исключений";
            }
            if (folderName.Contains("Group"))
            {
                description = "Описание объектов-групп";
            }
            if (folderName.Contains("Interface"))
            {
                description = "Объекты, описывающие интерфейсы";
            }
            if (folderName.Contains("Misc"))
            {
                description = "Объекты, описывающие MISC ";
            }
            if (folderName.Contains("Availability"))
            {
                description = "Объекты, описывающие доступность";
            }
            if (folderName.Contains("IdConversion"))
            {
                description = "Описание конвертации идентификатора";
            }
            if (folderName.Contains("Notification"))
            {
                description = "Описание уведомлений";
            }
            if (folderName.Contains("PropertyDefinition"))
            {
                description = "Задание свойств";
            }
            if (folderName.Contains("Filter"))
            {
                description = "Описание фильтрации";
            }
            if (folderName.Contains("Security"))
            {
                description = "Объекты, отвечающие за безопасность данных";
            }
            if (folderName.Contains("Sync"))
            {
                description = "Объекты, отвечающие за синхронизацию данных";
            }
            if (folderName.Contains("UnifiedMessaging"))
            {
                description = "Унифицированный обмен сообщениями";
            }

            if (folderName.Contains("MimeType"))
            {
                description = "Основной каталог";
            }
            if (folderName.Contains("NET 2.0"))
            {
                description = "Версия NET 2.0";
            }
            if (folderName.Contains("NET 3.0"))
            {
                description = "Версия NET 3.0";
            }
            if (folderName.Contains("NET 3.5"))
            {
                description = "Версия NET 3.5";
            }
            if (folderName.Contains("NET 4.5"))
            {
                description = "Версия NET 4.5";
            }
            if (folderName.Contains("NET 4.0"))
            {
                description = "Версия NET 4.0";
            }
            if (folderName.Contains("Source"))
            {
                description = "Исходники";
            }
            if (folderName.Contains("Access"))
            {
                description = "Объекты, регламентирующие доступ";
            }
            if (folderName.Contains("Class"))
            {
                description = "Объекты, описывающие классы";
            }
            if (folderName.Contains("Constant"))
            {
                description = "Объекты, описывающие константы";
            }
            if (folderName.Contains("Module"))
            {
                description = "Модули, используемые в бибилиотеке";
            }
            if (folderName.Contains("Tools"))
            {
                description = "Инструменты, используемые в бибилиотеке";
            }
            if (folderName.Contains("ADODB"))
            {
                description = "Объекты, описывающие работу с ADODB";
            }
            if (folderName.Contains("ClientApplication"))
            {
                description = "Объекты клиентского приложения";
            }
            if (folderName.Contains("DAO"))
            {
                description = "Объекты абстрактного интерфейса доступа к БД";
            }
            if (folderName.Contains("MSComctlLib"))
            {
                description = "Объекты взаимодействия с MSComctlLib";
            }
            if (folderName.Contains("MSDATASRC"))
            {
                description = "Объекты взаимодействия с MSDATASRC";
            }
            if (folderName.Contains("MSForms"))
            {
                description = "Объекты взаимодействия с MSForms";
            }
            if (folderName.Contains("MSHTML"))
            {
                description = "Объекты взаимодействия с MSHTML";
            }
            if (folderName.Contains("Record"))
            {
                description = "Объекты записей";
            }
            if (folderName.Contains("MSProject"))
            {
                description = "Объекты взаимодействия с MSProject";
            }
            if (folderName.Contains("NamedPipes"))
            {
                description = "Объекты работы с именованными каналами";
            }
            if (folderName.Contains("Office"))
            {
                description = "Объекты взаимодействия с MS Office";
            }
            if (folderName.Contains("Class"))
            {
                description = "Объекты классов";
            }
            if (folderName.Contains("Dialog"))
            {
                description = "Объекты диалогов";
            }
            if (folderName.Contains("Informations"))
            {
                description = "Объекты информирования";
            }
            if (folderName.Contains("PowerPoint"))
            {
                description = "Объекты взаимодействия с MS PowerPoint";
            }
            if (folderName.Contains("VBIDE"))
            {
                description = "Объекты взаимодействия с VBIDE";
            }
            if (folderName.Contains("Visio"))
            {
                description = "Объекты взаимодействия с MS Visio";
            }
            if (folderName.Contains("Word"))
            {
                description = "Объекты взаимодействия с MS Word";
            }
            if (folderName.Contains("Npgsql"))
            {
                description = "Корневой каталог";
            }
            if (folderName.Contains("BackendMessage"))
            {
                description = "Объекты обработки backend сообщений";
            }
            if (folderName.Contains("FrontendMessages"))
            {
                description = "Объекты обработки Frontend сообщений";
            }
            if (folderName.Contains("Logging"))
            {
                description = "Объекты, связанные с логированием";
            }
            if (folderName.Contains("NameTranslation"))
            {
                description = "Объекты, отвечающие за перевод наименований";
            }
            if (folderName.Contains("NpgsqlTypes"))
            {
                description = "Объекты, описывающие Npgsql типы";
            }
            if (folderName.Contains("PostgresTypes"))
            {
                description = "Объекты, описывающие Postgres типы";
            }
            if (folderName.Contains("Tls"))
            {
                description = "Объекты взаимодействия с TLS";
            }
            if (folderName.Contains("TypeHandler"))
            {
                description = "Объекты обработчики типов";
            }
            if (folderName.Contains("DateTimeHandler"))
            {
                description = "Объекты обработчики даты и времени";
            }
            if (folderName.Contains("GeometricHandler"))
            {
                description = "Обработчики геометрических объектов";
            }
            if (folderName.Contains("NetworkHandlers"))
            {
                description = "Обработчики сетевых протоколов";
            }
            if (folderName.Contains("NumericHandler"))
            {
                description = "Обработчики чисел";
            }
            if (folderName.Contains("TypeHandling"))
            {
                description = "Обработка типов";
            }
            if (folderName.Contains("TypeMapping"))
            {
                description = "Определение соответствия типов";
            }
            if (folderName.Contains("Npgsql.GeoJSON"))
            {
                description = "Объекты, описывающие работу с Npgsql.GeoJSON";
            }
            if (folderName.Contains("Npgsql.Json.NET"))
            {
                description = "Объекты, описывающие работу с Npgsql.Json.NET";
            }
            if (folderName.Contains("Npgsql.LegacyPostgis"))
            {
                description = "Объекты, описывающие работу с Npgsql.LegacyPostgis";
            }
            if (folderName.Contains("NetTopologySuite"))
            {
                description = "Обработка NetTopologySuite";
            }
            if (folderName.Contains("Npgsql.NodaTime"))
            {
                description = "Обработка Npgsql.NodaTime";
            }
            if (folderName.Contains("Npgsql.RawPostgis"))
            {
                description = "Обработчики Npgsql.RawPostgis";
            }
            if (folderName.Contains("VSIX"))
            {
                description = "Объекты, описывающие работу VSIX";
            }
            if (folderName.Contains("impl "))
            {
                description = "Объекты, связанные с impl";
            }
            if (folderName.Contains("AdoJobStore"))
            {
                description = "Объекты, описывающие параметры AdoJobStore";
            }
            if (folderName.Contains("Calendar"))
            {
                description = "Объекты, описывающие настройки календаря ";
            }
            if (folderName.Contains("Matchers"))
            {
                description = "Объекты, связанные с использованием matcher ";
            }
            if (folderName.Contains("Triggers"))
            {
                description = "Объекты, описывающие триггеры ";
            }
            if (folderName.Contains("Listener"))
            {
                description = "Объекты, описывающие listener ";
            }
            if (folderName.Contains("Simpl"))
            {
                description = "Объекты, описывающие упрощенный подход к различным узлам";
            }
            if (folderName.Contains("SPI"))
            {
                description = "Объекты, описывающие интерфейс SPI ";
            }
            if (folderName.Contains("Xml"))
            {
                description = "Объекты, описывающие работу с xml";
            }
            //if (folderName.Contains(""))
            //{
            //    description = "";
            //}
            //if (folderName.Contains(""))
            //{
            //    description = "";
            //}
            return description;
        }
    }
}
