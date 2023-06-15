using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_2
{
    class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void Add(string author, string title, string filename)
        {
            Song song = new Song(author, title, filename);
            list.Add(song);
        }
        public void Add(Song song)
        {
            list.Add(song);
        }
        public void Next()
        {
            if (list.Count > 0)
            {
                currentIndex++;
                if (currentIndex >= list.Count)
                    currentIndex = 0;
            }
            else
            {
                MessageBox.Show("Плейлист пуст", "Ошибка");
            }
        }

        public void Back()
        {
            if (list.Count > 0)
            {
                currentIndex--;
                if (currentIndex < 0)
                    currentIndex = list.Count - 1;
            }
            else
            {
                MessageBox.Show("Плейлист пуст", "Ошибка");
            }
        }
        public void Search(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                currentIndex = index;
            }
            else
            {
                MessageBox.Show("По данному индексу нет трека", "Ошибка");
            }
        }
        public void Start() 
        { 
            currentIndex = 0; 
        }
        public void End()
        {
            currentIndex = list.Count - 1;
        }
        public void Remove(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("По данному индексу нет трека", "Ошибка");
            }
        }
        public void Remove(Song song)
        {
            int index = list.IndexOf(song);
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Проверьте, все ли введенные данные написаны корректно", "Ошибка");
            }
        }
        public void Clear()
        {
            list.Clear();
            currentIndex = 0;
        }
    }
}
