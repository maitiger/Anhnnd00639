using CodeYami.DataAcess;
using CodeYami.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CodeYami.Menu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MusicAnime : Page
    {
        private ObservableCollection<Song> songAnime;

        internal ObservableCollection<Song> SongAnime1 { get => this.songAnime; set => this.songAnime = value; }
        MediaPlayer player;
        public MusicAnime()
        {
            this.SongAnime1 = new ObservableCollection<Song>();
            this.SongAnime1.Add(new Song()
            {
                name = "Rennai Circulation",
                thumbnail = "https://pbs.twimg.com/media/DWX0-TXXcAEzuVT.jpg",
                singer = " Hanazawa Kanna",
                author = " Hanazawa Kanna ",
                link = "https://www.nhaccuatui.com/bai-hat/renai-circulation-kana-hanazawa.symFnKUNFe.html"
            });

            this.InitializeComponent();
            player = new MediaPlayer();
            ShowAll();
            Debug.WriteLine(SongAnime1.Count());
        }


        private void AddData(object sender, RoutedEventArgs e)
        {


            Song song = new Song()
            {
                name = this.Name1.Text,
                thumbnail = this.Thumnail.Text,
                singer = this.Singer.Text,
                author = this.Author.Text,
                link = this.LinkSong.Text

            };
            this.SongAnime1.Add(song);
            this.Name1.Text = string.Empty;
            this.Thumnail.Text = string.Empty;
            this.Singer.Text = string.Empty;
            this.Author.Text = string.Empty;
            this.LinkSong.Text = string.Empty;

            SongModel.AddData(song);

            Output.ItemsSource = SongModel.GetData();
        }
        private void ShowAll()
        {
            using (SqliteConnection db =
                new SqliteConnection(DataAccess.SQL_connection_string))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from SongAnime", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    SongAnime1.Add(new Song
                    {
                        id = query.GetString(0),
                        name = query.GetString(1),
                        thumbnail = query.GetString(2),
                        singer = query.GetString(3),
                        author = query.GetString(4)
                    });
                }

            }
        }

        private void TxtFilePath_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                TextBox tbPath = sender as TextBox;

                if (tbPath != null)
                {
                    LoadMediaFromString(tbPath.Text);
                }
            }
        }

        private void LoadMediaFromString(string path)
        {
            try
            {
                Uri pathUri = new Uri(path);
                player.Source = MediaSource.CreateFromUri(pathUri);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    // handle exception.
                    // For example: Log error or notify user problem with file
                }
            }
        }
    }
}
