/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class DataGroupHeaderReader {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected DataGroupHeaderReader(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DataGroupHeaderReader obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_DataGroupHeaderReader(swigCPtr);
    }
    swigCPtr = 0;
  }

  public DataGroupHeaderReader() {
    this(affx_fusionJNI.new_DataGroupHeaderReader(), true);
  }

  public void ReadAllMinimumInfo(SWIGTYPE_p_std__ifstream fs, FileHeader fh, long dataGroupCnt) {
    affx_fusionJNI.DataGroupHeaderReader_ReadAllMinimumInfo(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fs), FileHeader.getCPtr(fh), dataGroupCnt);
  }

  public void ReadAll(SWIGTYPE_p_std__ifstream fileStream, FileHeader fh, long dataGroupCnt) {
    affx_fusionJNI.DataGroupHeaderReader_ReadAll(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), FileHeader.getCPtr(fh), dataGroupCnt);
  }

  public long ReadMinimumInfo(SWIGTYPE_p_std__ifstream fileStream, DataGroupHeader dch) {
    return affx_fusionJNI.DataGroupHeaderReader_ReadMinimumInfo(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), DataGroupHeader.getCPtr(dch));
  }

  public long Read(SWIGTYPE_p_std__ifstream fileStream, DataGroupHeader dch) {
    return affx_fusionJNI.DataGroupHeaderReader_Read(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), DataGroupHeader.getCPtr(dch));
  }

  public long ReadHeader(SWIGTYPE_p_std__ifstream fileStream, DataGroupHeader dch) {
    return affx_fusionJNI.DataGroupHeaderReader_ReadHeader(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), DataGroupHeader.getCPtr(dch));
  }

}