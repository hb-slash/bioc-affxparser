/////////////////////////////////////////////////////////////////
//
// Copyright (C) 2005 Affymetrix, Inc.
//
// This library is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation; either version 2.1 of the License,
// or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License
// for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library; if not, write to the Free Software Foundation, Inc.,
// 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA 
//
/////////////////////////////////////////////////////////////////

#ifndef _DateTime_HEADER_
#define _DateTime_HEADER_

/*! \file DateTime.h This file provides data structures for holding a date and time.
 */

#include <string>
#include "AffymetrixBaseTypes.h"

namespace affymetrix_calvin_utilities
{
/*! The zulu format. */
#define ZULU_FORMAT_SPECIFIER std::wstring(L"Z")

/*! The datetime separator format specifier.*/
#define DATETIME_SEPERATOR_FORMAT_SPECIFIER std::wstring(L"T")

/*! The date format string. */
#define DATEFORMAT std::wstring(L"%Y-%m-%d") // YYYY-MM-DD

/*! The time format string. */
#define TIMEFORMAT std::wstring(L"%H:%M:%S") // hh:mm:ss

/*! This class provides storage for a date and time object. */
class DateTime
{
public:
	/*! Constructor */
	DateTime();

	/*! Destructor */
	~DateTime();

protected:
	/*! The date */
	std::wstring affydate;

	/*! The time */
	std::wstring affytime;

	/*! indicates if the time falue is UTC */
	bool coordinateduniversaltime;

public:
	/*! The date.
	 *
	 * @return The date.
	 */
	std::wstring Date() const;
	/*! Set the date.
	 *
	 * @param value The new date.
	 */
	 void Date(std::wstring value);

	/*! The time.
	 *
	 * @return The time.
	 */
	std::wstring Time() const;
	/*! Set the time.
	 *
	 * @param value The new time.
	 */
	void Time(std::wstring value);

	/*! Clears the members. */
	void Clear();

	/*! Gets the current date and time.
	 *
	 * @return The current date and time.
	 */
	static DateTime GetCurrentDateTime();

	/*! Gets whether or not the DateTime object time value is UTC or not.
	 *
	 * @return UTC or not.
	 */
	bool IsUTC();

	/*! Gets the current date and time and concatinates both together.
	 *
	 * @return The string representation of the date and time.
	 */
	std::wstring ToString();

	/*! Converts the string into a DateTime.
	 *	@param value A wstring containing the date and time to convert. The format must match that returned by ToString().
	 *	@return A DateTime equivalent to the date and time in value.
	 *	@exception FormatException
	 */
	static DateTime Parse(std::wstring value);
};

}

#endif // _DateTime_HEADER_
