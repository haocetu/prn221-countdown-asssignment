using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Media;

namespace CountdownAssignment
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private TimeSpan alarmTime;
        private TimeSpan countdownTime;
        private DateTime countdownEndTime;
        private DispatcherTimer blinkTimer;
        private bool isBlinking;
        private SoundPlayer alarmSoundPlayer;

        public MainWindow()
        {
            InitializeComponent();
            InitializeClock();
            btnSetAlarm.Click += BtnSetAlarm_Click;
            btnStartCountdown.Click += BtnStartCountdown_Click;

            blinkTimer = new DispatcherTimer();
            blinkTimer.Interval = TimeSpan.FromSeconds(1);
            blinkTimer.Tick += BlinkTimer_Tick;
            blinkTimer.Start();

            alarmSoundPlayer = new SoundPlayer("D:\\How\\CountdownAssignment\\CountdownAssignment\\sound.WAV");

            for (int i = 0; i <= 23; i++)
            {
                cbAlarmHour.Items.Add(i.ToString("00"));
                cbCountdownHour.Items.Add(i.ToString("00"));
            }

            for (int i = 0; i <= 59; i++)
            {
                cbAlarmMinute.Items.Add(i.ToString("00"));
                cbCountdownMinute.Items.Add(i.ToString("00"));
            }
            for (int i = 0; i <= 59; i++)
            {
                cbAlarmMinute.Items.Add(i.ToString("00"));
                cbCountdownMinute.Items.Add(i.ToString("00"));
                cbCountdownSecond.Items.Add(i.ToString("00"));
            }
        }

        private void InitializeClock()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            CheckAlarm();
            UpdateCountdown();

            TimeSpan remainingTime = countdownEndTime - DateTime.Now;
            if (remainingTime.TotalSeconds <= 30)
            {
                // Bắt đầu blinkTimer
                blinkTimer.Start();
            }
        }

        private void BtnSetAlarm_Click(object sender, RoutedEventArgs e)
        {
            int hour, minute;

            if (int.TryParse(cbAlarmHour.SelectedItem as string, out hour) && int.TryParse(cbAlarmMinute.SelectedItem as string, out minute))
            {
                alarmTime = new TimeSpan(hour, minute, 0);
                tbAlarmStatus.Text = $"Alarm set for {alarmTime.ToString(@"hh\:mm")}";
            }
            else
            {
                MessageBox.Show("Invalid time format. Please select hour and minute.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnStartCountdown_Click(object sender, RoutedEventArgs e)
        {
            int hour, minute, second = 0;

            if (int.TryParse(cbCountdownHour.SelectedItem as string, out hour) &&
                int.TryParse(cbCountdownMinute.SelectedItem as string, out minute) &&
                int.TryParse(cbCountdownSecond.SelectedItem as string, out second))
            {
                countdownTime = new TimeSpan(hour, minute, second);
                countdownEndTime = DateTime.Now.Add(countdownTime);
                tbCountdownTime.Text = countdownTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                MessageBox.Show("Invalid time format. Please select hour, minute, and second.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateCountdown()
        {
            if (countdownEndTime > DateTime.Now)
            {
                TimeSpan remainingTime = countdownEndTime - DateTime.Now;
                tbCountdownTime.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                tbCountdownTime.Text = "00:00:00";
            }
        }

        private void CheckAlarm()
        {
            if (DateTime.Now.TimeOfDay.Hours == alarmTime.Hours && DateTime.Now.TimeOfDay.Minutes == alarmTime.Minutes)
            {
                MessageBox.Show("Alarm!", "Alarm", MessageBoxButton.OK, MessageBoxImage.Information);
                tbAlarmStatus.Text = "Alarm ringing!";
                alarmSoundPlayer.Play();
            }
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = countdownEndTime - DateTime.Now;
            if (remainingTime.TotalSeconds <= 30 && remainingTime.TotalSeconds > 0)
            {
                if (isBlinking)
                {
                    tbCountdownTime.Visibility = Visibility.Visible;
                    isBlinking = false;
                }
                else
                {
                    tbCountdownTime.Visibility = Visibility.Collapsed;
                    isBlinking = true;
                }
            }
            else
            {
                tbCountdownTime.Visibility = Visibility.Visible;
                isBlinking = false;
            }
        }
    }
}