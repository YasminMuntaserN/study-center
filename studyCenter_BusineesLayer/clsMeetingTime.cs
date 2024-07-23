using StudyCenter_DAL_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BL_
{
    public class clsMeetingTimes
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? MeetingTimeID { get; set; }
        public int PatternID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public clsMeetingTimes()
        {
            MeetingTimeID = null;
            PatternID = 0;
            StartTime = TimeSpan.Zero;
            EndTime = TimeSpan.Zero;
            Mode = enMode.AddNew;
        }

        private clsMeetingTimes(int? meetingTimeID, int patternID, TimeSpan startTime, TimeSpan endTime)
        {
            MeetingTimeID = meetingTimeID;
            PatternID = patternID;
            StartTime = startTime;
            EndTime = endTime;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            MeetingTimeID = clsMeetingTimesData.Add(PatternID, StartTime, EndTime);
            return (MeetingTimeID.HasValue);
        }

        private bool _Update()
            => clsMeetingTimesData.Update(MeetingTimeID.Value, PatternID, StartTime, EndTime);

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsMeetingTimes Find(int meetingTimeID)
        {
            int? patternID = null;
            TimeSpan? startTime = null;
            TimeSpan? endTime = null;
            bool isFound = clsMeetingTimesData.GetInfoByID(meetingTimeID, ref patternID, ref startTime, ref endTime);
            return (isFound) ? (new clsMeetingTimes(meetingTimeID, patternID.Value, startTime.Value, endTime.Value)) : null;
        }

        public static bool Delete(int? meetingTimeID)
            => clsMeetingTimesData.Delete(meetingTimeID);

        public static bool Exists(int? meetingTimeID)
            => clsMeetingTimesData.Exists(meetingTimeID);

        public static DataTable All()
            => clsMeetingTimesData.All();

        public static DataTable GetMeetingTimesByPattern(int patternID)
            => clsMeetingTimesData.GetMeetingTimesByPattern(patternID);

        public static bool GetPatternDetails(int patternID,  string patternDescription,  string encodedDays)
            => clsMeetingTimesData.GetPatternDetailsByID(patternID, ref patternDescription, ref encodedDays);
    }

}
