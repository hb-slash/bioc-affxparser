/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CHPFileReader {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected CHPFileReader(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CHPFileReader obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CHPFileReader(swigCPtr);
    }
    swigCPtr = 0;
  }

  public CHPFileReader() {
    this(affx_fusionJNI.new_CHPFileReader(), true);
  }

  public String GetFilename() {
    return affx_fusionJNI.CHPFileReader_GetFilename(swigCPtr);
  }

  public void SetFilename(String name) {
    affx_fusionJNI.CHPFileReader_SetFilename(swigCPtr, name);
  }

  public void Read(CHPData data) {
    affx_fusionJNI.CHPFileReader_Read(swigCPtr, CHPData.getCPtr(data));
  }

}