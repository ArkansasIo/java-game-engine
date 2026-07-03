cmake_minimum_required(VERSION 3.10)
project(OpenRA)

if(MSVC)
    add_compile_options(/W4 /WX- /EHsc /std:c++17)
endif()

include_directories(
    "${CMAKE_CURRENT_SOURCE_DIR}/Source"
    "${CMAKE_CURRENT_SOURCE_DIR}/Source/OpenRA"
)

file(GLOB_RECURSE SOURCE_FILES 
    "Source/OpenRA/UI/*.cpp" 
    "Source/OpenRA/UI/*.h"
    "Source/OpenRA/Systems/*.cpp" 
    "Source/OpenRA/Systems/*.h"
)

add_library(OpenRA_Lib ${SOURCE_FILES})
