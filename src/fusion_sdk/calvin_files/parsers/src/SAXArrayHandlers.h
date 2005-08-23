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

#ifndef _SAXArrayHandlers_HEADER_
#define _SAXArrayHandlers_HEADER_

/*! \file SAXArrayHandlers.h This file provides SAX parsing handles for array files.
 */

#include "ArrayData.h"
#include <string>
#include <map>
#include <xercesc/sax/SAXException.hpp>
#include <xercesc/sax/HandlerBase.hpp>
#include <xercesc/sax/AttributeList.hpp>

namespace affymetrix_calvin_io
{
/*! The name of the DTD for the array file. */
#define ARRAY_FILE_DTD std::wstring(L"Array.dtd")

/*! The encoding to use for array files. */
#define ARRAY_FILE_ENCODING std::wstring(L"UTF-16")

/*! The name of the element that contains the array file id, type and version data. */
#define ARRAY_FILE_ELEMENT std::wstring(L"ArrayFile")

/*! The attribute name of the ID field for the array file. */
#define ARRAY_FILE_ELEMENT_ID_ATTRIBUTE std::wstring(L"ID")

/*! The attribute name of the type field for the array file. */
#define ARRAY_FILE_ELEMENT_TYPE_ATTRIBUTE std::wstring(L"Type")

/*! The attribute name of the version field for the array file. */
#define ARRAY_FILE_ELEMENT_VERSION_ATTRIBUTE std::wstring(L"Version")

/*! The name of the element that contains the list of physical arrays. */
#define PHYSICAL_ARRAYS_ELEMENT std::wstring(L"PhysicalArrays")

/*! The name of the element that contains the attributes of a single physical array. */
#define PHYSICAL_ARRAY_ELEMENT std::wstring(L"PhysicalArray")

/*! The attribute name of the ID field for a physical array. */
#define PHYSICAL_ARRAY_ELEMENT_ID_ATTRIBUTE std::wstring(L"ID")

/*! The name of the element that contains a single attribute of a single physical array. */
#define PHYSICAL_ARRAY_ATTRIBUTE_ELEMENT std::wstring(L"Attribute")

/*! The attribute name of the name field for a physical array attribute. */
#define PHYSICAL_ARRAY_ATTRIBUTE_ELEMENT_NAME_ATTRIBUTE std::wstring(L"Name")

/*! The attribute name of the value field for a physical array attribute. */
#define PHYSICAL_ARRAY_ATTRIBUTE_ELEMENT_VALUE_ATTRIBUTE std::wstring(L"Value")

/*! The name of the element that contains the user attributes. */
#define USER_ATTRIBUTES_ELEMENT std::wstring(L"UserAttributes")

/*! The name of the element that contains a single user attribute. */
#define USER_ATTRIBUTES_ATTRIBUTE_ELEMENT std::wstring(L"Attribute")

/*! The attribute name of the name field for a user attribute. */
#define USER_ATTRIBUTES_ATTRIBUTE_ELEMENT_NAME_ATTRIBUTE std::wstring(L"Name")

/*! The attribute name of the value field for a user attribute. */
#define USER_ATTRIBUTES_ATTRIBUTE_ELEMENT_VALUE_ATTRIBUTE std::wstring(L"Value")

/*! The name of the element that contains a controlled vocabulary. */
#define USER_ATTRIBUTES_ATTRIBUTE_CONTROL_ELEMENT std::wstring(L"Control")

/*! The attribute name of the value field for a controlled vocabulary. */
#define USER_ATTRIBUTES_ATTRIBUTE_CONTROL_ELEMENT_VALUE_ATTRIBUTE std::wstring(L"Value")

/*! Enumerants to hold the elements in an array file. */
typedef enum {
	ARRAY_FILE,
	PHYSICAL_ARRAYS,
	PHYSICAL_ARRAY,
	PHYSICAL_ARRAY_ATTRIBUTES,
	USER_ATTRIBUTES,
	USER_ATTRIBUTES_ATTRIBUTE,
	USER_ATTRIBUTES_ATTRIBUTE_CONTROL
} ArrayFileElements;

/*! An exception for stoping parsing of a file. */
class SAXArrayStopParsingException : public XERCES_CPP_NAMESPACE::SAXException
{
};

/*! This class provides the SAX handlers for reading calvin array files. */
class SAXArrayHandlers : public XERCES_CPP_NAMESPACE::HandlerBase
{
private:
	/*! A pointer to the array object. */
	affymetrix_calvin_array::ArrayData *arrayData;

	/*! A flag used to indicate that the header line should only be read. */
	bool readHeaderOnly;

	/*! The parent element that is currently being processed. */
	ArrayFileElements currentElement;

	/*! The files version number. */
	u_int8_t fileVersionNumber;

	/*! An identifier to the type of data stored in the file */
	affymetrix_calvin_utilities::AffymetrixGuidType dataTypeIdentifier;

	/*! Stores the attributes from the array file element.
	 *
	 * @param attributes The name/value attributes.
	 */
	void StoreArrayFileAttributes(std::map<std::wstring, std::wstring> &attributes);

	/*! Stores the ID from the physical array element.
	 *
	 * @param attributes The name/value attributes.
	 */
	void StorePhysicalArrayID(std::map<std::wstring, std::wstring> &attributes);

	/*! Stores an attribute from the physical array attribute element.
	 *
	 * @param attributes The name/value attributes.
	 */
	void StorePhysicalArrayAttribute(std::map<std::wstring, std::wstring> &attributes);

	/*! Stores an attribute from the user attribute element.
	 *
	 * @param attributes The name/value attributes.
	 */
	void StoreUserAttribute(std::map<std::wstring, std::wstring> &attributes);

	/*! Stores a control value from the user attribute element.
	 *
	 * @param attributes The name/value attributes.
	 */
	void StoreUserAttributeControl(std::map<std::wstring, std::wstring> &attributes);

	/*! Modifies the state machine given the end of an element.
	 *
	 * @param name The name of the element.
	 */
	void MoveCurrentElementBack(const XMLCh* const name);

	/*! Modifies the state machine given the start of an element.
	 *
	 * @param name The name of the element.
	 * @return True is a valid element was found.
	 */
	bool MoveCurrentElementForward(const XMLCh* const name);

public:
	/*! Constructor
	 *
	 * @param data The array data.
	 * @param headerOnly Flag to indicate that the header line should only be read.
	 */
	SAXArrayHandlers(affymetrix_calvin_array::ArrayData *data, bool headerOnly=false);

	/*! Destructor */
	~SAXArrayHandlers();

	/*! Called at the start of the document */
	void startDocument();

	/*! Called at the end of the document */
	void endDocument();

	/*! Called at the start of each element.
	 *
	 * @param name The name of the element.
	 * @param attributes The attributes of the element.
	 */
	void startElement(const XMLCh* const name, XERCES_CPP_NAMESPACE::AttributeList& attributes);

	/*! Called at the end of each element.
	 *
	 * @param name The name of the element.
	 */
	void endElement(const XMLCh* const name);

	/*! The identifier of the type of data stored in the file.
	 *
	 * @return The identifier of the type of data.
	 */
	const affymetrix_calvin_utilities::AffymetrixGuidType &DataTypeIdentifier() const { return dataTypeIdentifier; }

	/*! The files version number.
	 *
	 * @return The file version.
	 */
	u_int8_t FileVersionNumber() const { return fileVersionNumber; }
};

};

#endif // _SAXArrayHandlers_HEADER_