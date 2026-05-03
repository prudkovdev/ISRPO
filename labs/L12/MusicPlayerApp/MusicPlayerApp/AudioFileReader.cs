using System;
using System.IO;
using TagLib;

namespace MusicPlayerApp
{
    public static class AudioFileReader
    {
        /// <summary>
        /// Читает аудиофайл и возвращает заполненный объект MusicTrack.
        /// </summary>
        /// <param name="filePath">Путь к аудиофайлу</param>
        /// <returns>Экземпляр MusicTrack с заполненными метаданными</returns>
        /// <exception cref="FileNotFoundException">Если файл не найден</exception>
        /// <exception cref="Exception">Ошибка при чтении файла или тегов</exception>
        public static MusicTrack Read(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
                throw new FileNotFoundException($"Файл не найден: {filePath}");

            // Загружаем бинарные данные файла
            byte[] fileData = System.IO.File.ReadAllBytes(filePath);
            long fileSize = new FileInfo(filePath).Length;
            string fileName = Path.GetFileName(filePath);
            DateTime addedDate = DateTime.Now;

            string title = string.Empty;
            string artist = string.Empty;
            string album = string.Empty;
            string genre = string.Empty;
            TimeSpan duration = TimeSpan.Zero;

            try
            {
                // Читаем теги с помощью TagLib#
                using (var file = TagLib.File.Create(filePath))
                {
                    title = file.Tag.Title ?? string.Empty;
                    artist = file.Tag.FirstPerformer ?? file.Tag.FirstAlbumArtist ?? string.Empty;
                    album = file.Tag.Album ?? string.Empty;
                    genre = file.Tag.FirstGenre ?? string.Empty;
                    duration = file.Properties.Duration;
                }
            }
            catch (Exception ex)
            {
                // Если не удалось прочитать теги, продолжаем с пустыми значениями
                System.Diagnostics.Debug.WriteLine($"Ошибка чтения тегов: {ex.Message}");
            }

            return new MusicTrack
            {
                Title = title,
                Artist = artist,
                Album = album,
                Genre = genre,
                Duration = duration,
                FileName = fileName,
                FileData = fileData,
                FileSize = fileSize,
                AddedDate = addedDate
                // Id и PlayCount остаются со значениями по умолчанию (0)
            };
        }
    }
}
