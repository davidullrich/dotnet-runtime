project (PInvokeRevPInvokeUnhandledNative)

include_directories(${INC_PLATFORM_DIR})

if(CLR_CMAKE_HOST_OSX)
  # Enable non-POSIX pthreads APIs, which by default are not included in the pthreads header
  add_definitions(-D_DARWIN_C_SOURCE)
endif(CLR_CMAKE_HOST_OSX)

set(SOURCES PInvokeRevPInvokeUnhandledNative.cpp)

if(NOT CLR_CMAKE_HOST_WIN32)
    add_compile_options(-pthread)
endif()

# add the executable
add_library (PInvokeRevPInvokeUnhandledNative SHARED ${SOURCES})

# add the install targets
install (TARGETS PInvokeRevPInvokeUnhandledNative DESTINATION bin)
