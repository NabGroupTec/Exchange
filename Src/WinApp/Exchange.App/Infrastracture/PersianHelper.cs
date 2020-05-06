using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Telerik.Examples.WinControls.Editors.DateTimePicker.FirstLook
{
    [Flags]
    public enum FixCultureOptions
    {
        /// <summary>
        ///     If set Calendar property of culture will be set to PersianCalendar.
        /// </summary>
        foptCalendarInCulture = 2,

        /// <summary>
        ///     If set Calendar of DateFormatInfo will be set to PersianCalendar
        /// </summary>
        foptCalendarInDateFormatInfo = 4,

        /// <summary>
        ///     If set the first element of OptionalCalendars will be set to PersianCalendar
        /// </summary>
        foptOptionalCalendars = 8,

        /// <summary>
        ///     All fix ups will applied.
        /// </summary>
        foptAll = 16
    }

    public class Helpers
    {
        private static readonly Dictionary<object, InvokeHelper> m_List = new Dictionary<object, InvokeHelper>();

        public static void AddHelper(object Instance, InvokeHelper helper)
        {
            m_List.Add(Instance, helper);
        }

        public static InvokeHelper find(object Instance)
        {
            if (m_List.ContainsKey(Instance))
                return m_List[Instance];
            return null;
        }
    }

    public class InvokeHelper
    {
        private static readonly Dictionary<string, Type> Types = new Dictionary<string, Type>();
        private readonly Type m_Type;
        protected object m_Instance;

        public InvokeHelper(object Instance)
        {
            m_Instance = Instance;
            m_Type = Instance.GetType();
            //            Helpers.AddHelper(Instance, this);
        }

        public InvokeHelper(object Instance, Type type)
        {
            m_Instance = Instance;
            m_Type = type;
        }

        public object Instance => m_Instance;

        public static Type FindType(string TypeName)
        {
            if (Types.ContainsKey(TypeName)) return Types[TypeName];
            Type ret = null;
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            foreach (var module in assembly.GetModules())
            foreach (var type in module.GetTypes())
                if (type.FullName == TypeName)
                {
                    ret = type;
                    Types.Add(TypeName, ret);
                    return ret;
                }

            Types.Add(TypeName, ret);

            return ret;
        }

        public bool HasField(string FieldName)
        {
            foreach (var field in m_Type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
            )
                if (field.Name == FieldName)
                    return true;
            return false;
        }

        public object GetProperty(string FieldName)
        {
            return m_Type.InvokeMember(FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty,
                null, m_Instance, null);
        }

        public object SetProperty(string FieldName, object Value)
        {
            return m_Type.InvokeMember(FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty,
                null, m_Instance, new[] {Value});
        }

        public object GetField(string FieldName, object[] args)
        {
            return m_Type.InvokeMember(FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetField,
                null, m_Instance, args);
        }

        public object SetField(string FieldName, object[] args)
        {
            return m_Type.InvokeMember(FieldName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetField, null,
                m_Instance, args);
        }

        public object SetField(string FieldName, object Value)
        {
            return SetField(FieldName, new[] {Value});
        }

        public object StaticGetProperty(string PropertyName)
        {
            return m_Type.InvokeMember(PropertyName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.GetProperty,
                null, null, null);
        }

        public object CreateInstance(object[] args)
        {
            return null;
        }

        public object GetField(string FieldName)
        {
            return GetField(FieldName, null);
        }

        public object InvokeByRef(string MethodName, ref object[] args, ParameterModifier modifiers)
        {
            ParameterModifier[] mod = {modifiers};

            return m_Type.InvokeMember(MethodName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, m_Instance, args, mod, null, null);
        }

        public object InvokeByOut(string MethodName, object[] args, ParameterModifier modifiers)
        {
            ParameterModifier[] mod = {modifiers};

            return m_Type.InvokeMember(MethodName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, m_Instance, args, mod, null, null);
        }

        public object Invoke(string MethodName, object[] args)
        {
            return m_Type.InvokeMember(MethodName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null,
                m_Instance, args);
        }

        public object InvokeStatic(string MethodName, object[] args)
        {
            return m_Type.InvokeMember(MethodName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod, null,
                null, args);
        }

        public object InvokeStatic(string MethodName, object arg1, object arg2)
        {
            return InvokeStatic(MethodName, new[] {arg1, arg2});
        }

        public object InvokeStatic(string MethodName, object arg1)
        {
            return InvokeStatic(MethodName, new[] {arg1});
        }

        public object InvokeStatic(string MethodName)
        {
            return InvokeStatic(MethodName, null);
        }

        public object Invoke(string MethodName)
        {
            return Invoke(MethodName, null);
        }

        public object Invoke(string MethodName, object arg1)
        {
            return Invoke(MethodName, new[] {arg1});
        }

        public object Invoke(string MethodName, int arg1)
        {
            return Invoke(MethodName, new object[] {arg1});
        }

        public object Invoke(string MethodName, object obj1, object obj2)
        {
            return Invoke(MethodName, new[] {obj1, obj2});
        }

        public object Invoke(string MethodName, object obj1, object obj2, object obj3)
        {
            return Invoke(MethodName, new[] {obj1, obj2, obj3});
        }
    }

    /// <summary>
    ///     Contains methods to fix the Persian culture for Persian calendar.
    /// </summary>
    internal class PersianCultureHelper
    {
        /// <summary>
        ///     Fixes the DateTimeFormatInfo for Persian resources (months and week day names), and optionally sets the calendar to
        ///     PersianCalendar.
        /// </summary>
        /// <param name="info">The DateTimeFormatInfo to be fixed.</param>
        /// <param name="UsePersianCalendar">If set, the calendar will be set to PersianCalendar.</param>
        /// <returns>The fixed DateTimeFormatInfo.</returns>
        public static DateTimeFormatInfo FixPersianDateTimeFormat(DateTimeFormatInfo info, bool UsePersianCalendar)
        {
            var dateTimeFormatInfoReadOnly = typeof(DateTimeFormatInfo).GetField("m_isReadOnly",
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            var dateTimeFormatInfoCalendar = typeof(DateTimeFormatInfo).GetField("calendar",
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            if (info == null) info = new DateTimeFormatInfo();
            info.Calendar = new HijriCalendar();

            var readOnly = (bool) dateTimeFormatInfoReadOnly.GetValue(info);
            if (readOnly) dateTimeFormatInfoReadOnly.SetValue(info, false);
            if (UsePersianCalendar) dateTimeFormatInfoCalendar.SetValue(info, new PersianCalendar());
            if (info.Calendar.GetType() == typeof(PersianCalendar))
            {
                info.AbbreviatedDayNames = new[] {"ی", "د", "س", "چ", "پ", "ج", "ش"};
                info.ShortestDayNames = new[] {"ی", "د", "س", "چ", "پ", "ج", "ش"};
                info.DayNames = new[] {"یکشنبه", "دوشنبه", "ﺳﻪشنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه"};
                info.AbbreviatedMonthNames = new[]
                {
                    "فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن",
                    "اسفند", ""
                };
                info.MonthNames = new[]
                {
                    "فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن",
                    "اسفند", ""
                };
                info.AMDesignator = "ق.ظ";
                info.PMDesignator = "ب.ظ";
                info.FirstDayOfWeek = DayOfWeek.Saturday;
                info.FullDateTimePattern = "yyyy MMMM dddd, dd HH:mm:ss";
                info.LongDatePattern = "yyyy MMMM dddd, dd";
                info.ShortDatePattern = "yyyy/MM/dd";
            }

            if (readOnly) dateTimeFormatInfoReadOnly.SetValue(info, true);
            return info;
        }

        /// <summary>
        ///     Fixes CultureInfo for Persian resoures (months and day names) and also PersianCalendar.
        /// </summary>
        /// <param name="culture">The CultureInfo instace to be fixed. If NULL, a new instance will be created and returned.</param>
        /// <param name="options">Specifies what to be fixed.</param>
        /// <returns>A new instance of fixed Persian CultureInfo.</returns>
        public static CultureInfo FixPersianCulture(CultureInfo culture, FixCultureOptions options)
        {
            var calendarID = typeof(Calendar).GetProperty("ID", BindingFlags.NonPublic | BindingFlags.Instance);
            var cultureInfoReadOnly = typeof(CultureInfo).GetField("m_isReadOnly",
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            var cultureInfoCalendar = typeof(CultureInfo).GetField("calendar",
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            //FieldInfo cultureInfoReadOnly = typeof(CultureInfo).GetField("m_", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (culture == null) culture = new CultureInfo("fa-IR", false);
            if (culture == null || culture.LCID != 1065) return culture;
            if ((options & FixCultureOptions.foptAll) == FixCultureOptions.foptAll)
                options = FixCultureOptions.foptCalendarInCulture | FixCultureOptions.foptCalendarInDateFormatInfo |
                          FixCultureOptions.foptOptionalCalendars;
            if ((options & FixCultureOptions.foptOptionalCalendars) == FixCultureOptions.foptOptionalCalendars)
            {
                FixOptionalCalendars(culture, 4);
                culture = new CultureInfo("fa-IR", false);
            }

            var readOnly = (bool) cultureInfoReadOnly.GetValue(culture);
            if (readOnly) cultureInfoReadOnly.SetValue(culture, false);
            if ((options & FixCultureOptions.foptCalendarInDateFormatInfo) ==
                FixCultureOptions.foptCalendarInDateFormatInfo)
                culture.DateTimeFormat = FixPersianDateTimeFormat(culture.DateTimeFormat, true);
            else
                FixPersianDateTimeFormat(culture.DateTimeFormat, false);
            if ((options & FixCultureOptions.foptCalendarInCulture) ==
                FixCultureOptions.foptCalendarInCulture)
                cultureInfoCalendar.SetValue(culture, new PersianCalendar());
            if (readOnly) cultureInfoReadOnly.SetValue(culture, true);
            return culture;
        }

        /// <summary>
        ///     Creates, fixes and returns a new instance of Persian culture.
        /// </summary>
        /// <returns>A new instance of fixed Persian culture.</returns>
        public static CultureInfo GetFixedPersianCulture()
        {
            return FixPersianCulture(null, FixCultureOptions.foptAll);
        }

        /// <summary>
        ///     Set the CurrentCulture of current thread to a new fixed Persian culture.
        /// </summary>
        /// <returns>The fixed Persian cultreinfo.</returns>
        public static CultureInfo FixAndSetCurrentCulture()
        {
            var culture = FixPersianCulture(null, FixCultureOptions.foptAll);
            return culture;
        }

        /// <summary>
        ///     Sets the CalendarIndex element of OptionalCalendars of the passed caulture to PersianCalendar.
        /// </summary>
        /// <param name="culture">The CultureInfo instance to be fixed.</param>
        /// <param name="CalenadrIndex">
        ///     The index of element in optional calendars to be set to PersianCalendar. Note that this can
        ///     not add a new element so that the idex should be les than the length of the OptionalCalendars array.
        /// </param>
        /// <returns>The fixed culture.</returns>
        public static CultureInfo FixOptionalCalendars(CultureInfo culture, int CalendarIndex)
        {
            var ivCultureInfo = new InvokeHelper(culture);
            if (!ivCultureInfo.HasField("m_cultureTableRecord"))
                // This is .Net 4. 
                return _FixOptionalCalendars4(culture, CalendarIndex);

            var ivTableRecord = new InvokeHelper(ivCultureInfo.GetField("m_cultureTableRecord"));
            // Get the m_pData pointer as *void
            var m_pData = (Pointer) ivTableRecord.GetField("m_pData");
            var _intPtrCtor = typeof(IntPtr).GetConstructor(
                new[] {Type.GetType("System.Void*")});
            // Construct a new IntPtr
            var DataIntPtr = (IntPtr) _intPtrCtor.Invoke(new object[1] {m_pData});

            var TCultureTableData = Type.GetType("System.Globalization.CultureTableData");
            // Convert the Pointer class to object if type CultureTableData to work with
            // reflection API.
            var oCultureTableData = Marshal.PtrToStructure(DataIntPtr, TCultureTableData);
            var ivCultureTableData = new InvokeHelper(oCultureTableData);
            // Get waCalendars pointer
            var waCalendars = (uint) ivCultureTableData.GetField("waCalendars");
            var IOPTIONALCALENDARS = ivTableRecord.GetProperty("IOPTIONALCALENDARS");

            // Get m_Pool pointer
            var m_pool = (Pointer) ivTableRecord.GetField("m_pPool");

            var PoolInPtr = (IntPtr) _intPtrCtor.Invoke(new object[1] {m_pool});
            // Add the waCalendars offset to pool pointer
            var shortArrayPtr = new IntPtr(PoolInPtr.ToInt64() + waCalendars * sizeof(ushort));
            var shortArray = new short[1];
            // Now shortArray points to an arry of short integers.
            // Go to read the first value which is the number of elements.
            // Marshal array to read elements.
            Marshal.Copy(shortArrayPtr, shortArray, 0, 1);
            // shortArray[0] is the number of optional calendars.
            var calArray = new short[shortArray[0]];
            // Add one element of short type to point to array of calendars
            var calArrayPtr = new IntPtr(shortArrayPtr.ToInt64() + sizeof(short));
            // Finally read the array
            Marshal.Copy(calArrayPtr, calArray, 0, shortArray[0]);

            uint old;
            VirtualProtect(calArrayPtr, 100, 0x4, out old);
            calArray[CalendarIndex] = 0x16;
            Marshal.Copy(calArray, 0, calArrayPtr, calArray.Length);
            VirtualProtect(calArrayPtr, 100, old, out old);

            return culture;
        }

        [DllImport("kernel32.dll")]
        private static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize,
            uint flNewProtect, out uint lpflOldProtect);

        /// <summary>
        ///     Fixes the OptionalCalendars in case of .Net 4.
        /// </summary>
        private static CultureInfo _FixOptionalCalendars4(CultureInfo culture, int CalenadrIndex)
        {
            var cultureDataField = typeof(CultureInfo).GetField("m_cultureData",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            var cultureData = cultureDataField.GetValue(culture);
            var waCalendarsField = cultureData.GetType().GetField("waCalendars",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            var waCalendars = (int[]) waCalendarsField.GetValue(cultureData);
            if (waCalendars != null)
            {
                if (CalenadrIndex >= 0 && CalenadrIndex < waCalendars.Length) waCalendars[CalenadrIndex] = 0x16;
                waCalendarsField.SetValue(cultureData, waCalendars);
            }

            return culture;
        }
    }
}