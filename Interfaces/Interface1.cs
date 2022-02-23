using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //1. Insted of class we use InterFace
    //2. Its a convention to start the name of interface with I
    //3. The data members of a interface cannot have a access specifier
    public interface IVideoPlayer
    {
        string ModelName { get; set; }
        void Play();
        void Stop();
    }

    public interface IAudioPlayer
    {
        void PlayAudio();
        void StopAudio();
    }

    //1. All members of the interface need to be provided a implementation 
    public class VideoPlayer : IVideoPlayer
    {
        public string ModelName { get; set; }

        public void Play()
        {
            Console.WriteLine("Video Player : Playing Video though Video Player");
        }

        public void Stop()
        {
            Console.WriteLine("Video Player : Stop Video though Video Player");
        }
    }

    public class MobilePhone : IVideoPlayer,IAudioPlayer
    {
        public string ModelName { get; set; }

        public void Play()
        {
            Console.WriteLine("Mobile Phone : Playing Video when user touchers the screen");
        }

        public void PlayAudio()
        {
            Console.WriteLine("Mobile Phone : Playing Audio when user touchers the screen");
        }

        public void Stop()
        {
            Console.WriteLine("Mobile Phone : Stop Video when user touchers the screen");
        }

        public void StopAudio()
        {
            Console.WriteLine("Mobile Phone : Playing Audio when user touchers the screen");
        }
    }

    public class Tablet : IVideoPlayer
    {
        public string ModelName { get; set; }

        public void Play()
        {
            Console.WriteLine("Tablet : Playing Video when user touchers the screen");
        }

        public void Stop()
        {
            Console.WriteLine("Tablet : Stop Video when user touchers the screen");
        }
    }

    public class IPodNano : IAudioPlayer
    {
        public void PlayAudio()
        {
            throw new NotImplementedException();
        }

        public void StopAudio()
        {
            throw new NotImplementedException();
        }
    }
}
