using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Convert
    {
        private long _bytes = 0;
        private long _kilobyte = 0;
        private long _megabyte = 0;
        private long _gigabyte = 0;
        private long _terabyte = 0;

        private const long Control = 1024;
        public Convert(long bytes)
        {
            _bytes = bytes;

            _kilobyte = GetKilobyte();

            _megabyte = GetMegabyte();

            _gigabyte = GetGigabyte();

            _terabyte = GetTerabyte();
        }

        private long GetBytes()
        {
            return _bytes;
        }

        private long GetKilobyte()
        {
            return _bytes / Control;
        }

        private long GetMegabyte()
        {
            return _kilobyte / Control;
        }

        private long GetGigabyte()
        {
            return _megabyte / Control;
        }

        private long GetTerabyte()
        {
            return _gigabyte / Control;
        }

        public string GetSize()
        {
            if (_bytes < Control)
                return $"{_bytes} байт";
            else if (_kilobyte < Control)
                return $"{_kilobyte} килобайт";
            else if (_megabyte < Control)
                return $"{_megabyte} мегабайт";
            else if (_gigabyte < Control)
                return $"{_gigabyte} гигабайт";
            else if (_terabyte < Control)
                return $"{_terabyte} терабайт";

            return String.Empty;
        }
    }
}
